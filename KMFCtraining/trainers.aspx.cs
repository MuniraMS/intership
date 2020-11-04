using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using KMFCtraining.App_Code;

public partial class trainers : System.Web.UI.Page
{
   // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KMFCtraining.mdf;Integrated Security=True");
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
        string mySql = @"  insert into trainer(name,email)      values (@name, @email ) ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@name",txtName.Text);
        myPara.Add("@email", txtEmail.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        {
            try
            {

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("MuniraProject@gmail.com", "Munira!23");
                MailMessage msgobj = new MailMessage();
                msgobj.To.Add(txtEmail.Text);
                msgobj.From = new MailAddress("MuniraProject@gmail.com");
                msgobj.Subject = subject.Text;
                msgobj.Body = message.Text;
                client.Send(msgobj);
                Response.Write("Message has been sent!");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Message has been sent');", true);
            }
            catch (Exception ex)
            {
                Response.Write("Couldn't send email" + ex.Message);
            }

            lblOutput.Text = "Trainer has been inserted successfully"; }
        else
        { lblOutput.Text = "There was a problem inserting the trainer."; }
        getTrainerInfo();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;

        //cmd.CommandText = "insert into trainer values('" + name.Text + "','" + email.Text + "')";
        //cmd.ExecuteNonQuery();
        //Label1.Text = "Trainer has been inserted successfully";
        //try
        //{

        //    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //    client.EnableSsl =true;
        //    client.DeliveryMethod =SmtpDeliveryMethod.Network;
        //    client.UseDefaultCredentials = false;
        //    client.Credentials = new NetworkCredential("MuniraProject@gmail.com","Munira!23");
        //    MailMessage msgobj = new MailMessage();
        //    msgobj.To.Add(email.Text);
        //    msgobj.From = new MailAddress("MuniraProject@gmail.com");
        //    msgobj.Subject = subject.Text;
        //    msgobj.Body = message.Text;
        //    client.Send(msgobj);
        //    //Response.Write("Message has been sent!");
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Message has been sent');", true);
        //}
        //catch(Exception ex)
        //{
        //    Response.Write("Couldn't send email" + ex.Message);
        //}
        //name.Text = "";
        //email.Text = "";
    }

    protected void getTrainerInfo()
    {
         CRUD myCrud = new CRUD();
        string mySql = @"  select * 
                        from trainer  ";
        SqlDataReader dr = myCrud.getDrPassSql(mySql);
        gvTrainer.DataSource = dr;
        gvTrainer.DataBind();

    }
    protected void view_Click(object sender, EventArgs e)
    {
        getTrainerInfo();
     
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select * from trainer";
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
        string mySql = @" delete trainer
                            where trainerId = @trainerId ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@trainerId", txtTrainerId.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "Sucess"; }
        else
        { lblOutput.Text = "Failed"; }
        getTrainerInfo();
        //SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM trainer WHERE ([trainerID] = @user)", con);
        //SqlCommand check2 = new SqlCommand("SELECT COUNT(*) FROM trainer_courses WHERE ([trainerID] = @trainer)", con);
        //check.Parameters.AddWithValue("@user", txtTrainerId.Text);
        //check2.Parameters.AddWithValue("@trainer", txtTrainerId.Text);
        //int CheckExist = (int)check.ExecuteScalar();
        //int CheckExist2 = (int)check2.ExecuteScalar();
        //if (CheckExist > 0)
        //{
        //    if (CheckExist2 > 0)
        //    {
        //        Label1.Text = "This trainer has some courses to teach. To be able to delete him/her, Please delete their relationship with the courses first.";
        //    }
        //    else { 
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "delete from trainer where trainerID='" + txtTrainerId.Text + "'";
        //    cmd.ExecuteNonQuery();
        //    Label1.Text = "Trainer has been deleted successfully";
        //    txtTrainerId.Text = "";
        //    txtName.Text = "";
        //    txtEmail.Text = "";
        //    }
        //}
        //else
        //{
        //    Label1.Text = "Please enter valid trainer id.";
        //}
    }

    protected void update_Click(object sender, EventArgs e)
    {
        CRUD myCrud = new CRUD();
        string mySql = @" update trainer set name =@name, email= @email
                            where trainerId = @trainerId ";
        Dictionary<string, object> myPara = new Dictionary<string, object>();
        myPara.Add("@name", txtName.Text);
        myPara.Add("@email", txtEmail.Text);
        myPara.Add("@trainerId", txtTrainerId.Text);
        int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
        if (rtn >= 1)
        { lblOutput.Text = "Sucess"; }
        else
        { lblOutput.Text = "Failed"; }
        getTrainerInfo();
        //SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM trainer WHERE ([trainerID] = @user)", con);
        //check.Parameters.AddWithValue("@user", txtTrainerId.Text);
        //int CheckExist = (int)check.ExecuteScalar();

        //if (CheckExist > 0)
        //{
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "update trainer set name='" + txtName.Text + "', email='" + txtEmail.Text + "' where trainerID='" + txtTrainerId.Text + "'";
        //    cmd.ExecuteNonQuery();
        //    Label1.Text = "Trainer has been updated successfully";
        //    txtTrainerId.Text = "";
        //    txtName.Text = "";
        //    txtEmail.Text = "";
        //}
        //else
        //{
        //    Label1.Text = "Please enter valid trainer id.";
        //}
    }
}