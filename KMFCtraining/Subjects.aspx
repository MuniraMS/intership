<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/site1.master" AutoEventWireup="true" CodeFile="Subjects.aspx.cs" Inherits="Subjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="lblOutput" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                <td>Name of the subject : </td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
               </tr>
                <tr>
                <td>Enter the ID of the subject that you want to delete </td>
                <td><asp:TextBox ID="txtSubjectID" runat="server"></asp:TextBox></td>
               </tr>
                 <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Please before deleting subject, make sure it is not associated with any course. " ForeColor="Red"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                    <asp:Button ID="btnAdd" runat="server" Text="add" OnClick="add_Click"  />
                       <asp:Button ID="btnView" runat="server" Text="view" OnClick="view_Click"  />
                       <asp:Button ID="btnDelete" runat="server" Text="delete" OnClick="delete_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="gvSubjects" runat="server" AutoGenerateColumns="False"
                DataKeyNames="subjectID"  >
                <Columns>
                    <asp:BoundField DataField="subjectID" HeaderText="subjectID" InsertVisible="False" ReadOnly="True" SortExpression="subjectID" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                </Columns>
            </asp:GridView>
            <br />

        </div>
    </form>
</asp:Content>

