<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageUpload.aspx.cs" Inherits="Task2.ImageUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <%--<tr>
                    <td>Image: </td><td><asp:Image ID="imageshow" runat="server" Width="150px" /></td>
                </tr>--%>
                <tr>
                    <td>Upload Image: </td><td><asp:FileUpload ID="uploadimage" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnupload" runat="server" Text="UPLOAD IMAGE" OnClick="btnupload_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
