<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExportToPdf.WebForm1" %>

<!DOCTYPE html>
<script src="Scripts/bootstrap.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/myStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
   
        <div >
            <h1 >Download Pdf</h1>
            <asp:CheckBox ID="CheckBox1" runat="server"  />
            <asp:Button ID="Button1" runat="server" class ="btn btn-primary" onclick="Button1_Click" Text="Button" />
        </div>
 
    </form>
</body>
</html>
