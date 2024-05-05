using GuiaClases_y_objetos;

internal class Program
{
    static void Main(String[] args)
        { 

        Console.WriteLine("***** Aplicación de gestión de empleados ***** ");
         
        //crear una lista para almacenar empleados
        List<Empleado> listaEmpleados = new List<Empleado>();

        //Agregar empleados de ejemplo a la lista
        listaEmpleados.Add(new Empleado("Juan", 101, 30000, true));
        listaEmpleados.Add(new Empleado("María", 102, 35000, true));
        listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false)); //empleado inactivo

        //Mostrar los detalles de cada empleado en la lista 
        foreach (var empleado in listaEmpleados)
        {
            empleado.MostrarDetalles();
        }
        //
        //cambiar el estado de un empleado por su numero de empleado
        int numeroEmpleadoCambiarEstado = 103;//Número de empleado a cambiar estado.
        Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

        if (empleadoCambiarEstado != null)
        {
            //cambiar el estado a actualizar (1) o inactivo (0)
            empleadoCambiarEstado.CambiarEstado(1);//cambiar activo
            empleadoCambiarEstado.MostrarDetalles();//mostrar detalles actualizados
        }
        else
        {
            Console.WriteLine($"Empleado con numero {numeroEmpleadoCambiarEstado} no encontrado.");
        }

        //metodo para buscar un empleado por su numero de empleado
        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado )
        {
            foreach (var empleado in empleados)
            {
                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {
                    return empleado;
                }
            }
            return null; 
        }
    }
       
}