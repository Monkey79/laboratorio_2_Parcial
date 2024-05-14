using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;


        public Consulta(DateTime fecha, Paciente paciente) { 
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public DateTime Fecha{get { return fecha; } }
        public Paciente Paciente { get {  return paciente; } }

        public override string ToString() {
            StringBuilder sb =  new StringBuilder();
            sb.Append(Fecha);
            sb.Append("se ha atendido a ");
            sb.Append(paciente.FichaExtra());
            return sb.ToString();
        }
    }
}
