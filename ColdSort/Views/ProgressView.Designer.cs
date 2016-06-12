namespace ColdSort.Views
{
    partial class ProgressView
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
            this.pbSortProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgressCount = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbSortProgress
            // 
            this.pbSortProgress.Location = new System.Drawing.Point(12, 12);
            this.pbSortProgress.Name = "pbSortProgress";
            this.pbSortProgress.Size = new System.Drawing.Size(362, 23);
            this.pbSortProgress.TabIndex = 0;
            this.pbSortProgress.Maximum = 100;
            this.pbSortProgress.Value = 0;
            this.pbSortProgress.Step = 1;
            // 
            // lblProgressCount
            // 
            this.lblProgressCount.Location = new System.Drawing.Point(380, 18);
            this.lblProgressCount.Name = "lblProgressCount";
            this.lblProgressCount.Size = new System.Drawing.Size(98, 17);
            this.lblProgressCount.TabIndex = 1;
            this.lblProgressCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAction
            // 
            this.lblAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAction.AutoEllipsis = true;
            this.lblAction.Location = new System.Drawing.Point(12, 47);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(385, 13);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "Loading...";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProgressView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(490, 70);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblProgressCount);
            this.Controls.Add(this.pbSortProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressView";
            this.Text = "Sorting...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbSortProgress;
        private System.Windows.Forms.Label lblProgressCount;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnCancel;
    }
}