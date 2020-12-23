<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaUsuario.aspx.cs" Inherits="TPC_Leal.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Alta Usuario</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</head>
<body>
    <script>
        function Validar() {

            var nombre = document.getElementById("<%=txtNombre.ClientID %>").value;
            var apellido = document.getElementById("<%=txtApellido.ClientID %>").value;
            var dni = document.getElementById("<%=txtDNI.ClientID %>").value;
            var contraseña = document.getElementById("<%=TxtContraseña.ClientID%>").value;
            var mail = document.getElementById("<%=txtEmail.ClientID%>").value;
            var valido = true;

            if (nombre === "") {

                $("#<%=txtNombre.ClientID %>").removeClass("is-valid");
                $("#<%=txtNombre.ClientID %>").addClass("is-invalid");
                valido=false;
            } else {
                
                $("#<%=txtNombre.ClientID %>").removeClass("is-invalid");
                $("#<%=txtNombre.ClientID %>").addClass("is-valid");
            }
            //apellido
            if (apellido === "") {

                $("#<%=txtApellido.ClientID %>").removeClass("is-valid");
                $("#<%=txtApellido.ClientID %>").addClass("is-invalid");
                valido = false;
              } else {

                  $("#<%=txtApellido.ClientID %>").removeClass("is-invalid");
                  $("#<%=txtApellido.ClientID %>").addClass("is-valid");
            }
            //dni
            if (dni === "") {

                $("#<%=txtDNI.ClientID %>").removeClass("is-valid");
                $("#<%=txtDNI.ClientID %>").addClass("is-invalid");
                valido = false;
              } else {

                  $("#<%=txtDNI.ClientID %>").removeClass("is-invalid");
                  $("#<%=txtDNI.ClientID %>").addClass("is-valid");
              }
            //contraseña
            if (contraseña === "") {

                $("#<%=TxtContraseña.ClientID %>").removeClass("is-valid");
                $("#<%=TxtContraseña.ClientID %>").addClass("is-invalid");
                valido = false;
              } else {

                  $("#<%=TxtContraseña.ClientID %>").removeClass("is-invalid");
                  $("#<%=TxtContraseña.ClientID %>").addClass("is-valid");
            }
            //mail
            if (mail === "") {

                $("#<%=txtEmail.ClientID %>").removeClass("is-valid");
                $("#<%=txtEmail.ClientID %>").addClass("is-invalid");
                valido = false;
            } else {

                $("#<%=txtEmail.ClientID %>").removeClass("is-invalid");
                $("#<%=txtEmail.ClientID %>").addClass("is-valid");
            }

            return valido;
        }
    </script>
   <h1 style="margin:10px 0 15px 30px">Registrarse</h1>
    <form id="form1" runat="server">
        <div  style="margin:0 0 0 30px" class="container-sm">
            <div class="form-group">
                <asp:Label Text="Nombre: " runat="server" />
                <asp:TextBox CssClass="form-control" runat="server" ID="txtNombre" />
            </div>
            <div class="form-group">
                <asp:Label Text="Apellido: " runat="server" />
                <asp:TextBox CssClass="form-control" runat="server" ID="txtApellido" />
            </div>
            <div class="form-group">

                <asp:Label Text="DNI: " runat="server" />
               <asp:TextBox CssClass="form-control" runat="server" ID="txtDNI"/>
            </div>
            <div class="form-group">
                <asp:Label Text="Email: " runat="server" />
               <asp:TextBox CssClass="form-control" runat="server" ID="txtEmail" ValidateRequestMode="Enabled" TextMode="Email" />

            </div>
            <div class="form-group">
                <asp:Label Text="Contraseña: " runat="server" />
               <asp:TextBox CssClass="form-control" runat="server" ID="TxtContraseña"/>
            </div>

            <asp:Button Text="Crear"  OnClientClick="return Validar()" CssClass="btn btn-dark" ID="btnCrear" OnClick="btnCrear_Click" runat="server"  />
            <a href="/Login.aspx" class="btn btn-dark">Volver</a>
        </div>
    </form>
</body>
</html>
