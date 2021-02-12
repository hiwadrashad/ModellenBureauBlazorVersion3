using Data.Models;
using Logic.DAL;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModellenBureauBlazorVersion3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        IDataRepository _dataService = MockingRepository.GetMockDataService();

        [HttpGet]

        public IEnumerable<ClientModel> Get()
        {
            return _dataService.ReturnAllClients();
        }

        [HttpGet("{id}")]

        ClientModel Get(string id)
        {
            return _dataService.ReturnClient(id);

        }

        [HttpPost]
        public IActionResult Post([FromBody] ClientModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Created("client", _dataService.AddClientReturnType(model));
        }

        [HttpPut]
        public IActionResult Put([FromBody] ClientModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var item = _dataService.ReturnClient(model.id);

            if (item == null)
                return NotFound();

            _dataService.UpdateClient(model);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id == null)
                return BadRequest();

            var item = _dataService.ReturnClient(id);
            if (item == null)
                return NotFound();

            _dataService.RemoveClient(item);

            return NoContent();//success
        }
    }
}
