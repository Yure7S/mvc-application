using System;
using System.IO;
using System.Net.Mail;
using System.Diagnostics;


namespace WebApplication4.Util
{
    public class EnvioEmail
    {
        public static void sendEmail(Usuario user, Denuncia denuncia)
        {

            

            try
            {
                var reader = new StreamReader("C:\\Users\\Servulo\\source\\repos\\WebApplication4\\WebApplication4\\Template Email\\TempEmail.html");
                string EmailBody = reader.ReadToEnd();
                reader.Close();

                EmailBody = EmailBody.Replace("[[user.Nome]]", user.Nome);
                EmailBody = EmailBody.Replace("[[denuncia.Descricao]]", denuncia.Descricao);
       
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("seducouvidoria07@gmail.com", "edvbuzpswbewpoqt");

                MailMessage mail = new MailMessage();
                mail.Sender = new MailAddress("seducouvidoria07@gmail.com", "Ouvidoria");
                mail.From = new MailAddress("seducouvidoria07@gmail.com", user.Nome);
                mail.To.Add(new MailAddress(user.Email, "RECEBEDOR"));
                mail.Subject = "Contato";
                mail.Body = EmailBody;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                client.Send(mail);
                Debug.WriteLine("Enviado");
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}