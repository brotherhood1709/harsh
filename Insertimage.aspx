<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertimage.aspx.cs" Inherits="Defination.Insertimage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Image Upload</h1>

            <asp:Label ID="Label1" runat="server" Text="image Upload"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" /><br />


            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>

        <div>
            <asp:DataList ID="DataList1" runat="server"></asp:DataList><asp:SqlDataSource runat="server" ID="SqlDataSource1"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
