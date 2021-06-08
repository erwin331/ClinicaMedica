using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BC = BCrypt.Net.BCrypt;

namespace ClinicaMedica
{
    public partial class InterfazRegistrar : System.Web.UI.Page
    {
        static List<Cinicio> registrar = new List<Cinicio>();
        protected void Page_Load(object sender, EventArgs e)
        {
            var identidad = (FormsIdentity)Context.User.Identity;

            if (identidad.Ticket.UserData == "1")
            {
                string archivo = Server.MapPath("JIniciar.json");
                if (File.Exists(archivo))
                {
                    StreamReader jsonStream = File.OpenText(archivo);
                    string json = jsonStream.ReadToEnd();
                    jsonStream.Close();

                    registrar = JsonConvert.DeserializeObject<List<Cinicio>>(json);
                }
            }
            else
                Response.Redirect("IniciarSesion/CerrarSesion", true);

        }
        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(registrar);
            string archivo = Server.MapPath("JIniciar.json");
            System.IO.File.WriteAllText(archivo, json);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cinicio tempores = new Cinicio();

            tempores.Nombre = TextBox1.Text;
            string miPassword = TextBox1.Text;
            string miSal = BC.GenerateSalt();
            string miHash = BC.HashPassword(miPassword, miSal);
            tempores.Password = miHash;
            tempores.Nivel = Convert.ToInt32(RadioButtonList1.SelectedValue);

            registrar.Add(tempores);

            Guardar();
        }
    }
}
