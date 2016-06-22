namespace ColdSort.Views
{
    partial class MainView
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
            this.grpLocations = new System.Windows.Forms.GroupBox();
            this.btnDestinationLocationBrowse = new System.Windows.Forms.Button();
            this.txtDestinationLocation = new System.Windows.Forms.TextBox();
            this.lblDestinationLocation = new System.Windows.Forms.Label();
            this.btnSourceLocationBrowse = new System.Windows.Forms.Button();
            this.txtOriginalLocation = new System.Windows.Forms.TextBox();
            this.lblSourceLocation = new System.Windows.Forms.Label();
            this.grpSchema = new System.Windows.Forms.GroupBox();
            this.btnEditSchema = new System.Windows.Forms.Button();
            this.btnCreateSchema = new System.Windows.Forms.Button();
            this.LoadSchema = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancelSort = new System.Windows.Forms.Button();
            this.btnStartSort = new System.Windows.Forms.Button();
            this.lblSchemaTitle = new System.Windows.Forms.Label();
            this.grpLocations.SuspendLayout();
            this.grpSchema.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLocations
            // 
            this.grpLocations.Controls.Add(this.btnDestinationLocationBrowse);
            this.grpLocations.Controls.Add(this.txtDestinationLocation);
            this.grpLocations.Controls.Add(this.lblDestinationLocation);
            this.grpLocations.Controls.Add(this.btnSourceLocationBrowse);
            this.grpLocations.Controls.Add(this.txtOriginalLocation);
            this.grpLocations.Controls.Add(this.lblSourceLocation);
            this.grpLocations.Location = new System.Drawing.Point(12, 6);
            this.grpLocations.Name = "grpLocations";
            this.grpLocations.Size = new System.Drawing.Size(350, 130);
            this.grpLocations.TabIndex = 11;
            this.grpLocations.TabStop = false;
            this.grpLocations.Text = "Music Locations";
            // 
            // btnDestinationLocationBrowse
            // 
            this.btnDestinationLocationBrowse.Location = new System.Drawing.Point(283, 99);
            this.btnDestinationLocationBrowse.Name = "btnDestinationLocationBrowse";
            this.btnDestinationLocationBrowse.Size = new System.Drawing.Size(62, 20);
            this.btnDestinationLocationBrowse.TabIndex = 11;
            this.btnDestinationLocationBrowse.Text = "Browse...";
            this.btnDestinationLocationBrowse.UseVisualStyleBackColor = true;
            this.btnDestinationLocationBrowse.Click += new System.EventHandler(this.BtnDestinationLocationBrowse_Click);
            // 
            // txtDestinationLocation
            // 
            this.txtDestinationLocation.Location = new System.Drawing.Point(6, 99);
            this.txtDestinationLocation.Name = "txtDestinationLocation";
            this.txtDestinationLocation.Size = new System.Drawing.Size(271, 20);
            this.txtDestinationLocation.TabIndex = 10;
            // 
            // lblDestinationLocation
            // 
            this.lblDestinationLocation.AutoSize = true;
            this.lblDestinationLocation.Location = new System.Drawing.Point(6, 83);
            this.lblDestinationLocation.Name = "lblDestinationLocation";
            this.lblDestinationLocation.Size = new System.Drawing.Size(107, 13);
            this.lblDestinationLocation.TabIndex = 9;
            this.lblDestinationLocation.Text = "Destination Location:";
            // 
            // btnSourceLocationBrowse
            // 
            this.btnSourceLocationBrowse.Location = new System.Drawing.Point(283, 46);
            this.btnSourceLocationBrowse.Name = "btnSourceLocationBrowse";
            this.btnSourceLocationBrowse.Size = new System.Drawing.Size(62, 20);
            this.btnSourceLocationBrowse.TabIndex = 8;
            this.btnSourceLocationBrowse.Text = "Browse...";
            this.btnSourceLocationBrowse.UseVisualStyleBackColor = true;
            this.btnSourceLocationBrowse.Click += new System.EventHandler(this.BtnOriginalLocationBrowse_Click);
            // 
            // txtOriginalLocation
            // 
            this.txtOriginalLocation.Location = new System.Drawing.Point(6, 46);
            this.txtOriginalLocation.Name = "txtOriginalLocation";
            this.txtOriginalLocation.Size = new System.Drawing.Size(271, 20);
            this.txtOriginalLocation.TabIndex = 7;
            // 
            // lblSourceLocation
            // 
            this.lblSourceLocation.AutoSize = true;
            this.lblSourceLocation.Location = new System.Drawing.Point(6, 30);
            this.lblSourceLocation.Name = "lblSourceLocation";
            this.lblSourceLocation.Size = new System.Drawing.Size(88, 13);
            this.lblSourceLocation.TabIndex = 6;
            this.lblSourceLocation.Text = "Source Location:";
            // 
            // grpSchema
            // 
            this.grpSchema.Controls.Add(this.lblSchemaTitle);
            this.grpSchema.Controls.Add(this.btnEditSchema);
            this.grpSchema.Controls.Add(this.btnCreateSchema);
            this.grpSchema.Controls.Add(this.LoadSchema);
            this.grpSchema.Controls.Add(this.lblTitle);
            this.grpSchema.Location = new System.Drawing.Point(12, 142);
            this.grpSchema.Name = "grpSchema";
            this.grpSchema.Size = new System.Drawing.Size(350, 86);
            this.grpSchema.TabIndex = 10;
            this.grpSchema.TabStop = false;
            this.grpSchema.Text = "Sortation Schema";
            // 
            // btnEditSchema
            // 
            this.btnEditSchema.Location = new System.Drawing.Point(145, 57);
            this.btnEditSchema.Name = "btnEditSchema";
            this.btnEditSchema.Size = new System.Drawing.Size(62, 20);
            this.btnEditSchema.TabIndex = 9;
            this.btnEditSchema.Text = "Edit";
            this.btnEditSchema.UseVisualStyleBackColor = true;
            this.btnEditSchema.Click += new System.EventHandler(this.BtnEditSchema_Click);
            // 
            // btnCreateSchema
            // 
            this.btnCreateSchema.Location = new System.Drawing.Point(77, 57);
            this.btnCreateSchema.Name = "btnCreateSchema";
            this.btnCreateSchema.Size = new System.Drawing.Size(62, 20);
            this.btnCreateSchema.TabIndex = 8;
            this.btnCreateSchema.Text = "Create";
            this.btnCreateSchema.UseVisualStyleBackColor = true;
            this.btnCreateSchema.Click += new System.EventHandler(this.BtnCreateSchema_Click);
            // 
            // LoadSchema
            // 
            this.LoadSchema.Enabled = false;
            this.LoadSchema.Location = new System.Drawing.Point(9, 57);
            this.LoadSchema.Name = "LoadSchema";
            this.LoadSchema.Size = new System.Drawing.Size(62, 20);
            this.LoadSchema.TabIndex = 7;
            this.LoadSchema.Text = "Load";
            this.LoadSchema.UseVisualStyleBackColor = true;
            this.LoadSchema.Click += new System.EventHandler(this.LoadSchema_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // btnCancelSort
            // 
            this.btnCancelSort.Enabled = false;
            this.btnCancelSort.Location = new System.Drawing.Point(251, 234);
            this.btnCancelSort.Name = "btnCancelSort";
            this.btnCancelSort.Size = new System.Drawing.Size(111, 23);
            this.btnCancelSort.TabIndex = 11;
            this.btnCancelSort.Text = "Sort W/ Diagnostics";
            this.btnCancelSort.UseVisualStyleBackColor = true;
            // 
            // btnStartSort
            // 
            this.btnStartSort.Location = new System.Drawing.Point(183, 234);
            this.btnStartSort.Name = "btnStartSort";
            this.btnStartSort.Size = new System.Drawing.Size(62, 23);
            this.btnStartSort.TabIndex = 10;
            this.btnStartSort.Text = "Sort";
            this.btnStartSort.UseVisualStyleBackColor = true;
            this.btnStartSort.Click += new System.EventHandler(this.BtnStartSort_Click);
            // 
            // lblSchemaTitle
            // 
            this.lblSchemaTitle.AutoSize = true;
            this.lblSchemaTitle.Location = new System.Drawing.Point(41, 28);
            this.lblSchemaTitle.Name = "lblSchemaTitle";
            this.lblSchemaTitle.Size = new System.Drawing.Size(0, 13);
            this.lblSchemaTitle.TabIndex = 10;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 264);
            this.Controls.Add(this.btnCancelSort);
            this.Controls.Add(this.btnStartSort);
            this.Controls.Add(this.grpLocations);
            this.Controls.Add(this.grpSchema);
            this.Name = "MainView";
            this.Text = "MainView";
            this.grpLocations.ResumeLayout(false);
            this.grpLocations.PerformLayout();
            this.grpSchema.ResumeLayout(false);
            this.grpSchema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpLocations;
        private System.Windows.Forms.Button btnDestinationLocationBrowse;
        private System.Windows.Forms.TextBox txtDestinationLocation;
        private System.Windows.Forms.Label lblDestinationLocation;
        private System.Windows.Forms.Button btnSourceLocationBrowse;
        private System.Windows.Forms.TextBox txtOriginalLocation;
        private System.Windows.Forms.Label lblSourceLocation;
        private System.Windows.Forms.GroupBox grpSchema;
        private System.Windows.Forms.Button btnEditSchema;
        private System.Windows.Forms.Button btnCreateSchema;
        private System.Windows.Forms.Button LoadSchema;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancelSort;
        private System.Windows.Forms.Button btnStartSort;
        private System.Windows.Forms.Label lblSchemaTitle;
    }
}