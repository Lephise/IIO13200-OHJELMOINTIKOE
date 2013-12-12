<%@ Page Language="C#" AutoEventWireup="true" CodeFile="f6689_T3b.aspx.cs" Inherits="f6689_T3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="kirjmaar" runat="server"></asp:Label><br />


    Nimi: <asp:TextBox ID="nimi" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
            ControlToValidate="nimi" 
            
            ValidationExpression="^[a-öA-Ö]*$" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="nimi"/><br />



    Päivämäärä (dd.mm.yyyy): <asp:TextBox ID="pvm" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
            ControlToValidate="pvm" 
            
            ValidationExpression="^(((0[1-9]|[12]\d|3[01]).(0[13578]|1[02]).((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30).(0[13456789]|1[012]).((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8]).02.((19|[2-9]\d)\d{2}))|(29.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="pvm"/><br />


    Tuntimäärä (hh:mm): <asp:TextBox ID="aika" runat="server"></asp:TextBox><br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
            ControlToValidate="aika" 
            
            ValidationExpression="^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="aika"/>

    <asp:Button ID="submitti" runat="server" Text="Lisää Tunti" OnClick="submitti_Click" /><br />

    <asp:DropDownList ID="koodarit" runat="server">
        <asp:ListItem Text="Linus" Value="1"></asp:ListItem>
        <asp:ListItem Text="Richard" Value="2"></asp:ListItem>
        <asp:ListItem Text="Monty" Value="3"></asp:ListItem>
        <asp:ListItem Text="Bjarne" Value="4"></asp:ListItem>
    </asp:DropDownList>
        <asp:Button ID="valittu" runat="server" Text="Listaa valitun koodarin kirjaukset" OnClick="valittu_Click" />

    <asp:GridView ID="grid" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
