<%@ Page Language="C#" AutoEventWireup="true" CodeFile="School.aspx.cs" Inherits="Schools" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Escuelas</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvSchools" runat="server" AutoGenerateColumns="True"></asp:GridView>
        <a href="AddSchool.aspx">Agregar Nueva Escuela</a>
    </form>
</body>
</html>
