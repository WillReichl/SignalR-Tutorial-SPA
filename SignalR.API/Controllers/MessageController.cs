using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace SignalR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IHubContext<NotifyHub, ITypedHubClient> _hubContext;

        public MessageController(IHubContext<NotifyHub, ITypedHubClient> hubContext)
        {
            this._hubContext = hubContext;
        }

        [HttpPost]
        public string Post([FromBody] Message message)
        {
            string returnMessage;
            try
            {
                _hubContext.Clients.All.BroadcastMessage(message.Type, message.Payload);
                returnMessage = "Success";
            }
            catch (Exception ex)
            {
                returnMessage = ex.ToString();
            }
            return returnMessage;
        }
    }
}
