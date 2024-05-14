using HospitalLib;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace HospitalUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("BTN_ATENDER_CLICK " + lstMedicos.SelectedIndex);
            Debug.WriteLine("BTN_ATENDER_CLICK " + lstPacientes.SelectedIndex);
            Paciente selectedPaciente = null;

            if (lstMedicos.SelectedIndex == -1 || lstPacientes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectedPaciente = (Paciente)lstPacientes.SelectedItem;

                RefreshPaciente(selectedPaciente);
                RefreshListBoxs();
                ShowSuccesBoxs(selectedPaciente.NombreCompleto);
            }

        }

        private void RefreshPaciente(Paciente paciente)
        {
            paciente.Diagnostico = "paciente curado";
        }
        private void RefreshListBoxs()
        {
            lstMedicos.SelectedIndex = -1;
            lstPacientes.SelectedIndex = -1;
        }
        private void ShowSuccesBoxs(string nombreComleto)
        {
            string titulo = "Atención finalizada";
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now);
            sb.Append(" se ha atendido a");
            sb.Append(nombreComleto);
            MessageBox.Show(sb.ToString(), titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK){                
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));

        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbInfoMedicos.Text = ((Persona)lstMedicos.SelectedItem).FichaPersonal(null);
        }
    }
}