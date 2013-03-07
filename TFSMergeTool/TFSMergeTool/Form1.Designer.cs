namespace TFSMergeTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetWorkItemChangesets = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxWorkItem = new System.Windows.Forms.TextBox();
            this.labelWorkItem = new System.Windows.Forms.Label();
            this.listViewChangesets = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSourcePath = new System.Windows.Forms.TextBox();
            this.textBoxDestPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.comboBoxWorkspaces = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonGetWorkItemChangesets
            // 
            this.buttonGetWorkItemChangesets.Location = new System.Drawing.Point(11, 51);
            this.buttonGetWorkItemChangesets.Name = "buttonGetWorkItemChangesets";
            this.buttonGetWorkItemChangesets.Size = new System.Drawing.Size(126, 23);
            this.buttonGetWorkItemChangesets.TabIndex = 0;
            this.buttonGetWorkItemChangesets.Text = "Fetch changesets";
            this.buttonGetWorkItemChangesets.UseVisualStyleBackColor = true;
            this.buttonGetWorkItemChangesets.Click += new System.EventHandler(this.buttonGetWorkItemChangesets_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 421);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(918, 197);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxWorkItem
            // 
            this.textBoxWorkItem.Location = new System.Drawing.Point(11, 25);
            this.textBoxWorkItem.Name = "textBoxWorkItem";
            this.textBoxWorkItem.Size = new System.Drawing.Size(126, 20);
            this.textBoxWorkItem.TabIndex = 2;
            this.textBoxWorkItem.Text = "13927";
            // 
            // labelWorkItem
            // 
            this.labelWorkItem.AutoSize = true;
            this.labelWorkItem.Location = new System.Drawing.Point(12, 9);
            this.labelWorkItem.Name = "labelWorkItem";
            this.labelWorkItem.Size = new System.Drawing.Size(56, 13);
            this.labelWorkItem.TabIndex = 3;
            this.labelWorkItem.Text = "WorkItem:";
            // 
            // listViewChangesets
            // 
            this.listViewChangesets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewChangesets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Comment,
            this.Date});
            this.listViewChangesets.FullRowSelect = true;
            this.listViewChangesets.Location = new System.Drawing.Point(15, 97);
            this.listViewChangesets.Name = "listViewChangesets";
            this.listViewChangesets.Size = new System.Drawing.Size(918, 318);
            this.listViewChangesets.TabIndex = 4;
            this.listViewChangesets.UseCompatibleStateImageBehavior = false;
            this.listViewChangesets.View = System.Windows.Forms.View.Details;
            this.listViewChangesets.SelectedIndexChanged += new System.EventHandler(this.listViewChangesets_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 72;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 683;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 141;
            // 
            // textBoxSourcePath
            // 
            this.textBoxSourcePath.Location = new System.Drawing.Point(289, 12);
            this.textBoxSourcePath.Name = "textBoxSourcePath";
            this.textBoxSourcePath.Size = new System.Drawing.Size(459, 20);
            this.textBoxSourcePath.TabIndex = 5;
            this.textBoxSourcePath.Text = "D:\\Source\\TBC2011\\Program";
            // 
            // textBoxDestPath
            // 
            this.textBoxDestPath.Location = new System.Drawing.Point(289, 38);
            this.textBoxDestPath.Name = "textBoxDestPath";
            this.textBoxDestPath.Size = new System.Drawing.Size(459, 20);
            this.textBoxDestPath.TabIndex = 6;
            this.textBoxDestPath.Text = "D:\\Source\\Construction 2.7\\Program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Source Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dest Path:";
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(217, 68);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(531, 23);
            this.buttonMerge.TabIndex = 9;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // comboBoxWorkspaces
            // 
            this.comboBoxWorkspaces.FormattingEnabled = true;
            this.comboBoxWorkspaces.Location = new System.Drawing.Point(772, 15);
            this.comboBoxWorkspaces.Name = "comboBoxWorkspaces";
            this.comboBoxWorkspaces.Size = new System.Drawing.Size(161, 21);
            this.comboBoxWorkspaces.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 630);
            this.Controls.Add(this.comboBoxWorkspaces);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDestPath);
            this.Controls.Add(this.textBoxSourcePath);
            this.Controls.Add(this.listViewChangesets);
            this.Controls.Add(this.labelWorkItem);
            this.Controls.Add(this.textBoxWorkItem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGetWorkItemChangesets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetWorkItemChangesets;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxWorkItem;
        private System.Windows.Forms.Label labelWorkItem;
        private System.Windows.Forms.ListView listViewChangesets;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.TextBox textBoxSourcePath;
        private System.Windows.Forms.TextBox textBoxDestPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.ComboBox comboBoxWorkspaces;
    }
}

