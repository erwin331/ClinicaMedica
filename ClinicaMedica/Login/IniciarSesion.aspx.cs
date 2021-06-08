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

namespace ClinicaMedica.Login
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        static List<Cinicio> usuarios = new List<Cinicio>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("../Registro.json");
            if (File.Exists(archivo))
            {
                StreamReader jsonStream = File.OpenText(archivo);

                string json = jsonStream.ReadToEnd();

                jsonStream.Close();

                usuarios = JsonConvert.DeserializeObject<List<Cinicio>>(json);
            }
        }


        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            Cinicio usuario = new Cinicio();

            usuario = usuarios.Find(u => u.Nombre == Login1.UserName);


            bool esPasswordValido = BC.Verify(Login1.Password, usuario.Password);

            if (esPasswordValido)
            {
                int nivel = usuario.Nivel;

                FormsAuthenticationTicket tkt;
                string cookiestr;
                HttpCookie ck;

                tkt = new FormsAuthenticationTicket(1, Login1.UserName, DateTime.Now,
                DateTime.Now.AddMinutes(30), Login1.RememberMeSet, nivel.ToString());
                cookiestr = FormsAuthentication.Encrypt(tkt);
                ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);

                if (Login1.RememberMeSet)
                    ck.Expires = tkt.Expiration;
                ck.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(ck);

                string strRedirect;
                strRedirect = Request["ReturnUrl"];
                if (strRedirect == null)
                    if (usuario.Nivel == 1)
                        strRedirect = "../InterfazMedico.aspx";
                if (usuario.Nivel == 2)
                    strRedirect = "../InterfazSecretaria.aspx";
                Response.Redirect(strRedirect, true);
            }
            else
                Response.Redirect("IniciarSesion.aspx", true);
        }
    }
}
