using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora {
    class ControladorEmpleados {
        List<Empleado> listaEmpleados;

        public ControladorEmpleados() {
            this.listaEmpleados = new List<Empleado>();
        }

        public Empleado buscarEmpleado(string DNI) {
            Empleado aux = new Obrero(DNI); // Creo un auxiliar al que le otorgo el DNI del empleado que busco, puede ser un obrero o un capataz. Uso la clase obrero para instanciar un objeto auxiliar
            int indice = listaEmpleados.IndexOf(aux); // Me devuelve la posición en la que se encuentra el empleado que busco, porque lo busca con un string DNI auxiliar
            if (indice >= 0) {
                return listaEmpleados[indice];
            }
            return null;
        }

        public bool agregarObrero(string DNI, string apellido, string nombre, string especialidad) {
            Empleado aux = buscarEmpleado(DNI);
            if (aux == null) { // Si no se encuentra el obrero, entonces lo ingresamos
                Obrero obrero = new Obrero(DNI, apellido, nombre, especialidad);
                this.listaEmpleados.Add(obrero);
                return true;
            }
            return false;
        }

        public bool agregarCapataz(string DNI, string apellido, string nombre, uint matricula) {
            Empleado aux = buscarEmpleado(DNI); // Si no se encuentra el capataz, entonces lo ingresamos
            if (aux == null) {
                Capataz capataz = new Capataz(DNI, apellido, nombre, matricula);
                this.listaEmpleados.Add(capataz);
                return true;
            }
            return false;
        }

        public bool eliminarEmpleado(string DNI) {
            Empleado aux = buscarEmpleado(DNI);
            if (aux != null) { // Si encuentra al empleado, lo eliminamos
                this.listaEmpleados.Remove(aux);
                return true;
            }
            return false;
        }

        public bool editarObrero(string DNI, string apellido, string nombre, string especialidad) {
            Obrero aux = (Obrero)buscarEmpleado(DNI);
            if (aux != null) { // Si encuentra al obrero, lo editamos
                aux.setDNI(DNI);
                aux.setApellido(apellido);
                aux.setNombre(nombre);
                aux.setEspecialidad(especialidad);
                return true;
            }
            return false;
        }

        public bool editarCapataz(string DNI, string apellido, string nombre, uint matricula) {
            Capataz aux = (Capataz)buscarEmpleado(DNI);
            if (aux != null) { // Si encuentra al capataz, lo editamos
                aux.setDNI(DNI);
                aux.setApellido(apellido);
                aux.setNombre(nombre);
                aux.setMatricula(matricula);
                return true;
            }
            return false;
        }

        public string listarEmpleados() { // Devuelve un string entero que se compone de la lista completa de empleados
            string lista = "";
            foreach(Empleado empleado in listaEmpleados) {
                if (empleado is Obrero) {
                    Obrero obrero = (Obrero)empleado;
                    lista += obrero.darDatos();
                }
                else {
                    Capataz capataz = (Capataz)empleado;
                    lista += capataz.darDatos();
                }
            }
            return lista;
        }
    }
}
