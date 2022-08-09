using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora {
    static class Interfaz {
        static string[] especialidades = { "Albañil", "Pintor", "Plomero", "Herrero", "Electricista" }; // Voy a usar este array en returnEspecialidad

        public static int mostrarMenu() {
            Console.Clear();
            Console.WriteLine("*        Constructora        *");
            Console.WriteLine("1) Listar obreros y capataces registrados.");
            Console.WriteLine("2) Agregar obrero.");
            Console.WriteLine("3) Agregar capataz.");
            Console.WriteLine("4) Remover obrero o capataz.");
            Console.WriteLine("5) Editar obrero.");
            Console.WriteLine("6) Editar capataz.");
            Console.WriteLine("7) Salir.\n");
            return Interfaz.pedirDatoMenu();
        }

        public static int pedirDatoMenu() {
            int dato;
            do {
                Console.Write("Ingrese una opción: ");
                dato = int.Parse(Console.ReadLine());
            } while (dato < 1 || dato > 7);
            return dato;
        }

        public static void mostrarMensaje(string mensaje) {
            Console.WriteLine(mensaje);
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }

        public static int returnInt(string mensaje) {
            Console.Write(mensaje);
            return int.Parse(Console.ReadLine());
        }

        public static uint returnUint(string mensaje) {
            Console.Write(mensaje);
            return uint.Parse(Console.ReadLine());
        }

        public static string returnString(string mensaje) {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

        public static string returnEspecialidad(string mensaje) {
            int indice;
            Console.WriteLine(mensaje);
            for(int i=0; i<especialidades.Length; i++) {
                Console.WriteLine((i + 1) + " - " + especialidades[i]);
            }
            indice = int.Parse(Console.ReadLine());
            return especialidades[indice - 1];
        }

        public static void limpiar() {
            Console.Clear();
        }
    }
}
