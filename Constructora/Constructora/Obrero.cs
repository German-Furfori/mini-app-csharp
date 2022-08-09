using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora {
    sealed class Obrero: Empleado {
        string especialidad;

        public Obrero(string DNI, string apellido, string nombre, string especialidad): base(DNI, apellido, nombre) {
            this.especialidad = especialidad;
        }

        public Obrero(string DNI): base(DNI) {
            this.especialidad = "";
        }

        public string getEspecialidad() {
            return this.especialidad;
        }

        public void setEspecialidad(string especialidad) {
            this.especialidad = especialidad;
        }

        public override string darDatos() {
            return "Tipo de empleado: Obrero\n" + "Especialidad: " + this.especialidad + "\n" + base.darDatos();
        }
    }
}
