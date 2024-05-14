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
            lstMedicos = new ListBox();
            grb_pacientes = new GroupBox();
            lstPacientes = new ListBox();
            btnAtender = new Button();
            btnSalir = new Button();
            rtbInfoMedicos = new RichTextBox();
            grb_persMed.SuspendLayout();
            grb_pacientes.SuspendLayout();
            SuspendLayout();
            // 
            // grb_persMed
            // 
            grb_persMed.Controls.Add(lstMedicos);
            grb_persMed.Location = new Point(2, 30);
            grb_persMed.Name = "grb_persMed";
            grb_persMed.Size = new Size(473, 197);
            grb_persMed.TabIndex = 0;
            grb_persMed.TabStop = false;
            grb_persMed.Text = "Personal Medico";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 19;
            lstMedicos.Location = new Point(6, 25);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(436, 156);
            lstMedicos.TabIndex = 0;
            // 
            // grb_pacientes
            // 
            grb_pacientes.Controls.Add(lstPacientes);
            grb_pacientes.Location = new Point(497, 33);
            grb_pacientes.Name = "grb_pacientes";
            grb_pacientes.Size = new Size(498, 201);
            grb_pacientes.TabIndex = 1;
            grb_pacientes.TabStop = false;
            grb_pacientes.Text = "Pacientes";
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 19;
            lstPacientes.Location = new Point(21, 28);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(460, 156);
            lstPacientes.TabIndex = 0;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(1062, 79);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(160, 83);
            btnAtender.TabIndex = 2;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1175, 402);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 82);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rtbInfoMedicos
            // 
            rtbInfoMedicos.Location = new Point(15, 244);
            rtbInfoMedicos.Name = "rtbInfoMedicos";
            rtbInfoMedicos.Size = new Size(990, 286);
            rtbInfoMedicos.TabIndex = 4;
            rtbInfoMedicos.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 542);
            Controls.Add(rtbInfoMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(grb_pacientes);
            Controls.Add(grb_persMed);
            Name = "Form1";
            Text = "Mariano DAngelo";
            grb_persMed.ResumeLayout(false);
            grb_pacientes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_persMed;
        private ListBox lstMedicos;
        private GroupBox grb_pacientes;
        private ListBox lstPacientes;
        private Button btnAtender;
        private Button btnSalir;
        private RichTextBox rtbInfoMedicos;
    }
}