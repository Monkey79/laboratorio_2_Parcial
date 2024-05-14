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
            grb_persMed = new System.Windows.Forms.GroupBox();
            lsb_medicos = new System.Windows.Forms.ListBox();
            grb_pacientes = new System.Windows.Forms.GroupBox();
            lsb_pacientes = new System.Windows.Forms.ListBox();
            btn_atender = new System.Windows.Forms.Button();
            btn_salir = new System.Windows.Forms.Button();
            rtxb_info = new System.Windows.Forms.RichTextBox();
            grb_persMed.SuspendLayout();
            grb_pacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_persMed
            // 
            grb_persMed.Controls.Add(lsb_medicos);
            grb_persMed.Location = new System.Drawing.Point(2, 30);
            grb_persMed.Name = "grb_persMed";
            grb_persMed.Size = new System.Drawing.Size(473, 197);
            grb_persMed.TabIndex = 0;
            grb_persMed.TabStop = false;
            grb_persMed.Text = "Personal Medico";
            // 
            // lsb_medicos
            // 
            lsb_medicos.FormattingEnabled = true;
            lsb_medicos.ItemHeight = 19;
            lsb_medicos.Location = new System.Drawing.Point(6, 25);
            lsb_medicos.Name = "lsb_medicos";
            lsb_medicos.Size = new System.Drawing.Size(436, 156);
            lsb_medicos.TabIndex = 0;
            // 
            // grb_pacientes
            // 
            grb_pacientes.Controls.Add(lsb_pacientes);
            grb_pacientes.Location = new System.Drawing.Point(497, 33);
            grb_pacientes.Name = "grb_pacientes";
            grb_pacientes.Size = new System.Drawing.Size(498, 201);
            grb_pacientes.TabIndex = 1;
            grb_pacientes.TabStop = false;
            grb_pacientes.Text = "Pacientes";
            // 
            // lsb_pacientes
            // 
            lsb_pacientes.FormattingEnabled = true;
            lsb_pacientes.ItemHeight = 19;
            lsb_pacientes.Location = new System.Drawing.Point(21, 28);
            lsb_pacientes.Name = "lsb_pacientes";
            lsb_pacientes.Size = new System.Drawing.Size(460, 156);
            lsb_pacientes.TabIndex = 0;
            // 
            // btn_atender
            // 
            btn_atender.Location = new System.Drawing.Point(1062, 79);
            btn_atender.Name = "btn_atender";
            btn_atender.Size = new System.Drawing.Size(160, 83);
            btn_atender.TabIndex = 2;
            btn_atender.Text = "Atender";
            btn_atender.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            btn_salir.Location = new System.Drawing.Point(1175, 402);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new System.Drawing.Size(91, 82);
            btn_salir.TabIndex = 3;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // rtxb_info
            // 
            rtxb_info.Location = new System.Drawing.Point(15, 244);
            rtxb_info.Name = "rtxb_info";
            rtxb_info.Size = new System.Drawing.Size(990, 286);
            rtxb_info.TabIndex = 4;
            rtxb_info.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 542);
            this.Controls.Add(rtxb_info);
            this.Controls.Add(btn_salir);
            this.Controls.Add(btn_atender);
            this.Controls.Add(grb_pacientes);
            this.Controls.Add(grb_persMed);
            this.Name = "Form1";
            this.Text = "Form1";
            grb_persMed.ResumeLayout(false);
            grb_pacientes.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_persMed;
        private ListBox lsb_medicos;
        private GroupBox grb_pacientes;
        private ListBox lsb_pacientes;
        private Button btn_atender;
        private Button btn_salir;
        private RichTextBox rtxb_info;
    }
}