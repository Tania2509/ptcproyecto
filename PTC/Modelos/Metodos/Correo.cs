using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Modelos.Metodos
{
    public class Correo
    {
        public static void EnviarToken(string destino, string token)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("dentalcleanverificacion@gmail.com");
            mail.To.Add(destino);
            mail.Subject = "Recuperación de contraseña";
            mail.Body = $"Tu código de recuperación es: {token}\nEste código expirará en 1 minuto.";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("dentalcleanverificacion@gmail.com", "kplv shrw jbfo itfu ");
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}
