<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hej hej</h1>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate><h2>Vindistrikt</h2></HeaderTemplate>
            <ItemTemplate><br /><%#Container.DataItem%></ItemTemplate>
            <FooterTemplate><br /><strong>Låt det väl smaka</strong> </FooterTemplate>
        </asp:Repeater>
    </div>
    <div>
        <asp:Button ID="TfnNumberBtn" runat="server" Text="Hämta telefonnummer" 
            onclick="TfnNumberBtn_Click" />
    </div>
    <div>
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate><%#Container.DataItem %><br /></ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
