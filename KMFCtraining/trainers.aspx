<%@ Page Title="trainers" Language="C#" Debug="true" MasterPageFile="~/site1.master" AutoEventWireup="true" CodeFile="trainers.aspx.cs" Inherits="trainers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2"><asp:Label ID="lblOutput" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                <td style="text-align: right">Trainer name : </td>
                <td><asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
                    </td>
               </tr>
                <tr>
                <td style="text-align: right">Trainer email :  </td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                <td style="text-align: right">Enter the ID of the trainee that you want to update or delete </td>
                <td><asp:TextBox ID="txtTrainerId" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Before deleteing a trainer, please make sure the trainer isn't associated with a course." ForeColor="Red"></asp:Label></td>
                </tr>
                 <tr>
                    <td style="height: 84px"><asp:Label ID="Label2" runat="server" Text="*Note that you need to enter the name & email of the trainee in order to update it, otherwise it will be null."></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                    <asp:Button ID="btnAdd" runat="server" Text="add" OnClick="add_Click"  />
                       <asp:Button ID="btnView" runat="server" Text="view" OnClick="view_Click"  />
                       <asp:Button ID="btnDelete" runat="server" Text="delete" OnClick="delete_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="update" OnClick="update_Click" />
                    </td>
                </tr>
                 <tr>
                <td>Subject of the email : </td>
                <td><asp:TextBox ID="subject" runat="server">Congratulations!</asp:TextBox></td>
               </tr>
                <tr>
                <td>Message to be sent to the trainer </td>
                <td><asp:TextBox ID="message" TextMode="MultiLine" runat="server">You have been accepted as a trainer.</asp:TextBox></td>
               </tr>
            </table>
            <br />
            <asp:GridView ID="gvTrainer" runat="server" AutoGenerateColumns="False"
                DataKeyNames="trainerID"  >
                <Columns>
                    <asp:BoundField DataField="trainerID" HeaderText="trainerID" InsertVisible="False" ReadOnly="True" SortExpression="trainerID" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                </Columns>
            </asp:GridView>
         
            <br />

        </div>
    </form>
</asp:Content>

