<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mesajoku.aspx.cs" Inherits="mesajoku" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            Height="50px" Width="382px" 
            EmptyDataText="Mesaj Başarıyla Silindi...">
        </asp:DetailsView>
    
    <asp:HyperLink ID="git" runat="server" NavigateUrl="~/mesajlarim.aspx" Text="Mesajlara Dön"></asp:HyperLink></div>
    </form>
</body>
</html>
