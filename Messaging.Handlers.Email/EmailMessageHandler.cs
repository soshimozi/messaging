using System;
using Messaging.Messages;
using Messaging.Shared;
using System.Net.Mail;
using System.Net.Mime;

namespace Messaging.Handlers.Email
{
    [ExportMessageHandler(MessageTypes = new [] {typeof(EmailMessage)})]
    public class EmailMessageHandler : IMessageHandler
    {
        private static void HandleEmailMessage(EmailMessage message)
        {
            try
            {
                var mailMsg = new MailMessage();

                // To
                mailMsg.To.Add(new MailAddress(message.To.Address, message.To.FullName));

                // From
                mailMsg.From = new MailAddress(message.From.Address, message.From.FullName);

                // Subject and multipart/alternative Body
                mailMsg.Subject = message.Subject;

                mailMsg.AlternateViews.Add(message.BodyType == EmailBodyType.Html
                    ? AlternateView.CreateAlternateViewFromString(message.Body, null, MediaTypeNames.Text.Html)
                    : AlternateView.CreateAlternateViewFromString(message.Body, null, MediaTypeNames.Text.Plain));


                // Init SmtpClient and send
                var smtpClient = new SmtpClient("smtp.sendgrid.net", Convert.ToInt32(587));
                var credentials = new System.Net.NetworkCredential("", "");
                smtpClient.Credentials = credentials;

                smtpClient.Send(mailMsg);
            }
            catch (Exception ex)
            {
            }
        }

        public void Handle(object message)
        {
            HandleEmailMessage(message as EmailMessage);
        }
    }
}
