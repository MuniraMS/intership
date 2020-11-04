using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

/// <summary>
/// Summary description for mailMgr
/// </summary>
public class mailMgr
{
    public mailMgr()
    {
        //
        // TODO: Add constructor logic here
        //
    }

   public void sendMail(string from, string to, string subject,string body)
    {
        //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //client.EnableSsl = true;
        //client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //client.UseDefaultCredentials = false;
        //client.Credentials = new NetworkCredential("MuniraProject@gmail.com", "Munira!23");
        //MailMessage msgobj = new MailMessage();
        //msgobj.To.Add(txtEmail.Text);
        //msgobj.From = new MailAddress("MuniraProject@gmail.com");
        //msgobj.Subject = subject.Text;
        //msgobj.Body = message.Text;
        //client.Send(msgobj);


    }
}