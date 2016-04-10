namespace ColdSort.UI.Forms
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
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grpLocations = new System.Windows.Forms.GroupBox();
            this.btnDestinationLocationBrowse = new System.Windows.Forms.Button();
            this.txtDestinationLocation = new System.Windows.Forms.TextBox();
            this.lblDestinationLocation = new System.Windows.Forms.Label();
            this.btnSourceLocationBrowse = new System.Windows.Forms.Button();
            this.txtOriginalLocation = new System.Windows.Forms.TextBox();
            this.lblSourceLocation = new System.Windows.Forms.Label();
            this.grpSchema = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpLocations.SuspendLayout();
            this.grpSchema.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOutput
            // 
            this.grpOutput.Location = new System.Drawing.Point(10, 147);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(572, 306);
            this.grpOutput.TabIndex = 12;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
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
            this.btnDestinationLocationBrowse.Click += new System.EventHandler(this.btnDestinationLocationBrowse_Click);
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
            this.btnSourceLocationBrowse.Click += new System.EventHandler(this.btnOriginalLocationBrowse_Click);
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
            this.grpSchema.Controls.Add(this.button5);
            this.grpSchema.Controls.Add(this.button4);
            this.grpSchema.Controls.Add(this.button3);
            this.grpSchema.Controls.Add(this.label3);
            this.grpSchema.Location = new System.Drawing.Point(368, 6);
            this.grpSchema.Name = "grpSchema";
            this.grpSchema.Size = new System.Drawing.Size(214, 130);
            this.grpSchema.TabIndex = 10;
            this.grpSchema.TabStop = false;
            this.grpSchema.Text = "Sortation Schema";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(145, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 20);
            this.button5.TabIndex = 9;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(77, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 20);
            this.button4.TabIndex = 8;
            this.button4.Text = "Create";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 20);
            this.button3.TabIndex = 7;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.grpOutput);
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

        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.GroupBox grpLocations;
        private System.Windows.Forms.Button btnDestinationLocationBrowse;
        private System.Windows.Forms.TextBox txtDestinationLocation;
        private System.Windows.Forms.Label lblDestinationLocation;
        private System.Windows.Forms.Button btnSourceLocationBrowse;
        private System.Windows.Forms.TextBox txtOriginalLocation;
        private System.Windows.Forms.Label lblSourceLocation;
        private System.Windows.Forms.GroupBox grpSchema;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}