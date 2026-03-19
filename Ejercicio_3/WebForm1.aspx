<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label>
        <asp:DropDownList ID="ddlCategory" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Label ID="lblSupplier" runat="server" Text="Supplier"></asp:Label>
            <asp:DropDownList ID="ddlSupplier" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Label ID="lblProduct" runat="server" Text="Product"></asp:Label>
        <asp:TextBox ID="txtProduct" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" style="margin-bottom: 11px"></asp:TextBox>
        </p>
        <asp:Label ID="lblImage" runat="server" Text="Image "></asp:Label>
        <asp:TextBox ID="txtImage" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price "></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblNumberInStock" runat="server" Text="Number In Stock"></asp:Label>
        <asp:TextBox ID="txtNumberInStock" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblNumberOnOrder" runat="server" Text="Number on Order"></asp:Label>
            <asp:TextBox ID="txtNumberOnOrder" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblReorderLevel" runat="server" Text="Reorder Level"></asp:Label>
        <asp:TextBox ID="txtReorderLevel" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblValueInStock" runat="server" Text="Value in Stock"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblValueOnOrder" runat="server" Text="Value on Order"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
        </p>
    </form>
</body>
</html>
