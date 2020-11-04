<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/site1.master" AutoEventWireup="true" CodeFile="Coursetrainer.aspx.cs" Inherits="Coursetrainer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="All trainers : "></asp:Label>
            <asp:GridView ID="gvTrainers" runat="server" ></asp:GridView>
            <br />
            <asp:Label ID="Label3" runat="server" Text="All courses : "></asp:Label>
            <asp:GridView ID="gvCourses" runat="server" ></asp:GridView>
            <table>
                <tr>
                    <td><asp:Label ID="lblOutput" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Please note that you need to enter IDs that exists in each table shown above, otherwise it won't work." ForeColor="Red"></asp:Label></td>
                </tr>
                <tr>
                <td>Trainer ID :</td>
                <td><asp:TextBox ID="txtTrainerID" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                <td>Course ID :</td>
                <td><asp:TextBox ID="txtCourseID" runat="server"></asp:TextBox></td>
               </tr>
                 <tr>
                <td><asp:Label ID="Label5" runat="server" Text="To delete row, please enter BOTH trainer ID and course ID" ForeColor="Red"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                    <asp:Button ID="add" runat="server" Text="add" OnClick="add_Click"   />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="delete_Click" />
                    <asp:Button ID="btnShow" runat="server" Text="show" OnClick="show_Click" />
                    </td>
                </tr>
            </table>
            <br/>
            <asp:GridView ID="gvCourseTrainers" runat="server" ></asp:GridView>
            <br />
        </div>
    </form>
</asp:Content>

