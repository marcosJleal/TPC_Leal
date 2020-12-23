<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TPC_Leal.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Alta Articulo</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</head>
<body>
    <script>
        function Validar() {

            var nombre = document.getElementById("<%=txtNombre.ClientID %>").value;
            var stock = document.getElementById("<%=txtStock.ClientID %>").value;
            var precio = document.getElementById("<%=txtPrecio.ClientID %>").value;
            var descripcion = document.getElementById("<%=txtDescripcion.ClientID%>").value;
            var colores = document.getElementById("<%=cboColores.ClientID%>").value;
            var categoria = document.getElementById("<%=cboCategorias.ClientID%>").value;
            var urlimagen = document.getElementById("<%=txtUrlImagen.ClientID%>").value;
            var valido = true;

            if (nombre === "") {

                $("#<%=txtNombre.ClientID %>").removeClass("is-valid");
                $("#<%=txtNombre.ClientID %>").addClass("is-invalid");
                valido=false;
            } else {
                
                $("#<%=txtNombre.ClientID %>").removeClass("is-invalid");
                $("#<%=txtNombre.ClientID %>").addClass("is-valid");
            }
            //stock
            if (stock === "") {

                $("#<%=txtStock.ClientID %>").removeClass("is-valid");
                $("#<%=txtStock.ClientID %>").addClass("is-invalid");
                valido = false;
              } else {

                  $("#<%=txtStock.ClientID %>").removeClass("is-invalid");
                  $("#<%=txtStock.ClientID %>").addClass("is-valid");
            }
            //precio
            if (precio === "") {

                $("#<%=txtPrecio.ClientID %>").removeClass("is-valid");
                $("#<%=txtPrecio.ClientID %>").addClass("is-invalid");
                valido = false;
              } else {

                  $("#<%=txtPrecio.ClientID %>").removeClass("is-invalid");
                  $("#<%=txtPrecio.ClientID %>").addClass("is-valid");
              }
            //descripcion
            if (descripcion === "") {

                $("#<%=txtDescripcion.ClientID %>").removeClass("is-valid");
                $("#<%=txtDescripcion.ClientID %>").addClass("is-invalid");
                valido = false;
              } else {

                  $("#<%=txtDescripcion.ClientID %>").removeClass("is-invalid");
                  $("#<%=txtDescripcion.ClientID %>").addClass("is-valid");
            }
            //colores
            if (colores === "") {

                $("#<%=cboColores.ClientID %>").removeClass("is-valid");
                $("#<%=cboColores.ClientID %>").addClass("is-invalid");
                valido = false;
            } else {

                $("#<%=cboColores.ClientID %>").removeClass("is-invalid");
                $("#<%=cboColores.ClientID %>").addClass("is-valid");
            }
            //categoria
            if (categoria === "") {

                $("#<%=cboCategorias.ClientID %>").removeClass("is-valid");
                $("#<%=cboCategorias.ClientID %>").addClass("is-invalid");
                valido = false;
            } else {

                $("#<%=cboCategorias.ClientID %>").removeClass("is-invalid");
                $("#<%=cboCategorias.ClientID %>").addClass("is-valid");
            }
            //urlimagen
            if (urlimagen === "") {

                $("#<%=txtUrlImagen.ClientID %>").removeClass("is-valid");
                $("#<%=txtUrlImagen.ClientID %>").addClass("is-invalid");
                valido = false;
            } else {

                $("#<%=txtUrlImagen.ClientID %>").removeClass("is-invalid");
                $("#<%=txtUrlImagen.ClientID %>").addClass("is-valid");
            }

            return valido;
        }
    </script>
    <h1 style="margin-left:40px">Alta articulo</h1>
    <form id="form1" runat="server">
        <div style="margin:0 0 0 30px" class="container-sm" >
            <div class="form-group">
                <asp:Label Text="Nombre: " runat="server" />
                <asp:TextBox CssClass="form-control" runat="server" ID="txtNombre" />
            </div>
            <div class="form-group">
                <asp:Label Text="Stock: " runat="server" />
                <asp:TextBox CssClass="form-control" runat="server" ID="txtStock" />
            </div>
            <div class="form-group">

                <asp:Label Text="Precio: " runat="server" />
               <asp:TextBox CssClass="form-control" runat="server" ID="txtPrecio"/>
            </div>
            <div class="form-group">
                <asp:Label Text="Descripcion: " runat="server" />
               <asp:TextBox CssClass="form-control" runat="server" ID="txtDescripcion" />

            </div>
            <div class="form-group">
                <asp:Label Text="Categorias: " runat="server" />
                <asp:DropDownList CssClass="form-control" ID="cboCategorias" runat="server"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label Text="Colores: " runat="server" />
                <asp:DropDownList CssClass="form-control" ID="cboColores" runat="server"></asp:DropDownList>
                <asp:Label Text="Cantidad: " runat="server" />
                <asp:TextBox runat="server" ID="txtCantidad"/>
                <asp:Button Text="Agregar Color"  runat="server" ID="btnAgregarColor" OnClick="btnAgregarColor_Click" />
                <asp:GridView ID="dgvColores"  runat="server"></asp:GridView>
            </div>
            <div class="form-group">
                <asp:Label Text="UrlImagen: " runat="server" />
               <asp:TextBox CssClass="form-control" runat="server" ID="txtUrlImagen"/>
            </div>

            <asp:Button Text="Agregar" OnClientClick="return Validar()" runat="server" CssClass="btn btn-dark" ID="btnAgregar" OnClick="btnAgregar_Click" />
            <a href="/ABMArticulos.aspx" class="btn btn-dark">Volver</a>
        </div>
    </form>
</body>
</html>
