using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dominio
{
    public class Imagen
    {
        public int ImagenId { get; set; }
        public string RutaImagen { get; set; }
        public int JugadorId { get; set; }

        public Imagen()
        {

        }

        //Image image = Image.FromFile(fileName);
        //Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
        //thumb.Save(Path.ChangeExtension(fileName, "thumb"));

    }
}
