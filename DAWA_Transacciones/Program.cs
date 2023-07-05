using DAWA_Transacciones.Models;

class Program
{
    static void Main(string[] args)
    {
        addTemaSolistaTransaction();
    }

    public static void addTemaSolistaTransaction()
    {
        Console.WriteLine("Metodo agregar tema musical de solista");

        MusicaDbContext context = new MusicaDbContext();
        Autor autor = new Autor();
        Album album = new Album();
        Cancion cancion = new Cancion();
        var transaction = context.Database.BeginTransaction();

        try
        {
            //Agregar Autor
            autor.Nombre = "Daddy Yankee";
            autor.Nacionalidad = "Puertoriqueño";
            autor.Genero = 'M';
            autor.Estado = true;
            context.Autor.Add(autor);
            context.SaveChanges();

            //Agregar Album
            album.Nombre = "Barrio Fino";
            album.Periodo = 2004;
            album.Sello = "Cartel Record";
            album.Estado = true;
            context.Album.Add(album);
            context.SaveChanges();

            //Agregar Cancion
            cancion.Nombre = "Gasolina";
            cancion.AutorId = autor.AutorId;
            cancion.AlbumId = album.AlbumId;
            cancion.Estado = true;
            context.Cancion.Add(cancion);
            context.SaveChanges();

            transaction.Commit();
            Console.WriteLine("Datos agregados exitosamente");
        }
        catch (Exception e)
        {
            transaction.Rollback();
            Console.WriteLine("Error " + e.ToString());
        }
    }
}
