namespace ColdSort.UI.Forms
{
    partial class SortationNodeView
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
            this.lblNodeName = new System.Windows.Forms.Label();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.cbxSelectProperty = new System.Windows.Forms.ComboBox();
            this.lblSongProperty = new System.Windows.Forms.Label();
            this.chkAllowSortEnd = new System.Windows.Forms.CheckBox();
            this.chkAbbreviateProperty = new System.Windows.Forms.CheckBox();
            this.btnSaveNode = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNodeName
            // 
            this.lblNodeName.AutoSize = true;
            this.lblNodeName.Location = new System.Drawing.Point(12, 9);
            this.lblNodeName.Name = "lblNodeName";
            this.lblNodeName.Size = new System.Drawing.Size(154, 13);
            this.lblNodeName.TabIndex = 0;
            this.lblNodeName.Text = "Sortation Node Name (15 char)";
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(15, 25);
            this.txtNodeName.MaxLength = 15;
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(160, 20);
            this.txtNodeName.TabIndex = 1;
            // 
            // cbxSelectProperty
            // 
            this.cbxSelectProperty.FormattingEnabled = true;
            this.cbxSelectProperty.Location = new System.Drawing.Point(15, 64);
            this.cbxSelectProperty.Name = "cbxSelectProperty";
            this.cbxSelectProperty.Size = new System.Drawing.Size(164, 21);
            this.cbxSelectProperty.TabIndex = 2;
            // 
            // lblSongProperty
            // 
            this.lblSongProperty.AutoSize = true;
            this.lblSongProperty.Location = new System.Drawing.Point(12, 48);
            this.lblSongProperty.Name = "lblSongProperty";
            this.lblSongProperty.Size = new System.Drawing.Size(130, 13);
            this.lblSongProperty.TabIndex = 3;
            this.lblSongProperty.Text = "Song Property To Sort By:";
            // 
            // chkAllowSortEnd
            // 
            this.chkAllowSortEnd.AutoSize = true;
            this.chkAllowSortEnd.Location = new System.Drawing.Point(15, 87);
            this.chkAllowSortEnd.Name = "chkAllowSortEnd";
            this.chkAllowSortEnd.Size = new System.Drawing.Size(160, 17);
            this.chkAllowSortEnd.TabIndex = 4;
            this.chkAllowSortEnd.Text = "Allow Sortation To End Here";
            this.chkAllowSortEnd.UseVisualStyleBackColor = true;
            // 
            // chkAbbreviateProperty
            // 
            this.chkAbbreviateProperty.AutoSize = true;
            this.chkAbbreviateProperty.Location = new System.Drawing.Point(15, 110);
            this.chkAbbreviateProperty.Name = "chkAbbreviateProperty";
            this.chkAbbreviateProperty.Size = new System.Drawing.Size(149, 17);
            this.chkAbbreviateProperty.TabIndex = 5;
            this.chkAbbreviateProperty.Text = "Abbreviate Property Value";
            this.chkAbbreviateProperty.UseVisualStyleBackColor = true;
            // 
            // btnSaveNode
            // 
            this.btnSaveNode.Location = new System.Drawing.Point(15, 133);
            this.btnSaveNode.Name = "btnSaveNode";
            this.btnSaveNode.Size = new System.Drawing.Size(78, 27);
            this.btnSaveNode.TabIndex = 6;
            this.btnSaveNode.Text = "Save";
            this.btnSaveNode.UseVisualStyleBackColor = true;
            this.btnSaveNode.Click += new System.EventHandler(this.btnSaveNode_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(101, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SortationNodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 174);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveNode);
            this.Controls.Add(this.chkAbbreviateProperty);
            this.Controls.Add(this.chkAllowSortEnd);
            this.Controls.Add(this.lblSongProperty);
            this.Controls.Add(this.cbxSelectProperty);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.lblNodeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortationNodeView";
            this.Text = "Edit Sortation Node";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNodeName;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.ComboBox cbxSelectProperty;
        private System.Windows.Forms.Label lblSongProperty;
        private System.Windows.Forms.CheckBox chkAllowSortEnd;
        private System.Windows.Forms.CheckBox chkAbbreviateProperty;
        private System.Windows.Forms.Button btnSaveNode;
        private System.Windows.Forms.Button btnCancel;
    }
}