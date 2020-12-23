<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPC_Leal.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <h1 style="text-align:center">Carrito</h1>
    <div class="container">
        <div class="row"></div>
        <div class="col">

            <table class="table">

                <tr>
                    <td>Producto</td>
                    <td>Precio</td>
                    <td>Cantidad</td>
                    <td>Acción</td>
                    <td>Subtotal</td>
                </tr>
                <%foreach(var prod in listaCarro)
                    {%>
                <tr>
                    <td><%=prod.articulo.Nombre %></td>
                    <td><%=prod.articulo.Precio%></td>
                    <td>
                        <a href="Carrito.aspx?idrestcantidad=<% =prod.articulo.IdArticulo.ToString() %>" class="btn btn-dark">-</a>
                        <%=prod.Cantidad %>
                        <a href="Carrito.aspx?idsumcantidad=<% =prod.articulo.IdArticulo.ToString() %>" class="btn btn-dark">+</a>

                    </td>
                    <td><a href="Carrito.aspx?idquitar=<% =prod.articulo.IdArticulo.ToString() %>" class="btn btn-dark">Quitar</a></td>
                    <td><%="$" %><%=prod.subtotal %></td>
                </tr>

                <%} %>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td style="font-weight: bold">Total</td>
                    <td>
                        <asp:Label Text="" runat="server" ID="lblTotal" />
                    </td>
                </tr>
            </table>

        </div>

        
    </div>
    <a href="/Productos.aspx" style="margin:10px 20px 0 25%;" class="btn btn-dark">Seguir Comprando</a>
    <asp:Button Text="Finalizar Compra" CssClass="btn btn-dark" style="margin-top:10px;" ID="btnFinalizarCompra" runat="server" OnClick="btnFinalizarCompra_Click"  />
    <asp:Label ID="lblCarro" runat="server" />
</asp:Content>
