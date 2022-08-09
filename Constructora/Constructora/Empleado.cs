using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora {
    abstract class Empleado: IEquatable<Empleado> {
        string DNI;
        string apellido;
        string nombre;

        public Empleado(string DNI, string apellido, string nombre) {
            this.DNI = DNI;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public Empleado(string DNI) {
            this.DNI = DNI;
            this.apellido = "";
            this.nombre = "";
        }

        public string getDNI() {
            return this.DNI;
        }

        public string getApellido() {
            return this.apellido;
        }

        public string getNombre() {
            return this.nombre;
        }

        public void setDNI(string DNI) {
            this.DNI = DNI;
        }

        public void setApellido(string apellido) {
            this.apellido = apellido;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public virtual string darDatos() {
            return "DNI: " + this.DNI + "\nApellido: " + this.apellido + "\nNombre: " + this.nombre + "\n\n";
        }

        public bool Equals(Empleado other) {
            if (other is Empleado) {
                return this.DNI == other.DNI;
            }
            return false;
        }
    }
}
