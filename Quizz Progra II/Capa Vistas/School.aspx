<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="School.aspx.cs" Inherits="Quizz_Progra_II.School" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Escuelas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvSchools" runat="server" AutoGenerateColumns="True"></asp:GridView>
        </div>
    </form>
</body>
</html>
