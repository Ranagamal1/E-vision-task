<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewer.aspx.cs" Inherits="E_vision_task.viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" type="text/css" rel="stylesheet" />
          <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
       <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <div class="cd-main-content">
    <nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#mynavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
<a class="navbar-brand" href="#mypage">Product items</a>
        </div>
        <div class="collapse navbar-collapse" id="mynavbar">
            <ul class="nav navbar-nav navbar-right">
                <li><a href="Home.aspx">Home</a></li>
                <li><a href="viewer.aspx">View items</a></li>
                <li><a href="WebForm1.aspx">Edit items</a></li>
            </ul>
        </div>
    </div>
        </nav>
        </div>
    <form id="form1" runat="server">
    <div style="height: 353px">
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="201px" style="margin-left: 292px; margin-top: 81px" Width="661px">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
        <Columns>  
                    <asp:BoundField DataField="id" HeaderText="id" /> 
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:ImageField AccessibleHeaderText="Photo" DataImageUrlField="Photo" HeaderText="Photo">
                        <ControlStyle Font-Size="Small" Height="50px" Width="50px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="Price" HeaderText="Price" /> 
                    <asp:BoundField DataField="LastUpdated" HeaderText="LastUpdated" />
        </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
