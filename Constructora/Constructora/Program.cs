using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora {
    class Program {
        static void Main(string[] args) {
            ControladorEmpleados listaEmpleados = new ControladorEmpleados();
            string DNI, apellido, nombre, especialidad;
            uint matricula;
            int opcion;
            bool resultadoOperacion = false;

            opcion = Interfaz.mostrarMenu();
            while (opcion != 7) {
                switch (opcion) {
                    case 1:
                        Interfaz.mostrarMensaje(listaEmpleados.listarEmpleados());
                        break;
                    case 2:
                        DNI = Interfaz.returnString("Ingrese el DNI: ");
                        apellido = Interfaz.returnString("Ingrese el apellido: ");
                        nombre = Interfaz.returnString("Ingrese el nombre: ");
                        especialidad = Interfaz.returnEspecialidad("Ingrese la especialidad del obrero: ");
                        resultadoOperacion = listaEmpleados.agregarObrero(DNI, apellido, nombre, especialidad);
                        if (resultadoOperacion != false) {
                            Interfaz.mostrarMensaje("Operación exitosa");
                        }
                        else {
                            Interfaz.mostrarMensaje("Error");
                        }
                        break;
                    case 3:
                        DNI = Interfaz.returnString("Ingrese el DNI: ");
                        apellido = Interfaz.returnString("Ingrese el apellido: ");
                        nombre = Interfaz.returnString("Ingrese el nombre: ");
                        matricula = Interfaz.returnUint("Ingrese el N° de matrícula del capataz: ");
                        resultadoOperacion = listaEmpleados.agregarCapataz(DNI, apellido, nombre, matricula);
                        if (resultadoOperacion != false) {
                            Interfaz.mostrarMensaje("Operación exitosa");
                        }
                        else {
                            Interfaz.mostrarMensaje("Error");
                        }
                        break;
                    case 4:
                        DNI = Interfaz.returnString("Ingrese el DNI: ");
                        resultadoOperacion = listaEmpleados.eliminarEmpleado(DNI);
                        if (resultadoOperacion != false) {
                            Interfaz.mostrarMensaje("Operación exitosa");
                        }
                        else {
                            Interfaz.mostrarMensaje("Error");
                        }
                        break;
                    case 5:
                        DNI = Interfaz.returnString("Ingrese el DNI: ");
                        Empleado aux = listaEmpleados.buscarEmpleado(DNI);

                        apellido = Interfaz.returnString("Ingrese el apellido: ");
                        nombre = Interfaz.returnString("Ingrese el nombre: ");
                        especialidad = Interfaz.returnString("Ingrese la especialidad: ");
                        resultadoOperacion = listaEmpleados.editarObrero(DNI, apellido, nombre, especialidad);
                        if (resultadoOperacion != false) {
                            Interfaz.mostrarMensaje("Operación exitosa");
                        }
                        else {
                            Interfaz.mostrarMensaje("Error");
                        }
                        break;
                    case 6:
                        DNI = Interfaz.returnString("Ingrese el DNI: ");
                        apellido = Interfaz.returnString("Ingrese el apellido: ");
                        nombre = Interfaz.returnString("Ingrese el nombre: ");
                        matricula = Interfaz.returnUint("Ingrese la matrícula: ");
                        resultadoOperacion = listaEmpleados.editarCapataz(DNI, apellido, nombre, matricula);
                        if (resultadoOperacion != false) {
                            Interfaz.mostrarMensaje("Operación exitosa");
                        }
                        else {
                            Interfaz.mostrarMensaje("Error");
                        }
                        break;
                    default:
                        Interfaz.mostrarMensaje("Ingrese una opción correcta\n");
                        break;
                }
                opcion = Interfaz.mostrarMenu();
            }
            Interfaz.mostrarMensaje("Hasta luego");
        }
    }
}
