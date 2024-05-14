using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public class Paciente : Persona
    {
        private string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) : 
            base(nombre, apellido, nacimiento, barrioRecidencia) { 
        }
        internal override string FichaExtra() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Recide en: {BarrioRecidencia}");
            sb.AppendLine(this.diagnostico);
            return sb.ToString();
        }

        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
    }
}
