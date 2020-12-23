<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="TPC_Leal.PruebaModificarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Modificar Usuario</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</head>
<body>
   <h1>Modificar Usuario</h1>
    <form id="form1" runat="server">
        <div >
          
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
               <asp:TextBox CssClass="form-control" runat="server" ID="txtEmail" />

            </div>
            <div class="form-group">
                <asp:Label Text="Contraseña: " runat="server" />
               <asp:TextBox CssClass="form-control" runat="server" ID="TxtContraseña"/>
            </div>

            <asp:Button Text="Modificar" runat="server" CssClass="btn btn-dark" ID="btnModificar" OnClick="btnModificar_Click"  />
            <a href="/ABMUsuarios" class="btn btn-dark">Volver</a>
        </div>
    </form>
</body>
</html>
