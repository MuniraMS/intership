<%@ Page Title="" Language="C#" MasterPageFile="~/site1.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>This is a website to associate trainers with courses.</h2> 
    <img src="https://i.imgur.com/wxFZ0dt.png" alt="ER Diagram for the project." width="800" height="423">
    <h3>What you can do : </h3>
    <h4>-For trainers </h4>
    <ol>
  <li>Add new trainer</li><br />
  <li>View the available trainers</li><br />
  <li>Delete trainee</li><br />
  <li>Update trainee</li><br />
  <li>Send email to a trainee</li><br />
    </ol>
   <h4>-For Subjects </h4>
    <p>Subjects are the fields that the course belongs to.</p>
    <ol>
  <li>Add new subject</li><br />
  <li>View the available fields</li><br />
  <li>Delete a field</li><br />
    </ol>
     <h4>-For Courses </h4>
    <ol>
  <li>Add new course</li><br />
  <li>View the available fields so you can choose the right field for the course</li><br />
  <li>View the available courses</li><br />
  <li>Delete a courses</li><br />
  <li>Update a courses</li><br />
    </ol>
    <h4>-To associate trainers with courses. </h4>
    <ol>
  <li>Associate trainer with course</li><br />
  <li>Delete an associated relationship between trainer and course</li><br />
  <li>View each trainer with his/her courses</li><br />
    </ol>
        
</asp:Content>

