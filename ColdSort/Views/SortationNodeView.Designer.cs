namespace ColdSort.Views
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
            this.cbxSelectProperty = new System.Windows.Forms.ComboBox();
            this.lblSongProperty = new System.Windows.Forms.Label();
            this.chkAllowSortEnd = new System.Windows.Forms.CheckBox();
            this.chkAbbreviateProperty = new System.Windows.Forms.CheckBox();
            this.btnConfirmNode = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAbbreviateOptions = new System.Windows.Forms.GroupBox();
            this.chkCaptitalizeAbbreviation = new System.Windows.Forms.CheckBox();
            this.chkCondenseNumbers = new System.Windows.Forms.CheckBox();
            this.grpAbbreviateOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSelectProperty
            // 
            this.cbxSelectProperty.FormattingEnabled = true;
            this.cbxSelectProperty.Location = new System.Drawing.Point(15, 25);
            this.cbxSelectProperty.Name = "cbxSelectProperty";
            this.cbxSelectProperty.Size = new System.Drawing.Size(164, 21);
            this.cbxSelectProperty.TabIndex = 2;
            // 
            // lblSongProperty
            // 
            this.lblSongProperty.AutoSize = true;
            this.lblSongProperty.Location = new System.Drawing.Point(12, 9);
            this.lblSongProperty.Name = "lblSongProperty";
            this.lblSongProperty.Size = new System.Drawing.Size(130, 13);
            this.lblSongProperty.TabIndex = 3;
            this.lblSongProperty.Text = "Song Property To Sort By:";
            // 
            // chkAllowSortEnd
            // 
            this.chkAllowSortEnd.AutoSize = true;
            this.chkAllowSortEnd.Location = new System.Drawing.Point(15, 50);
            this.chkAllowSortEnd.Name = "chkAllowSortEnd";
            this.chkAllowSortEnd.Size = new System.Drawing.Size(160, 17);
            this.chkAllowSortEnd.TabIndex = 4;
            this.chkAllowSortEnd.Text = "Allow Sortation To End Here";
            this.chkAllowSortEnd.UseVisualStyleBackColor = true;
            // 
            // chkAbbreviateProperty
            // 
            this.chkAbbreviateProperty.AutoSize = true;
            this.chkAbbreviateProperty.Location = new System.Drawing.Point(15, 73);
            this.chkAbbreviateProperty.Name = "chkAbbreviateProperty";
            this.chkAbbreviateProperty.Size = new System.Drawing.Size(149, 17);
            this.chkAbbreviateProperty.TabIndex = 5;
            this.chkAbbreviateProperty.Text = "Abbreviate Property Value";
            this.chkAbbreviateProperty.UseVisualStyleBackColor = true;
            this.chkAbbreviateProperty.CheckedChanged += new System.EventHandler(this.chkAbbreviateProperty_CheckedChanged);
            // 
            // btnConfirmNode
            // 
            this.btnConfirmNode.Location = new System.Drawing.Point(15, 167);
            this.btnConfirmNode.Name = "btnConfirmNode";
            this.btnConfirmNode.Size = new System.Drawing.Size(78, 27);
            this.btnConfirmNode.TabIndex = 6;
            this.btnConfirmNode.Text = "OK";
            this.btnConfirmNode.UseVisualStyleBackColor = true;
            this.btnConfirmNode.Click += new System.EventHandler(this.BtnConfirmNode_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(101, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // grpAbbreviateOptions
            // 
            this.grpAbbreviateOptions.Controls.Add(this.chkCaptitalizeAbbreviation);
            this.grpAbbreviateOptions.Controls.Add(this.chkCondenseNumbers);
            this.grpAbbreviateOptions.Location = new System.Drawing.Point(15, 94);
            this.grpAbbreviateOptions.Name = "grpAbbreviateOptions";
            this.grpAbbreviateOptions.Size = new System.Drawing.Size(159, 64);
            this.grpAbbreviateOptions.TabIndex = 9;
            this.grpAbbreviateOptions.TabStop = false;
            this.grpAbbreviateOptions.Text = "Abbreviate Options";
            // 
            // chkCaptitalizeAbbreviation
            // 
            this.chkCaptitalizeAbbreviation.AutoSize = true;
            this.chkCaptitalizeAbbreviation.Enabled = false;
            this.chkCaptitalizeAbbreviation.Location = new System.Drawing.Point(4, 42);
            this.chkCaptitalizeAbbreviation.Name = "chkCaptitalizeAbbreviation";
            this.chkCaptitalizeAbbreviation.Size = new System.Drawing.Size(138, 17);
            this.chkCaptitalizeAbbreviation.TabIndex = 10;
            this.chkCaptitalizeAbbreviation.Text = "Capitalize Abbreviations";
            this.chkCaptitalizeAbbreviation.UseVisualStyleBackColor = true;
            // 
            // chkCondenseNumbers
            // 
            this.chkCondenseNumbers.AutoSize = true;
            this.chkCondenseNumbers.Enabled = false;
            this.chkCondenseNumbers.Location = new System.Drawing.Point(4, 18);
            this.chkCondenseNumbers.Name = "chkCondenseNumbers";
            this.chkCondenseNumbers.Size = new System.Drawing.Size(151, 17);
            this.chkCondenseNumbers.TabIndex = 9;
            this.chkCondenseNumbers.Text = "Condense Numbers to \"#\"";
            this.chkCondenseNumbers.UseVisualStyleBackColor = true;
            // 
            // SortationNodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 205);
            this.Controls.Add(this.grpAbbreviateOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmNode);
            this.Controls.Add(this.chkAbbreviateProperty);
            this.Controls.Add(this.chkAllowSortEnd);
            this.Controls.Add(this.lblSongProperty);
            this.Controls.Add(this.cbxSelectProperty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortationNodeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Sortation Node";
            this.grpAbbreviateOptions.ResumeLayout(false);
            this.grpAbbreviateOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxSelectProperty;
        private System.Windows.Forms.Label lblSongProperty;
        private System.Windows.Forms.CheckBox chkAllowSortEnd;
        private System.Windows.Forms.CheckBox chkAbbreviateProperty;
        private System.Windows.Forms.Button btnConfirmNode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpAbbreviateOptions;
        private System.Windows.Forms.CheckBox chkCondenseNumbers;
        private System.Windows.Forms.CheckBox chkCaptitalizeAbbreviation;
    }
}