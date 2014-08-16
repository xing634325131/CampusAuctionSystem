<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shangchuang.aspx.cs" Inherits="CASys.UI.shangchuang" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>文件上传的例子</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="fileUpload" runat="server" />
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="上传" />
        <asp:Literal ID="literal" runat="server"></asp:Literal></div>
    </form>
</body>
</html>