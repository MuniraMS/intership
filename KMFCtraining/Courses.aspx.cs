using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using KMFCtraining.App_Code;

public partial class Courses : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KMFCtraining.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        //if (con.State == ConnectionState.Open)
        //{
        //    con.Close();
        //}
        //con.Open();
        if (!Page.IsPostBack) {
            CRUD myCrud = new CRUD();
            string mySql = @"select * from Subject";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            ddlCF.DataTextField = "name";
            ddlCF.DataValueField = "subjectID";
            ddlCF.DataSource = dr;
            ddlCF.DataBind();
            //string com = "Select * from Subject";
            //SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            //DataTable dt = new DataTable();
            //adpt.Fill(dt);
            //ddlCF.DataSource = dt;
            //ddlCF.DataTextField = "name";
            //ddlCF.DataValueField = "subjectID";
            //ddlCF.DataBind();
        }
    }


    protected void add_Click(object sender, EventArgs e)
    {
        CRUD myCrud = new CRUD();
        string mySql = @"  insert into Courses(courseName,courseDesc,subjectID) values (@name,@desc,@subjectid) ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@name", txtCourseName.Text);
        myPara.Add("@desc", txtDesc.Text);
        myPara.Add("@subjectid", int.Parse(ddlCF.SelectedValue));
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "Course has been inserted successfully"; }
        else
        { lblOutput.Text = "There was a problem inserting the Subject."; }
        getCoursesInfo();
        //SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE ([courseName] = @coursename)", con);
        //check.Parameters.AddWithValue("@coursename", txtCourseName.Text);
        //int CheckExist = (int)check.ExecuteScalar();

        //if (CheckExist > 0)
        //{
        //    lblOutput.Text = "This course exist already and each course should be assigned to one field only. Please enter another course.";
        //    txtCourseID.Text = "";
        //}
        //else
        //{
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "insert into Courses values('" + txtCourseName.Text + "','" + txtDesc.Text + "','" + int.Parse(ddlCF.SelectedValue) + "')";
        //    cmd.ExecuteNonQuery();
        //    lblOutput.Text = "Course has been inserted successfully";
        //    txtCourseName.Text = "";
        //    txtDesc.Text = "";
        //}

    }

    protected void view_Click(object sender, EventArgs e)
    {
        getCoursesInfo();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select * from Courses";
        //cmd.ExecuteNonQuery();
        //lblOutput.Text = "";
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //GridView1.DataSource = dt;
        //GridView1.DataBind();
    }

    protected void viewSubject_Click(object sender, EventArgs e)
    {
        getSubjectInfo();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select * from Subject";
        //cmd.ExecuteNonQuery();
        //lblOutput.Text = "";
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //GridView2.DataSource = dt;
        //GridView2.DataBind();
    }

    protected void delete_Click(object sender, EventArgs e)
    {
        CRUD myCrud = new CRUD();
        string mySql = @" delete Courses
                            where courseID = @courseID ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@courseID", txtCourseID.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "Sucess"; }
        else
        { lblOutput.Text = "Failed"; }
        getCoursesInfo();
        //SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE ([courseID] = @course)", con);
        //SqlCommand check2 = new SqlCommand("SELECT COUNT(*) FROM trainer_courses WHERE ([CourseID] = @courseid)", con);
        //check.Parameters.AddWithValue("@course", txtCourseID.Text);
        //check2.Parameters.AddWithValue("@courseid", txtCourseID.Text);
        //int CheckExist = (int)check.ExecuteScalar();
        //int CheckExist2 = (int)check2.ExecuteScalar();

        //if (CheckExist > 0)
        //{
        //    if (CheckExist2 > 0)
        //    {
        //        lblOutput.Text = "This Course can't be deleted because there are some trainers training it.";
        //    }
        //    else
        //    {
        //        SqlCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "delete from Courses where courseID='" + txtCourseID.Text + "'";
        //        cmd.ExecuteNonQuery();
        //        lblOutput.Text = "course has been deleted successfully";
        //        txtCourseID.Text = "";
        //        txtCourseName.Text = "";
        //        txtDesc.Text = "";
        //    }
        //}
        //else
        //{
        //    lblOutput.Text = "Please enter valid course id.";
        //    txtCourseID.Text = "";
        //}

    }

    protected void update_Click(object sender, EventArgs e)
    {
        CRUD myCrud = new CRUD();
        string mySql = @" update Courses set courseName =@name, courseDesc= @desc, subjectID=@subjectID
                            where courseID = @courseID ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@name", txtCourseName.Text);
        myPara.Add("@desc", txtDesc.Text);
        myPara.Add("@subjectid", int.Parse(ddlCF.SelectedValue));
        myPara.Add("@courseID", txtCourseID.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "Sucess"; }
        else
        { lblOutput.Text = "Failed"; }
        getCoursesInfo();
        //    SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE ([courseID] = @course)", con);
        //    check.Parameters.AddWithValue("@course", txtCourseID.Text);
        //    int CheckExist = (int)check.ExecuteScalar();

        //    if (CheckExist > 0)
        //    {
        //        SqlCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "update Courses set courseName='" + txtCourseName.Text + "', courseDesc='" + txtDesc.Text + "', subjectID='" + ddlCF.SelectedValue + "' where courseID='" + txtCourseID.Text + "'";
        //        cmd.ExecuteNonQuery();
        //        lblOutput.Text = "Course has been updated successfully";
        //        txtCourseID.Text = "";
        //        txtCourseName.Text = "";
        //        txtDesc.Text = "";
        //    }
        //    else
        //    {
        //        lblOutput.Text = "Please enter valid course id.";
        //        txtCourseID.Text = "";
        //    }

    }
    protected void getSubjectInfo()
    {
        CRUD myCrud = new CRUD();
        string mySql = @"  select * from Subject  ";
        SqlDataReader dr = myCrud.getDrPassSql(mySql);
        gvSubjects.DataSource = dr;
        gvSubjects.DataBind();

    }
    protected void getCoursesInfo()
    {
        CRUD myCrud = new CRUD();
        string mySql = @"  select * from Courses  ";
        SqlDataReader dr = myCrud.getDrPassSql(mySql);
        gvCourses.DataSource = dr;
        gvCourses.DataBind();

    }
}