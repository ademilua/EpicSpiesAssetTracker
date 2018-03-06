<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="spylogoImage" runat="server" Height="50px" Width="50px" />
        <br />
        <br />
        Spy New Assignment<br />
        <br />
        Spy Code Name:
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:<asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment:<br />
        <asp:Calendar ID="firstCalendar" runat="server" Height="80px" Width="80px"></asp:Calendar>
        <br />
        Start Date of New Assignment:<br />
        <asp:Calendar ID="secondCalendar" runat="server" Height="80px" Width="80px"></asp:Calendar>
        <br />
        <br />
        Projected End Date of New Assignment:<br />
        <asp:Calendar ID="thirdCalendar" runat="server" Height="80px" Width="80px"></asp:Calendar>
        <br />
        <asp:Button ID="okButton" runat="server" Text="Assign Spy" OnClick="okButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
