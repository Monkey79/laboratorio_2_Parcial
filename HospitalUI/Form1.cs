using System.Diagnostics;

namespace HospitalUI
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void btnAtender_Click(object sender, EventArgs e) {
            Debug.WriteLine("BTN_ATENDER_CLICK");
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Debug.WriteLine("BTN_SALIR_CLICK");
        }
    }
}