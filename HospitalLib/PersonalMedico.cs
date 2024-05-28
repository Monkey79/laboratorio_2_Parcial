using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) :
            base(nombre, apellido, nacimiento){ 

            this.esResidente = esResidente;
            this.consultas = new List<Consulta>();
        }

        internal override string FichaExtra() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"¿Finalizó residencia? {esResidente}");
            stringBuilder.AppendLine("ATENCIONES:");
            Debug.WriteLine("---EL MEDICO TIENE CONSULTAS?----"+this.NombreCompleto+"=="+consultas.Count);
            if (consultas.Count > 0) {
                foreach (Consulta item in consultas){
                    stringBuilder.AppendLine(item.ToString());
                }
            }          
            return stringBuilder.ToString();
        }

        public static Consulta operator +(PersonalMedico prsMed, Paciente paciente) {
            Consulta consulta = new Consulta(DateTime.Now, paciente);
            bool alreadyLoaded = prsMed.consultas.Contains(consulta);
            if (!alreadyLoaded){
                Debug.WriteLine("---AGREGO CONSULTA AL MEDICO----");
                prsMed.consultas.Add(consulta);
            }else {
                Debug.WriteLine("---LA CONSULTA YA EXISTE----");
                consulta = null;
            }
            return consulta;
        }
    }
}
