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
            }
            

        }
        private void GuardarFoto(HttpPostedFileBase foto)
        {
            if (foto != null && foto.ContentLength > 0)
            {
                var ext = Path.GetExtension(foto.FileName);

                var path = Server.MapPath("~/Content/Images");
                var full = Path.Combine(path, "foto.jpg");

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

                    var job = new ImageResizer.ImageJob(tmp, full, new ImageResizer.Instructions("width=460;height=102;format=jpg"));
                    job.Build();

                    
                }
                catch (Exception ex)
                {
                    
                }
                finally
                {
                    Imagen imagen = new Imagen();
                    imagen.JugadorId = ((Jugador)Session["Logueado"]).JugadorId;
                    imagen.RutaImagen = tmp;
                    LogicaImagen.Add(imagen);

                    File.Delete(tmp);
                }

            }

        }
}