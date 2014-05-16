using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//sends email to SMTP server to deliver 
using System.Net.Mail;


public class clsBusinessLayer
{
	public clsBusinessLayer()
	{
    }
        public static bool SendEmail (string Sender, string Recipient, string bcc, string cc, string Subject, string Body)
        {
            try
            {
                //creates new MailMessage object
                MailMessage MyMailMessage = new MailMessage();

                //instantiates from function using sender
                MyMailMessage.From = new MailAddress(Sender);

                //instantiates to function by adding recipient 
                MyMailMessage.To.Add(new MailAddress(Recipient));

                //will bcc only iff it is NOT empty or null
                if (bcc != null && bcc != string.Empty)
                {
                    //will add bcc function if not null or empty with passed bcc parameter
                    MyMailMessage.Bcc.Add(new MailAddress(bcc));
                }

                //instantiates subject function with parameter passed for subject
                MyMailMessage.Subject = Subject;

                //instantiates body with passed parameter for body
                MyMailMessage.Body = Body;

                //puts body in html format
                MyMailMessage.IsBodyHtml = true;

                //makes priorty level equal to normal from mailpriority class 
                MyMailMessage.Priority = MailPriority.Normal;

                //creates new smtpclient object 
                SmtpClient MySmtpClient = new SmtpClient();

                //creates port and host IP
                MySmtpClient.Port = 25;
                MySmtpClient.Host = "127.0.0.1";

                //will send myMailMessage object through smtp object 
                MySmtpClient.Send(MyMailMessage);

                //will return true if all try conditions work
                return true;
            }
            catch (Exception ex)
            {
                //will return false if try fails  
                return false;
            }
     }
}
	