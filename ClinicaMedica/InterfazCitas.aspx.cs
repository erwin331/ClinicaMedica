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
    public partial class InterfazCitas : System.Web.UI.Page
    {
        static List<Cpacientes> pacientes = new List<Cpacientes>();
        static List<Ccitas> cita = new List<Ccitas>();
        string HI, MI, HHI, HF, MF, HHF;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string archivo = Server.MapPath("JPaciente.json");
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();

                if (json.Length > 0)
                {
                    pacientes = JsonConvert.DeserializeObject<List<Cpacientes>>(json);
                    GridView1.DataSource = pacientes;
                    GridView1.DataBind();
                }
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[6].Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccionada = GridView1.SelectedIndex;
            Label1.Text = pacientes[seleccionada].Nit;
        }

        public void hora_I()
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                HI = ListBox1.SelectedValue;
                MI = ListBox2.SelectedValue;
                HHI = HI + " : " + MI + " PM";
            }

            if (RadioButtonList1.SelectedIndex == 1)
            {
                HI = ListBox1.SelectedValue;
                MI = ListBox2.SelectedValue;
                HHI = HI + " : " + MI + " AM";
            }
        }
        public void hora_F()
        {

            if (RadioButtonList2.SelectedIndex == 0)
            {
                HF = ListBox3.SelectedValue;
                MF = ListBox4.SelectedValue;
                HHF = HF + " : " + MF + " PM";
            }
            if (RadioButtonList2.SelectedIndex == 0)
            {
                HF = ListBox3.SelectedValue;
                MF = ListBox4.SelectedValue;
                HHF = HF + " : " + MF + " PM";
            }
        }

        public void guardar()
        {
            string json = JsonConvert.SerializeObject(cita);
            string archivo = Server.MapPath("JCita.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            hora_I();
            hora_F();
            Ccitas citas = new Ccitas();
            citas.Nit = Label1.Text;
            citas.Fecha = Calendar1.SelectedDate;
            citas.Horainicio = HHI;
            citas.Horafinal = HHF;
            cita.Add(citas);
            guardar();
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
