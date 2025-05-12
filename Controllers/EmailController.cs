using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using System.Net.Mail;

namespace MemberApp_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : Controller
    {
        [HttpGet]
        public IActionResult Get() => Ok("Hello from API");

        [HttpPost]
        public IActionResult SendEmail(string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("river.legros69@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("river.legros69@ethereal.email"));
            email.Subject = "Test Email Subject";
            email.Body = new TextPart(TextFormat.Html) {Text=body };


            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("river.legros69@ethereal.email", "K4CGB4QqCCPaTgC8aR");
            smtp.Send(email);
            smtp.Disconnect(true);
            return Ok();
        }
    }
}
/*
 * Name	Kiarra Hodkiewicz
Username	kiarra.hodkiewicz74@ethereal.email – this account can not be used for inbound emails 
Password	j3rbAvQZVJDWdjdbSA
 * 
 *  https://localhost:7206/scalar/v1#
 * 
 * */