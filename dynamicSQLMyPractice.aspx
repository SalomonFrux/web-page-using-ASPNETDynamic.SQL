<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="RetrivingDataFromSqlDataBase2.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel ="stylesheet" type="text/css"
    href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form2" runat="server">
       
        <div>
            <h1>EMPLOYEE LIST</h1>
            <asp:Label ID="lblFirstName" runat="server" Text="FirstName"></asp:Label>
           
            <input id="txtFirstName"  runat="server" type="text" />
        </div>

        <div>
            <asp:Label ID="lblLastName" runat="server" Text="LastName"></asp:Label>
           <input id="txtLastName"  runat="server" type="text" />
        </div>
        <div>
             <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            <input id="txtGender"  runat="server" type="text" />
        </div>
        <div>
             <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
            <input id="txtSalary"  runat="server" type="text" />
        </div>

        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />

      

           <h2>SEARCH RESULT</h2>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
           
  
    </form>
     
</body>
</html>
