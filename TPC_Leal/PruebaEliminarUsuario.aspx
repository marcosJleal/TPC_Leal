<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaEliminarUsuario.aspx.cs" Inherits="TPC_Leal.PruebaEliminarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <h1>Eliminar Usuario</h1>
    <form id="form1" runat="server">
        <div>
            <div class="form-group">
                <asp:Label Text="ID: " runat="server" />
                <asp:TextBox runat="server" ID="txtID" />
            </div>
            <asp:Button Text="Eliminar" runat="server" CssClass="btn btn-dark" ID="btnEliminar" OnClick="btnEliminar_Click" />
            <a href="#" class="btn btn-dark">Volver</a>
        </div>
    </form>
</body>
</html>
