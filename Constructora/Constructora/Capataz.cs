using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora {
    sealed class Capataz: Empleado {
        uint matricula;

        public Capataz(string DNI, string apellido, string nombre, uint matricula): base(DNI, apellido, nombre) {
            this.matricula = matricula;
        }

        public Capataz(string DNI): base(DNI) {
            this.matricula = 0;
        }

        public uint getMatricula() {
            return this.matricula;
        }

        public void setMatricula(uint matricula) {
            this.matricula = matricula;
        }

        public override string darDatos() {
            return "Tipo de empleado: Capataz\n" + "Matrícula: " + this.matricula + "\n" + base.darDatos();
        }
    }
}
