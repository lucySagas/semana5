namespace WebApplication5.Controllers
{
    public class Alumno
    {
        //Creando Propiedades
        string Nombre;
        string Apellido;
        string dni;
        DateTime fechanacimiento;

        //Constructor sin parametros
        public Alumno()
            {
            Nombre = string.Empty;
            Apellido = string.Empty;
            dni = string.Empty;
            fechanacimiento = DateTime.Now;
        }

        //Construnctor con parametros
        public Alumno(string pNombre, string pApellido, string pdni)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            dni = pdni;
        }

        public Alumno(string pNombre, string pApellido, string pdni,DateTime pfechanacimiento)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            dni = pdni;
            fechanacimiento = pfechanacimiento;
        }

        public string DevolverDocumento()
        {
            return dni;
        }

        public int DevolverEdad()
        {
            return DateTime.Now.Year - fechanacimiento.Year;
        }
    }
}
