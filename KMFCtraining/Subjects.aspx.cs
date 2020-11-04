using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using KMFCtraining.App_Code;
public partial class Subjects : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KMFCtraining.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (con.State == ConnectionState.Open)
        //{
        //    con.Close();
        //}
        //con.Open();
    }

    protected void add_Click(object sender, EventArgs e)
    {
        CRUD myCrud = new CRUD();
        string mySql = @"  insert into Subject(name) values (@name) ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@name", txtName.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "Subject has been inserted successfully"; }
        else
        { lblOutput.Text = "There was a problem inserting the Subject."; }
        getSubjectInfo();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "insert into Subject values('" + name.Text + "')";
        //cmd.ExecuteNonQuery();
        //Label1.Text = "Subject has been inserted successfully";
        //name.Text = "";
    }

    protected void view_Click(object sender, EventArgs e)
    {
        getSubjectInfo();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select * from Subject";
        //cmd.ExecuteNonQuery();
        //Label1.Text = "";
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //GridView1.DataSource = dt;
        //GridView1.DataBind();
    }

    protected void delete_Click(object sender, EventArgs e)
    {
        CRUD myCrud = new CRUD();
        string mySql = @" delete Subject
                            where subjectID = @subjectID ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@subjectID", txtSubjectID.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "Subject has been deleted."; }
        else
        { lblOutput.Text = "Couldn't delete subject."; }
        getSubjectInfo();
        //SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Subject WHERE ([subjectID] = @subject)", con);
        //SqlCommand check2 = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE ([subjectID] = @id)", con);
        //check.Parameters.AddWithValue("@subject", subjectID.Text);
        //check2.Parameters.AddWithValue("@id", subjectID.Text);
        //int CheckExist = (int)check.ExecuteScalar();
        //int CheckExist2 = (int)check2.ExecuteScalar();

        //if (CheckExist > 0)
        //{
        //    if (CheckExist2 > 0)
        //    {
        //        Label1.Text = "This subject field can't be deleted because it is associated with some courses.";
        //    }
        //    else { 
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "delete from Subject where subjectID='" + subjectID.Text + "'";
        //    cmd.ExecuteNonQuery();
        //    Label1.Text = "Subject has been deleted successfully";
        //    subjectID.Text = "";
        //    name.Text = "";
        //    }
        //}
        //else
        //{
        //    Label1.Text = "Please enter valid subject id.";
        //    subjectID.Text = "";
        //}
    }
    protected void getSubjectInfo()
    {
        CRUD myCrud = new CRUD();
        string mySql = @"  select * from Subject  ";

        SqlDataReader dr = myCrud.getDrPassSql(mySql);
        gvSubjects.DataSource = dr;
        gvSubjects.DataBind();

    }
}