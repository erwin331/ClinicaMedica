<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medicamentos.aspx.cs" Inherits="ClinicaMedica.Medicamentos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

input,
select,
textarea {
    max-width: 280px;
}


input,
button,
select,
textarea {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit;
}
input {
  line-height: normal;
}
button,
input,
optgroup,
select,
textarea {
  color: inherit;
  margin: 0 0 0 75px;
        }
* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
}
  *,
  *:before,
  *:after {
    color: #000 !important;
    text-shadow: none !important;
    background: transparent !important;
    -webkit-box-shadow: none !important;
    box-shadow: none !important;
  }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Codigo:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;Laboratorio:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <br />
            Quimico:
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
