using Microsoft.AspNetCore.Mvc;
using PostgreDapperSample.Models;
using PostgreDapperSample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreDapperSample.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientRepository clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Client client)
        {
            clientRepository.Create(client);
            return Ok();
        }

        [HttpGet]
        public IActionResult List()
        {
            var Clients = clientRepository.List();
            return Ok(Clients);
        }
    }
}
