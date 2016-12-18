using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Logica;

namespace DesafioTenisWEB.UserControls
{
    public partial class UploadImagen : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardarFotos_Click(object sender, EventArgs e)
        {
            if (ImageUpload.HasFile || ImageUpload.HasFiles)
            {
                List<HttpPostedFile> fotos = ImageUpload.PostedFiles.ToList();
                foreach (HttpPostedFile foto in fotos)
                    GuardarFoto(foto);
            }


        }
        private void GuardarFoto(HttpPostedFile foto)
        {
            if (foto != null && foto.ContentLength > 0)
            {
                var ext = Path.GetExtension(foto.FileName);

                var path = "~\\Content\\Images";
                var full = Path.Combine(path, "foto.jpg"); //cambiar nombre                
                var tmp = Path.GetTempFileName() + "." + ext;


                try
                {



                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    if (File.Exists(full))
                    {
                        File.Move(full, full.Replace(".jpg", DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".jpg"));
                    }

                    foto.SaveAs(tmp);
                    foto.SaveAs(full);

                    Stream stream = foto.InputStream;
                    System.Drawing.Image image = System.Drawing.Image.FromStream(stream);

                    var k = image.Height / image.Width;
                    var height = image.Height > 500 ? 500 : image.Height;
                    var width = image.Height > 500 ? 500 / k : image.Width; ;

                    var job = new ImageResizer.ImageJob(tmp, full, new ImageResizer.Instructions("width=" + width + ";height=" + height + ";format=jpg"));
                    job.Build();




                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Imagen imagen = new Imagen();
                    imagen.JugadorId = LogicaJugador.FindAll().FirstOrDefault().JugadorId;
                    imagen.RutaImagen = full;
                    LogicaImagen.Add(imagen);

                    File.Delete(tmp);
                }

            }

        }

    }
}