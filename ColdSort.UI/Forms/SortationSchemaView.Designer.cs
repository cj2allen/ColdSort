namespace ColdSort.UI.Forms
{
    partial class SortationSchemaView
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
            this.lblSortationSchemaTitle = new System.Windows.Forms.Label();
            this.txtSortationSchemaName = new System.Windows.Forms.TextBox();
            this.grpNodeOptions = new System.Windows.Forms.GroupBox();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.btnEditNode = new System.Windows.Forms.Button();
            this.btnNewNode = new System.Windows.Forms.Button();
            this.btnLowerNode = new System.Windows.Forms.Button();
            this.btnRaiseNode = new System.Windows.Forms.Button();
            this.lstSortationNodes = new System.Windows.Forms.ListBox();
            this.grpUnsortableOptions = new System.Windows.Forms.GroupBox();
            this.txtFailedDefaultLocation = new System.Windows.Forms.TextBox();
            this.rdoFailedDefaultLocation = new System.Windows.Forms.RadioButton();
            this.rdoKeepLocation = new System.Windows.Forms.RadioButton();
            this.grpNodeOptions.SuspendLayout();
            this.grpUnsortableOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSortationSchemaTitle
            // 
            this.lblSortationSchemaTitle.AutoSize = true;
            this.lblSortationSchemaTitle.Location = new System.Drawing.Point(12, 9);
            this.lblSortationSchemaTitle.Name = "lblSortationSchemaTitle";
            this.lblSortationSchemaTitle.Size = new System.Drawing.Size(189, 13);
            this.lblSortationSchemaTitle.TabIndex = 3;
            this.lblSortationSchemaTitle.Text = "Sortation Schema Title (25 Characters)";
            // 
            // txtSortationSchemaName
            // 
            this.txtSortationSchemaName.Location = new System.Drawing.Point(12, 25);
            this.txtSortationSchemaName.MaxLength = 25;
            this.txtSortationSchemaName.Name = "txtSortationSchemaName";
            this.txtSortationSchemaName.Size = new System.Drawing.Size(189, 20);
            this.txtSortationSchemaName.TabIndex = 4;
            // 
            // grpNodeOptions
            // 
            this.grpNodeOptions.Controls.Add(this.btnDeleteNode);
            this.grpNodeOptions.Controls.Add(this.btnEditNode);
            this.grpNodeOptions.Controls.Add(this.btnNewNode);
            this.grpNodeOptions.Controls.Add(this.btnLowerNode);
            this.grpNodeOptions.Controls.Add(this.btnRaiseNode);
            this.grpNodeOptions.Controls.Add(this.lstSortationNodes);
            this.grpNodeOptions.Location = new System.Drawing.Point(215, 12);
            this.grpNodeOptions.Name = "grpNodeOptions";
            this.grpNodeOptions.Size = new System.Drawing.Size(262, 134);
            this.grpNodeOptions.TabIndex = 8;
            this.grpNodeOptions.TabStop = false;
            this.grpNodeOptions.Text = "Node Options";
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.Location = new System.Drawing.Point(174, 94);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(78, 31);
            this.btnDeleteNode.TabIndex = 13;
            this.btnDeleteNode.Text = "Delete Node";
            this.btnDeleteNode.UseVisualStyleBackColor = true;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            // 
            // btnEditNode
            // 
            this.btnEditNode.Location = new System.Drawing.Point(90, 94);
            this.btnEditNode.Name = "btnEditNode";
            this.btnEditNode.Size = new System.Drawing.Size(78, 31);
            this.btnEditNode.TabIndex = 12;
            this.btnEditNode.Text = "Edit Node";
            this.btnEditNode.UseVisualStyleBackColor = true;
            this.btnEditNode.Click += new System.EventHandler(this.btnEditNode_Click);
            // 
            // btnNewNode
            // 
            this.btnNewNode.Location = new System.Drawing.Point(6, 94);
            this.btnNewNode.Name = "btnNewNode";
            this.btnNewNode.Size = new System.Drawing.Size(78, 31);
            this.btnNewNode.TabIndex = 11;
            this.btnNewNode.Text = "New Node";
            this.btnNewNode.UseVisualStyleBackColor = true;
            this.btnNewNode.Click += new System.EventHandler(this.btnNewNode_Click);
            // 
            // btnLowerNode
            // 
            this.btnLowerNode.Location = new System.Drawing.Point(6, 56);
            this.btnLowerNode.Name = "btnLowerNode";
            this.btnLowerNode.Size = new System.Drawing.Size(78, 31);
            this.btnLowerNode.TabIndex = 10;
            this.btnLowerNode.Text = "Lower Node";
            this.btnLowerNode.UseVisualStyleBackColor = true;
            this.btnLowerNode.Click += new System.EventHandler(this.btnLowerNode_Click);
            // 
            // btnRaiseNode
            // 
            this.btnRaiseNode.Location = new System.Drawing.Point(6, 19);
            this.btnRaiseNode.Name = "btnRaiseNode";
            this.btnRaiseNode.Size = new System.Drawing.Size(78, 31);
            this.btnRaiseNode.TabIndex = 9;
            this.btnRaiseNode.Text = "Raise Node";
            this.btnRaiseNode.UseVisualStyleBackColor = true;
            this.btnRaiseNode.Click += new System.EventHandler(this.btnRaiseNode_Click);
            // 
            // lstSortationNodes
            // 
            this.lstSortationNodes.FormattingEnabled = true;
            this.lstSortationNodes.Location = new System.Drawing.Point(90, 19);
            this.lstSortationNodes.Name = "lstSortationNodes";
            this.lstSortationNodes.Size = new System.Drawing.Size(162, 69);
            this.lstSortationNodes.TabIndex = 8;
            // 
            // grpUnsortableOptions
            // 
            this.grpUnsortableOptions.Controls.Add(this.txtFailedDefaultLocation);
            this.grpUnsortableOptions.Controls.Add(this.rdoFailedDefaultLocation);
            this.grpUnsortableOptions.Controls.Add(this.rdoKeepLocation);
            this.grpUnsortableOptions.Location = new System.Drawing.Point(12, 51);
            this.grpUnsortableOptions.Name = "grpUnsortableOptions";
            this.grpUnsortableOptions.Size = new System.Drawing.Size(197, 95);
            this.grpUnsortableOptions.TabIndex = 9;
            this.grpUnsortableOptions.TabStop = false;
            this.grpUnsortableOptions.Text = "Where To Put Unsortable Songs";
            // 
            // txtFailedDefaultLocation
            // 
            this.txtFailedDefaultLocation.Enabled = false;
            this.txtFailedDefaultLocation.Location = new System.Drawing.Point(6, 65);
            this.txtFailedDefaultLocation.Name = "txtFailedDefaultLocation";
            this.txtFailedDefaultLocation.Size = new System.Drawing.Size(178, 20);
            this.txtFailedDefaultLocation.TabIndex = 2;
            // 
            // rdoFailedDefaultLocation
            // 
            this.rdoFailedDefaultLocation.AutoSize = true;
            this.rdoFailedDefaultLocation.Location = new System.Drawing.Point(6, 42);
            this.rdoFailedDefaultLocation.Name = "rdoFailedDefaultLocation";
            this.rdoFailedDefaultLocation.Size = new System.Drawing.Size(128, 17);
            this.rdoFailedDefaultLocation.TabIndex = 1;
            this.rdoFailedDefaultLocation.Text = "Move To New Folder:";
            this.rdoFailedDefaultLocation.UseVisualStyleBackColor = true;
            // 
            // rdoKeepLocation
            // 
            this.rdoKeepLocation.AutoSize = true;
            this.rdoKeepLocation.Checked = true;
            this.rdoKeepLocation.Location = new System.Drawing.Point(6, 19);
            this.rdoKeepLocation.Name = "rdoKeepLocation";
            this.rdoKeepLocation.Size = new System.Drawing.Size(169, 17);
            this.rdoKeepLocation.TabIndex = 0;
            this.rdoKeepLocation.TabStop = true;
            this.rdoKeepLocation.Text = "Keep Files At Original Location";
            this.rdoKeepLocation.UseVisualStyleBackColor = true;
            // 
            // SortationSchemaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 159);
            this.Controls.Add(this.grpUnsortableOptions);
            this.Controls.Add(this.grpNodeOptions);
            this.Controls.Add(this.txtSortationSchemaName);
            this.Controls.Add(this.lblSortationSchemaTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortationSchemaView";
            this.Text = "Edit Sortation Schema";
            this.grpNodeOptions.ResumeLayout(false);
            this.grpUnsortableOptions.ResumeLayout(false);
            this.grpUnsortableOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSortationSchemaTitle;
        private System.Windows.Forms.TextBox txtSortationSchemaName;
        private System.Windows.Forms.GroupBox grpNodeOptions;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.Button btnEditNode;
        private System.Windows.Forms.Button btnNewNode;
        private System.Windows.Forms.Button btnLowerNode;
        private System.Windows.Forms.Button btnRaiseNode;
        private System.Windows.Forms.ListBox lstSortationNodes;
        private System.Windows.Forms.GroupBox grpUnsortableOptions;
        private System.Windows.Forms.TextBox txtFailedDefaultLocation;
        private System.Windows.Forms.RadioButton rdoFailedDefaultLocation;
        private System.Windows.Forms.RadioButton rdoKeepLocation;
    }
}