using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
/*Para heredar en C# lo hacemos con :*/
    public class DataContext : DbContext{    
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
            /*Recibe un parametro o objeto de options de tipo dbcontextoptions 
            Los dos puntos signigica que sobrescribimos el constructor del papa, osea de la clase que se implementa
            Osea que estamos cambiando las opciones de la clase en este constructor que hereda de dbdataoptions.
            */
        }
    
    public DbSet<AppUser> Users{ get; set; }
        /*Esta es una clase que permite modificar una entidad dentro de una tabla, esto basicamente convierte toda esta informacion en una tabla dentro de la base de datos, eso lo hace el framwork, NI IIDEA COMO LO HACE, EL SOLO LO HACE C:*/


    }
}

/*Un motor de inyeccion de dependencias, basicamente agreaga un monton de funciones a su debito momento*/