namespace HospitalUI
{
    partial class Form1
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
            grb_persMed = new GroupBox();
            SuspendLayout();
            // 
            // grb_persMed
            // 
            grb_persMed.Location = new Point(2, 21);
            grb_persMed.Name = "grb_persMed";
            grb_persMed.Size = new Size(417, 100);
            grb_persMed.TabIndex = 0;
            grb_persMed.TabStop = false;
            grb_persMed.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 542);
            Controls.Add(grb_persMed);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_persMed;
    }
}