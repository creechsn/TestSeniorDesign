﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NeutralNews.Pages
{
  public class ContactModel : PageModel
  {
    public string Message { get; set; }

    public void OnGet()
    {
      Message = "Questions or Concerns?";
    }

        protected void SendMail()
        {

        //    // 
        //    var UserInformation = Request.Form["QuestionsConcerns"];

        //    // Gmail Address from where you send the mail
        //    var fromAddress = "Gmail@gmail.com";

        //    // any address where the email will be sending
        //    var toAddress = Request.Form["UserEmail"];

        //    //Password of your gmail address
        //    const string fromPassword = "Password";
        //    // Passing the values and make a email formate to display
        //    string userInfo = UserInformation.ToString();
        //    string body = "From: " + YourName.Text + "\n";
        //    body += "Email: " + YourEmail.Text + "\n";
        //    body += "Subject: " + YourSubject.Text + "\n";
        //    body += "Question: \n" + Comments.Text + "\n";
        //    // smtp settings
        //    var smtp = new System.Net.Mail.SmtpClient();
        //    {
        //        smtp.Host = "smtp.gmail.com";
        //        smtp.Port = 587;
        //        smtp.EnableSsl = true;
        //        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
        //        smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
        //        smtp.Timeout = 20000;
        //    }
        //    // Passing values to smtp object
        //    smtp.Send(fromAddress, toAddress, userInfo, body);
        }


        protected void Submit(object sender, EventArgs e)
        {

            try
            {
                
                ////here on button click what will done 
                //SendMail();
                //DisplayMessage.Text = "Your Comments after sending the mail";
                //DisplayMessage.Visible = true;
                //YourSubject.Text = "";
                //YourEmail.Text = "";
                //YourName.Text = "";
                //Comments.Text = "";
            }
            catch (Exception) { }
        }
    }
}
