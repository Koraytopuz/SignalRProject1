using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.MailDtos;
using System.Net.Mail;

namespace SignalRWebUI.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(CreateMailDto createMailDto)
        //{
        //    MimeMessage mimeMessage = new MimeMessage();

        //    MailboxAddress mailboxAddressFrom = new MailboxAddress("Burgerland Rezervasyon", "krytopuz@gmail.com");
        //    mimeMessage.From.Add(mailboxAddressFrom);

        //    MailboxAddress mailboxAddressTo = new MailboxAddress("User", createMailDto.ReceiverMail);
        //    mimeMessage.To.Add(mailboxAddressTo);

        //    var bodyBuilder = new BodyBuilder();
        //    bodyBuilder.TextBody = createMailDto.Body; ;
        //    mimeMessage.Body = bodyBuilder.ToMessageBody();

        //    mimeMessage.Subject = createMailDto.Subject;

        //    SmtpClient client = new SmtpClient();
        //    client.Connect("smtp.gmail.com", 587, false);
        //    client.Authenticate("krytopuz@gmail.com", "itcs zbby vbzk uugm");

        //    client.Send(mimeMessage);
        //    client.Disconnect(true);

        //    return RedirectToAction("Index", "Category");
        //}
    }
    }

