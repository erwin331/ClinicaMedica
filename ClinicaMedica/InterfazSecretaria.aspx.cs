using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class InterfazSecretaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //registar pacientes
            if (DropDownList1.SelectedIndex == 0)
                Response.Redirect("InterfazPacientes", true);
            if (DropDownList1.SelectedIndex == 1)
                Response.Redirect("InterfazCitas", true);
            else
                Response.Write("<script>alert('Tiene que seleccionar una opcion si o si')</script>");
        }
    }
}