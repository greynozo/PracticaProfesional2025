using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Configuration;
using System.Net;

namespace PracticaProfesional2025
{
    public class ClaseMail
    {
        public static string mail_From = ConfigurationManager.AppSettings["From"];
        public static string mail_Reply = ConfigurationManager.AppSettings["Reply"];
        public static string mail_BCC = ConfigurationManager.AppSettings["BCC"];
        public static string mail_Pass = ConfigurationManager.AppSettings["Pass"];

        public static string mail_Smtp = ConfigurationManager.AppSettings["SmtpServer"];
        public static string mail_Puerto = ConfigurationManager.AppSettings["Puerto"];
        public static string mail_TimeOut = ConfigurationManager.AppSettings["TimeOut"];
        public static string mail_EnableSSL = ConfigurationManager.AppSettings["EnableSSL"];


        public static bool enviarMail(string cuerpo, string mail, string asunto)
        {
            try
            {
                //string[] imgAdjuntas;

                MailMessage correo = new MailMessage();
                SmtpClient envio = new SmtpClient();

                correo.Body = cuerpo;
                correo.IsBodyHtml = true;
                correo.Subject = asunto;

                correo.To.Add(mail);

                //Agrego copia CC
                if (mail_BCC != "")
                    correo.Bcc.Add(mail_BCC);

                correo.From = new MailAddress(mail_From);

                correo.ReplyToList.Add(mail_Reply);

                using (var client = new SmtpClient(mail_Smtp, int.Parse(mail_Puerto)))
                {
                    client.Credentials = new NetworkCredential(mail_From, mail_Pass);
                    client.EnableSsl = bool.Parse(mail_EnableSSL);
                    client.Send(correo);
                }

                correo.To.Clear();

                //cLog.log.Debug("cMail (enviarMail): " + String.Format("Estudio enviado: Paciente {0}, Mail: {1}, Estudio: {2} ", paciente, mail, puerta + orden));

                return true;
            }
            catch (Exception ex)
            {
                //cLog.log.Error("cMail (enviarMail): " + ex.ToString());
                return false;
            }

        }
    }
}