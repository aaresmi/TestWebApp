<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetirveCarDetails.aspx.cs" Inherits="Car.WebUILayer.RetirveCarDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Select a Car Name:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlCars" runat="server" 
            onselectedindexchanged="ddlCars_SelectedIndexChanged" AutoPostBack="True" 

             >
           
          <%--  <asp:ListItem Value="1" Selected="True" >--Select--</asp:ListItem>--%>
        </asp:DropDownList>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    
    </div>
    <asp:GridView ID="gridCars" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField HeaderText="Car Name" DataField="CarName" />
            <asp:BoundField HeaderText="Model Number" DataField="ModelNumber" />
            <asp:BoundField HeaderText="Feature" DataField="Features" />
            <asp:BoundField HeaderText="Comment" DataField="Comments" />
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
