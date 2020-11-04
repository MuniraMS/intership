using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using KMFCtraining.App_Code;

public partial class Coursetrainer : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KMFCtraining.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        //if (con.State == ConnectionState.Open)
        //{
        //    con.Close();
        //}
        //con.Open();
        viewtrainers();
        viewcourses();
    }

    protected void add_Click(object sender, EventArgs e)
    {
        CRUD myCrud = new CRUD();
        string mySql = @"  insert into trainer_courses(trainerID,CourseID) values (@trainerID,@courseID) ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@trainerID", txtTrainerID.Text);
        myPara.Add("@courseID", txtCourseID.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "You've assigned a trainer to a course successfully"; }
        else
        { lblOutput.Text = "Mission failed"; }
        viewcoursetrainer();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "insert into trainer_courses values('" + txtTrainerID.Text + "','" + txtCourseID.Text + "')";
        //cmd.ExecuteNonQuery();
        //Label1.Text = "You've assigned a trainer to a course successfully.";
        //txtTrainerID.Text = "";
        //txtCourseID.Text = "";
    }

    public void viewtrainers ()
    {
        CRUD myCrud = new CRUD();
        string mySql = @"  select * from trainer  ";
        SqlDataReader dr = myCrud.getDrPassSql(mySql);
        gvTrainers.DataSource = dr;
        gvTrainers.DataBind();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select trainerID,name from trainer";
        //cmd.ExecuteNonQuery();
        //Label1.Text = "";
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //gvTrainers.DataSource = dt;
        //gvTrainers.DataBind();
    }
    public void viewcourses()
    {
        CRUD myCrud = new CRUD();
        string mySql = @"  select * from Courses  ";
        SqlDataReader dr = myCrud.getDrPassSql(mySql);
        gvCourses.DataSource = dr;
        gvCourses.DataBind();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select courseID,courseName from Courses";
        //cmd.ExecuteNonQuery();
        //Label1.Text = "";
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //gvCourses.DataSource = dt;
        //gvCourses.DataBind();
    }
    public void viewcoursetrainer()
    {
        CRUD myCrud = new CRUD();
        string mySql = @"SELECT T.name, C.courseName FROM trainer T, trainer_courses TC, Courses C WHERE T.trainerID = TC.trainerID AND TC.CourseID = C.courseID";
        SqlDataReader dr = myCrud.getDrPassSql(mySql);
        gvCourseTrainers.DataSource = dr;
        gvCourseTrainers.DataBind();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select courseID,courseName from Courses";
        //cmd.ExecuteNonQuery();
        //Label1.Text = "";
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //gvCourses.DataSource = dt;
        //gvCourses.DataBind();
    }
    protected void show_Click(object sender, EventArgs e)
    {
        viewcoursetrainer();
       
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;

        //cmd.CommandText = "SELECT T.name, C.courseName FROM trainer T, trainer_courses TC, Courses C WHERE T.trainerID = TC.trainerID AND TC.CourseID = C.courseID";
        //cmd.ExecuteNonQuery();
        //Label1.Text = "";
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //gvCourseTrainers.DataSource = dt;
        //gvCourseTrainers.DataBind();
    }

    protected void delete_Click(object sender, EventArgs e)
    {
        CRUD myCrud = new CRUD();
        string mySql = @" delete trainer_courses
                            where trainerId = @trainerId AND CourseID= @courseId";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@trainerId", txtTrainerID.Text);
        myPara.Add("@courseId", txtCourseID.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "Sucess"; }
        else
        { lblOutput.Text = "Failed, please make sure that you entered correct trainer ID and course ID"; }
        viewcoursetrainer();
        //SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM trainer_courses WHERE ([trainerID] = @trainerid) AND  ([CourseID] = @courseID) ", con);
        //check.Parameters.AddWithValue("@trainerid", txtTrainerID.Text);
        //check.Parameters.AddWithValue("@courseID", txtCourseID.Text);
        //int CheckExist = (int)check.ExecuteScalar();
        //if (CheckExist > 0)
        //{
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "delete from trainer_courses where trainerID='" + txtTrainerID.Text + "' AND CourseID='" + txtCourseID.Text + "'";
        //    cmd.ExecuteNonQuery();
        //    Label1.Text = "Row has been deleted successfully";
        //    txtTrainerID.Text = "";
        //    txtCourseID.Text = "";
        //}
        //else
        //{
        //    Label1.Text = "The trainee id you entered doesn't match with the course, please make sure to enter correct IDs.";
        //    txtTrainerID.Text = "";
        //    txtCourseID.Text = "";
        //}


    }
}