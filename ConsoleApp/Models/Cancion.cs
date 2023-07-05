using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Cancion
    {
        public int CancionId { get; set; }
        public string Nombre { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public bool Estado { get; set; }
    }
}
