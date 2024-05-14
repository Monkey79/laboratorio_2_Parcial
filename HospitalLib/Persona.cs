using System.Text;

namespace HospitalLib
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string barrioRecidencia;
        private DateTime nacimiento;


        public Persona(string nombre, string apellido, DateTime nacimiento) { 
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia)
            :this (nombre, apellido, nacimiento) { 

            this.barrioRecidencia = barrioResidencia;
        }

        public int Edad {
            get{
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }
        public string NombreCompleto {            
            get {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(this.apellido);
                stringBuilder.Append(this.nombre);

                return stringBuilder.ToString();
            }
        }

        public string BarrioRecidencia { get => barrioRecidencia; }

        internal abstract string FichaExtra();

        public string FichaPersonal(Persona persona) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(NombreCompleto);
            sb.AppendLine($"Edad:{Edad}");

            //TODO : {Datos del objeto instanciado} ? VER!!
            sb.Append(barrioRecidencia);
            return sb.ToString();
        }

        public override string ToString() {
            return NombreCompleto;
        }
    }
}