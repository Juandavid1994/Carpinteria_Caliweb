<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProveedores.aspx.cs" Inherits="carpinteria_Pagina_Web.Views.Paginas.frmProveedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>    
    <link rel="stylesheet" href="../../Estilos css/EstiloProveedores.css" />

</head>
<body>
    <h1>&nbsp; FORMULARIO DE REGISTRO </h1>


    <form id="form1" runat="server" class="form-register">
    <div class="contenedor-inputs">
        <h2 class="frmTitulo">INGRESE LOS DATOS DE LOS PROVEEDORES</h2>
        

        <asp:TextBox ID="txtCodigo" runat="server" placeholder="C.C / NIT"></asp:TextBox>

        <asp:TextBox ID="RazónSocial" runat="server" placeholder="Razón Social"></asp:TextBox>
        <asp:TextBox ID="Dirección"  runat ="server"  placeholder="Dirección"></asp:TextBox>
        <asp:TextBox ID="Teléfono1" runat="server" placeholder="Teléfono 1" ></asp:TextBox>
        <asp:TextBox ID="Teléfono2" runat="server" placeholder="Teléfono 2"></asp:TextBox>
        <asp:TextBox ID="Celular" runat="server" placeholder="Celular"></asp:TextBox>
        <asp:TextBox ID="Correo" runat="server" placeholder="Correo Electronico"></asp:TextBox>
        <asp:TextBox ID="Producto" runat="server" placeholder="Producto"></asp:TextBox>

        <asp:Label ID="Label1" runat="server"></asp:Label>

        <br />
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        <asp:Button ID="Button2" runat="server" Text="Eliminar" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Button" />

        <asp:Button ID="btnConfirmacion" runat="server" OnClick="btnConfirmacion_Click" Text="Confirmacion" />

        <p>Lee nuestra politica de datos&nbsp; <a href="#">Política de uso de informacion </a>
        </p>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="gvwDatos" runat="server" AutoGenerateColumns="False" EmptyDataText="No se encontraron Registros" Width="100%" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowCommand="gvwDatos_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Codigo">
                    <ItemTemplate>
                        <asp:Label ID="lblCodigo" runat="server" Text='<%# Bind("Cedula_Nit") %> '/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="RazonSocial" HeaderText="razonsocial"/>
                <asp:BoundField DataField="Direccion" HeaderText="direccion"/>
                <asp:BoundField DataField="Telefono1" HeaderText="telefono1"/>
                <asp:BoundField DataField="Telefono2" HeaderText="telefono2"/>
                <asp:BoundField DataField="Celular" HeaderText="celular"/>
                <asp:BoundField DataField="Correo" HeaderText="correo"/>
                <asp:BoundField DataField="Producto" HeaderText="Producto"/>
                 <asp:TemplateField HeaderText="Eliminar">
                  <ItemTemplate>
                        <asp:ImageButton ID="lbEliminar" runat="server" CommandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" ImageUrl="~/imagenesfrmproveedores/salir.svg"/>
                    </ItemTemplate>
                     <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        </div>


</body>


    <div>
    
    </div>

    </form>
   
    
 
</html>
