<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/site1.master" AutoEventWireup="true" CodeFile="Courses.aspx.cs" Inherits="Courses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="lblOutput" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                <td>Course name : </td>
                <td><asp:TextBox ID="txtCourseName" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                <td>Course description :  </td>
                <td><asp:TextBox ID="txtDesc" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                <td>Choose the course field : </td>
                <td><asp:DropDownList ID="ddlCF" runat="server" >  
        </asp:DropDownList> </td>
               </tr>
                <tr>
                <td>Enter the ID of the course that you want to update or delete </td>
                <td><asp:TextBox ID="txtCourseID" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                    <td colspan="2">
                    <asp:Button ID="btnAdd" runat="server" Text="add" OnClick="add_Click"  />
                        <asp:Button ID="btnViewSubject" runat="server" Text="view subjects" OnClick="viewSubject_Click" />
                       <asp:Button ID="btnViewCourses" runat="server" Text="view courses" OnClick="view_Click" />
                       <asp:Button ID="btnDelete" runat="server" Text="delete" OnClick="delete_Click"  />
                        <asp:Button ID="btnUpdate" runat="server" Text="update" OnClick="update_Click" />
                    </td>
                </tr>
                   <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="*In case you need to know the corresponding name of the field for the subject ID click view subjects."></asp:Label></td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="gvSubjects" runat="server" ></asp:GridView>
            <br />
            <asp:GridView ID="gvCourses" runat="server" ></asp:GridView>
            <br />

        </div>
    </form>
</asp:Content>

