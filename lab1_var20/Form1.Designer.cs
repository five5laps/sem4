
namespace lab1_var20
{
    partial class OOP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RmbStateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RmbStateLabel
            // 
            this.RmbStateLabel.AutoSize = true;
            this.RmbStateLabel.Location = new System.Drawing.Point(12, 34);
            this.RmbStateLabel.Name = "RmbStateLabel";
            this.RmbStateLabel.Size = new System.Drawing.Size(115, 15);
            this.RmbStateLabel.TabIndex = 0;
            this.RmbStateLabel.Text = "RMB NOT DETECTED";
            // 
            // OOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 88);
            this.Controls.Add(this.RmbStateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OOP";
            this.Text = "Form1";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RmbStateLabel;
    }
}

