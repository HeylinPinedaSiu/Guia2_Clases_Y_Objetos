using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClases_y_objetos
{
    internal class Empleado
    {

        //Variable miembro de la clase Empleado
        private String Nombre_Empleado;
        private int Numero_Empleado;
        private decimal Salario_Empleado;
        private bool Activo; //Estado del empleado(activo o inactivo)


        //creamos el constructor con los parametros0
        public Empleado(string nombre, int numero, decimal salario, bool activo = true)
        {
           this.Nombre_Empleado = nombre;
           this.Numero_Empleado = numero;
            this.Salario_Empleado = salario;
            this.Activo = activo;
        }

        public Empleado()
        {


        }
        //Metodo para mostrar los detalles del empleado
        public void MostrarDetalles()
        {
            string estado = (Activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {Nombre_Empleado}, Número de Empleado: {Numero_Empleado}, Salario: {Salario_Empleado:C}, Estado: {estado}");
        }

        //metodo para obtener el numero de empleado
        public int ObtenerNumeroEmpleado()
        {
            return this.Numero_Empleado;
        }

        //metodo para cambiar el estado del empleado
        public void CambiarEstado(int nuevoEstado)
        {
            Console.WriteLine("Cambio de estado el numero de empleado" + Numero_Empleado);
            if (nuevoEstado == 1)
            {
                Activo = true; //Activar empleado
                Console.WriteLine("Empleado Activado");
            }
            else if (nuevoEstado == 0)
            {
                Activo = false;//Desactivsr Empleado
                Console.WriteLine("Empleado Desactivado");

            }
            else
            {
                Console.WriteLine("Estado no valido");
            }
        }

        //creamos un nuevo metodo para aumentar el porcentaje del salario del empleado
        //en una cantidad del 15%  
        public void AumentoSalario_Empleado()
        {
            //
            Console.WriteLine("");
            Console.WriteLine("**** Ingrese el número del empleado: ***");
            int numero_empleado_s = Convert.ToInt32(Console.ReadLine());


            double aumento_salario = 0.0;
           

            if (numero_empleado_s == 101)
            {
              
                aumento_salario = 30000 +(0.015 * 30000);// 15 /100= 0.015    
                Console.WriteLine("El salario actualizado  es: $" + aumento_salario);
                Console.WriteLine("");

            }

            else if (numero_empleado_s == 102)
            {
             aumento_salario = 35000 + (0.015 * 35000);// 15 /100= 0.015
                Console.WriteLine("El salario actualizado  es: $" + aumento_salario);
                Console.WriteLine("");

            }

            else if (numero_empleado_s == 103)
            {
                aumento_salario = 32000 + (0.015 * 32000);// 15 /100= 0.015
                Console.WriteLine("El salario actualizado  es: $" + aumento_salario);
                Console.WriteLine("");

              

            }
            else
            {
                Console.WriteLine("¡Error, el número de empleado es incorrecto! ");
                Console.WriteLine("**** Fin del Programa ***** ");
                Console.WriteLine("");
            }

        }

    }
}
    
