using EmailService.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSenderController : ControllerBase
    {
        private readonly ILogger<EmailSenderController> _logger;

        public EmailSenderController(ILogger<EmailSenderController> logger)
        {
            _logger = logger;
        }
        // POST api/<EmailSenderController>
        [HttpPost("send")]
        public void Post([FromBody] EmailServiceMessage message)
        {
            _logger.LogInformation("Email was sended to: {EmailTo}, with text {Message}", message.EmailTo, message.MessageBody);
        }
    }
}
