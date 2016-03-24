namespace ColdSort.GUI
{
    partial class Main
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
            this.grpSchema = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpLocations = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSchema.SuspendLayout();
            this.grpLocations.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSchema
            // 
            this.grpSchema.Controls.Add(this.button5);
            this.grpSchema.Controls.Add(this.button4);
            this.grpSchema.Controls.Add(this.button3);
            this.grpSchema.Controls.Add(this.label3);
            this.grpSchema.Location = new System.Drawing.Point(368, 12);
            this.grpSchema.Name = "grpSchema";
            this.grpSchema.Size = new System.Drawing.Size(214, 130);
            this.grpSchema.TabIndex = 6;
            this.grpSchema.TabStop = false;
            this.grpSchema.Text = "Sortation Schema";
            this.grpSchema.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // grpLocations
            // 
            this.grpLocations.Controls.Add(this.button2);
            this.grpLocations.Controls.Add(this.textBox2);
            this.grpLocations.Controls.Add(this.label2);
            this.grpLocations.Controls.Add(this.button1);
            this.grpLocations.Controls.Add(this.textBox1);
            this.grpLocations.Controls.Add(this.lbl);
            this.grpLocations.Location = new System.Drawing.Point(12, 12);
            this.grpLocations.Name = "grpLocations";
            this.grpLocations.Size = new System.Drawing.Size(350, 130);
            this.grpLocations.TabIndex = 7;
            this.grpLocations.TabStop = false;
            this.grpLocations.Text = "Music Locations";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destination Location:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 30);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(88, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Source Location:";
            // 
            // grpOutput
            // 
            this.grpOutput.Location = new System.Drawing.Point(10, 153);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(572, 306);
            this.grpOutput.TabIndex = 8;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(595, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statProgress";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 528);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpLocations);
            this.Controls.Add(this.grpSchema);
            this.Name = "Main";
            this.Text = "Cold Sort";
            this.grpSchema.ResumeLayout(false);
            this.grpSchema.PerformLayout();
            this.grpLocations.ResumeLayout(false);
            this.grpLocations.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSchema;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpLocations;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}