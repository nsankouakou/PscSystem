using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PscApi.IServices;

namespace PscApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransfertController : ControllerBase
    {
        private ITransfertService _service { get; set; }
        private ILoggerManager _logger { get; set; }

        public TransfertController(ILoggerManager logger, ITransfertService service)
        {
            _logger = logger;
            _service = service;
        }


        [HttpPost("AddTransfertProduit")]
        public  IActionResult AddTransfertProduit(TransfertDto value)
        {
            return Ok( _service.AddTransfertProduit(value));
        }

        [HttpPost("AddEnvoiProduit")]
        public IActionResult AddEnvoiProduit(TransfertDto value)
        {
            return Ok(_service.AddTransfertProduit(value));
        }
    }
}