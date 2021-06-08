using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class InterfazPacientes : System.Web.UI.Page
    {
        static List<Cpacientes> pacientes = new List<Cpacientes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string archivo = Server.MapPath("JPaciente.json");

                if (File.Exists(archivo))
                {
                    StreamReader jsonStream = File.OpenText(archivo);
                    string json = jsonStream.ReadToEnd();
                    jsonStream.Close();
                    if (json.Length > 0)
                    {
                        pacientes = JsonConvert.DeserializeObject<List<Cpacientes>>(json);
                    }
                }
            }

        }
        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(pacientes);
            string archivo = Server.MapPath("JPaciente.json");
            System.IO.File.WriteAllText(archivo, json);

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Cpacientes pac = new Cpacientes();

            pac.Nit = TextBox1.Text;
            pac.Nombre = TextBox2.Text;
            pac.Apellido = TextBox3.Text;
            pac.Direccion = TextBox4.Text;
            pac.Telefono = TextBox5.Text;
            pac.Fecha = Calendar1.SelectedDate;
            pacientes.Add(pac);

            Guardar();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InterfazCitas", true);
        }
    }
}
