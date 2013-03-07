using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.TeamFoundation.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace TFSMergeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class WorkSpaceItem
        {
            public string Name { get; set; }
            public Workspace WorkSpace { get; set; }

            public WorkSpaceItem(string name, Workspace workspace)
            {
                this.Name = name;
                this.WorkSpace = workspace;
            }
            public override string ToString()
            {
                return this.Name;
            }
        }

        public Workspace[] GetWorkspaces()
        {
            try
            {
                return m_VCS.QueryWorkspaces(null, m_VCS.AuthorizedUser, System.Net.Dns.GetHostName().ToString());
            }
            catch
            {
                throw;
            }
        }

        private void AddWorkSpaces()
        {
            Workspace[] wss = GetWorkspaces();
            comboBoxWorkspaces.Items.Clear();
            foreach (Workspace ws in wss)
            {
                WorkSpaceItem item = new WorkSpaceItem(ws.Name, ws);
                comboBoxWorkspaces.Items.Add(item);
            }
        }

        private TfsTeamProjectCollection m_TPC = null;
        private VersionControlServer m_VCS = null;
        WorkItemStore m_WorkItemStore = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="workItemID"></param>
        /// <param name="changesets"></param>
        /// <param name="visitedItems"></param>
        private void GetAssociatedChangesets(int workItemID, List<Changeset> changesets, List<int> visitedItems)
        {
            if (visitedItems.Contains(workItemID))
            {
                return;
            }
            else
            {
                visitedItems.Add(workItemID);
            }

            WorkItem workItem = m_WorkItemStore.GetWorkItem(workItemID);

            Log(string.Format("Getting changesets for work item {0}: '{1}'...", workItemID, workItem.Title)); ;

            int i = 0;
            foreach (Link link in workItem.Links)
            {
                //Log(string.Format("Inspecting link {0} of type {1}", i++, link.GetType().ToString()));

                RelatedLink relatedLink = link as RelatedLink;
                ExternalLink externalLink = link as ExternalLink;

                if (relatedLink != null)
                {
                    GetAssociatedChangesets(relatedLink.RelatedWorkItemId, changesets, visitedItems);
                }
                
                if (externalLink != null)
                {
                    ArtifactId artifact = LinkingUtilities.DecodeUri(externalLink.LinkedArtifactUri);
                    if (String.Equals(artifact.ArtifactType, "Changeset", StringComparison.Ordinal))
                    {
                        Changeset changeset = m_VCS.ArtifactProvider.GetChangeset(new Uri(externalLink.LinkedArtifactUri));
                        changesets.Add(changeset);

                        Log(string.Format("Found changeset {0}: '{1}'", changeset.ChangesetId, TruncateComment(changeset.Comment)));
                    }
                }

            }
        }

        private string TruncateComment(string comment)
        {
            comment = comment.Replace(Environment.NewLine, "|");
            if (comment.Length > 65)
            {
                comment = comment.Substring(0, 65) + "...";
            }

            return comment;
        }

        private void InitializeTFS()
        {
            m_TPC = new TfsTeamProjectCollection(new Uri("http://usw-am-app-03.am.trimblecorp.net:8080/tfs"));
            m_VCS = m_TPC.GetService(typeof(VersionControlServer)) as VersionControlServer;
            m_WorkItemStore = (WorkItemStore)m_TPC.GetService(typeof(WorkItemStore));
        }

        private void buttonGetWorkItemChangesets_Click(object sender, EventArgs e)
        {   
            if (m_TPC == null || m_VCS == null || m_WorkItemStore == null)
            {
                InitializeTFS();
            }

            List<int> visitedItems = new List<int>();
            List<Changeset> relatedChangesets = new List<Changeset>();

            GetAssociatedChangesets(Convert.ToInt32(textBoxWorkItem.Text), relatedChangesets, visitedItems);

            AddChangesetsToUI(relatedChangesets);

            AddWorkSpaces();
        }

        private void Log(string message)
        {
            textBox1.Text += message + Environment.NewLine;
            textBox1.Update();
        }

        private void AddChangesetsToUI(List<Changeset> changesets)
        {
            foreach (Changeset changeset in changesets)
            {
                ListViewItem item = listViewChangesets.Items.Add(changeset.ChangesetId.ToString());
                item.SubItems.Add(changeset.Comment);
                item.SubItems.Add(changeset.CreationDate.ToShortDateString());
                item.Tag = changeset;
            }
        }

        private void listViewChangesets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            Workspace workspace = (comboBoxWorkspaces.SelectedItem as WorkSpaceItem).WorkSpace;

            foreach (ListViewItem changesetItem in listViewChangesets.SelectedItems)
            {  
                VersionSpec changesetToMerge = new ChangesetVersionSpec((changesetItem.Tag as Changeset).ChangesetId);
                GetStatus status = workspace.Merge(textBoxSourcePath.Text, textBoxDestPath.Text, changesetToMerge, changesetToMerge);
            }
        }

    }
}
