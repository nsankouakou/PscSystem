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
    public class ParametresController : ControllerBase
    {
        private IParametreService _service { get; set; }
        private ILoggerManager _logger { get; set; }

        public ParametresController(ILoggerManager logger, IParametreService iConfigurationService)
        {
            _logger = logger;
            _service = iConfigurationService;

        }

        #region TypeProduit


        [HttpGet("GetALLTypeProduit")]
        public async Task<IActionResult> GetALLTypeProduit(string token)
        {

            return Ok(await _service.GetAllTypeProduit(token));
        }


        [HttpGet("GeTypeProduitUnique")]
        public async Task<IActionResult> GeTypeProduitUnique(int id, string token)
        {

            return Ok(await _service.GetTypeProduit(id, token));
        }

        [HttpGet("GeTypeProduitFiltre")]
        public async Task<IActionResult> GeTypeProduit(int id, string token)
        {

            return Ok(await _service.GetTypeProduit(id, token));
        }


        [HttpPost("InserTypeProduit")]
        public async Task<IActionResult> InserTypeProduit(TypeProduitDto value)
        {

            return Ok(await _service.InsertTypeProduit(value));
        }



        [HttpPost("InsertLisTypeProduit")]
        public async Task<IActionResult> InsertLisTypeProduit(List<TypeProduitDto> values)
        {
            return Ok(await InsertLisTypeProduit(values));
        }



        [HttpPost("MajTypeProduit")]
        public IActionResult MajTypeProduit(TypeProduitDto value)
        {

            return Ok(_service.MajTypeProduit(value));
        }




        [HttpPost("DeleteTypeProduit")]
        public IActionResult DeleteTypeProduit(TypeProduitDto value)
        {
            return Ok(_service.DeleteTypeProduit(value));
        }


        #endregion

    }
}