using Quartz;
using System;
using System.Net;
using System.Net.Mail;

namespace WebSchedular.Utiltiy
{
    public class EmailJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                using (DB db=new DB())
                {
                    db.Tests.Add(new Test { CreatedDate = DateTime.Now, Name = "Saurabh " + DateTime.Now.Millisecond });
                    db.SaveChanges();

                }


                //using (var message = new MailMessage("themsteam@gmail.com", "saurabh.ims@hotmail.com"))
                //{
                //    message.Subject = "Test";
                //    message.Body = "Test at " + DateTime.Now;
                //    using (SmtpClient client = new SmtpClient
                //    {
                //        EnableSsl = true,
                //        Host = "smtp.gmail.com",
                //        Port = 587,
                //        Credentials = new NetworkCredential("themsteam@gmail.com", "XXXXXXXXXXXXX")
                //    })
                //    {
                //        client.Send(message);
                //    }
            }
            catch (Exception ex)
            {

            }
        }
    }
}