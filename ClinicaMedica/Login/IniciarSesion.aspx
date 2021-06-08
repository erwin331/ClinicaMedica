<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="ClinicaMedica.Login.IniciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<p>
    </p>
    <p>
        </p>
    <h1 class="btn-success focus">
     Incia Sesion</h1>
    <p>
        </p>
    <p>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate1" style="margin-left: 254px" TitleText="Bienvenido" Width="637px">
        </asp:Login>
</p>
    <p>
        </p>
    <p>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="70px" style="margin-left: 456px" Width="132px">
        <asp:ListItem>Medico</asp:ListItem>
        <asp:ListItem>Secretaria</asp:ListItem>
    </asp:RadioButtonList>
</p>
<p>
</p>
</asp:Content>

