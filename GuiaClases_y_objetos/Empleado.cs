using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClases_y_objetos
{
    internal class Empleado
    {

        //Variable miembro de la clase Empleado
        private String nombre_Empleado;
        private int numero_Empleado;
        private decimal salario_Empleado;
        private bool activoEmpleado; //Estado del empleado(activo o inactivo)


        //creamos el constructor con los parametros
        public Empleado(string nombre, int numero, decimal salario, bool activo )
        {
            this.nombre_Empleado = nombre;
            this.numero_Empleado = numero;
            this.salario_Empleado = salario;
            this.activoEmpleado = activo;
        }

        //Metodo para mostrar los detalles del empleado
        public void MostrarDetalles()
        {
            string estado = (activoEmpleado) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre_Empleado}, Número de Empleado: {numero_Empleado}, Salario: {salario_Empleado:C}, Estado: {estado}");
        }

        //metodo para obtener el numero de empleado
        public int ObtenerNumeroEmpleado()
        {
            return this.numero_Empleado;
        }

        //metodo para cambiar el estado del empleado
        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activoEmpleado = true; //Activar empleado
                Console.WriteLine("Empleado Activado");
            }
            else if (nuevoEstado == 0)
            {
                activoEmpleado = false;//Desactivsr Empleado
                Console.WriteLine("Empleado Desactivado");

            }
            else
            {
                Console.WriteLine("Estado no valido");
            }
            
        
        }
    }
}

