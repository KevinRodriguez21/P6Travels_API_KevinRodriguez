namespace P6Travels_API_KevinRodriguez.ModelsDTOs
{
    // Un DTO (Data Tranfer object) es un tipo de version "recortada" de un modelo particular donde se pretende
    //quitar todas las complejidades generadas en los modelos a partir del ORM (Entity framework en nuestro caso).

    //El proposito tambien puede ser ocultar la estructura original de los modelos al equipo de desarrollo front End
    //ya sea poruqe no es necesaria visualizar el modelo completo o porque no se debe mostrar la estructura original de las tablas a nivel de base de datos.

    // en este ejemplo vamos a transformar el modelo a idioma espanol,
    //ya que el original esta en ingles e hipoteticamente el equipo de 
    //desarrollo solo habla espanol.
    
    public class UsuarioDTO
    {

        public int UsuarioID { get; set; }

        public string Correo { get; set;} = null!;

        public string Nombre { get; set; } = null!;

        public string? Telefono { get; set; }

        public string Contrasennia { get; set; } = null!;

        public int RolID { get; set; }

        //hasta aca todas han sido propiedades que estan en el modelo original,
        //pero ademas se pueden agregar otras pensando en cuando hacemos consultas tipo inner join
        //que combinen datos de varias tablas. siempre es mejor tener versiones lo mas "planas" de los modelos.

        public string? RolDescripcion { get; set; }
    }
}
