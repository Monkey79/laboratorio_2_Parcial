using HospitalLib;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace HospitalUI
{
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
        }

        private void btnAtender_Click(object sender, EventArgs e) {            
            Paciente selectedPaciente = null;
            PersonalMedico selectedMedico = null;

            if (lstMedicos.SelectedIndex == -1 || lstPacientes.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                selectedPaciente = (Paciente)lstPacientes.SelectedItem;
                selectedMedico = (PersonalMedico) lstMedicos.SelectedItem;

                Consulta consulta = CreateAndLoadConsulta(selectedMedico, selectedPaciente);
                if(consulta != null) {
                    ShowSuccesBoxs(selectedPaciente.NombreCompleto);
                }
                RefreshListBoxs();
            }

        }

        private Consulta CreateAndLoadConsulta(PersonalMedico personalMedico ,Paciente paciente) {
            paciente.Diagnostico = "paciente curado"; //El diagnóstico será "Paciente curado" para todoslos casos.
            Consulta consulta = (personalMedico + paciente);
            return consulta;
        }
        private void RefreshListBoxs() {
            lstMedicos.SelectedIndex = -1;
            lstPacientes.SelectedIndex = -1;
        }        
        private void ShowSuccesBoxs(string nombreComleto) {
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

        private void Form1_Load(object sender, EventArgs e) {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e){

        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e){
            //Llamo metodo estatico FichaPersonal y le paso el objeto seleccionado
            //del list-box de medicos. El metodo FichaPersonal llamara a FichaExtra
            //(que es internal) segun corresponda
            Persona persona = (PersonalMedico)lstMedicos.SelectedItem;
            if (lstMedicos.SelectedIndex>=0) {
                Debug.WriteLine("lstMedicos_SelectedIndexChanged ");
                rtbInfoMedicos.Text = Persona.FichaPersonal(persona);
            }
            
        }
    }
}