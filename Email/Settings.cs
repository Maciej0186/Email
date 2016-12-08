using System.Net.Mail;
using System;

namespace Email
{
    class Settings
    {
        public Settings()
        {
            Run();
        }

        public bool Run()
        {
            SmtpClient client = new SmtpClient("smtp.wp.pl");
            MailMessage message = new MailMessage("mymailer@wp.pl","swierczynski.maciej@wp.pl");
            message.Subject = "temat";
            message.Body = "treść";
            client.Credentials = new System.Net.NetworkCredential("mymailer@wp.pl", "mail8686");

            try
            {
                client.Send(message);
                Console.Write("Wiadomość wysłana!");
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            
            return true;
        }

        public void DosentRun()
        { }

        public void SomeMethod()
        { }

    }
}
