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
    public class EventsController : ControllerBase
    {
        IDataRepository _dataService = MockingRepository.GetMockDataService();

        [HttpGet]

        public IEnumerable<EventModel> Get()
        {
            return _dataService.ReturnAllEvents();
        }

        [HttpGet("{id}")]

        EventModel Get(string id)
        {
            return _dataService.ReturnEvent(id);

        }

        [HttpPost]
        public IActionResult Post([FromBody] EventModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Created("event", _dataService.AddEventReturnType(model));
        }

        [HttpPut]
        public IActionResult Put([FromBody] EventModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var item = _dataService.ReturnEvent(model.id);

            if (item == null)
                return NotFound();

            _dataService.UpdateEvent(model);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id == null)
                return BadRequest();

            var item = _dataService.ReturnEvent(id);
            if (item == null)
                return NotFound();

            _dataService.RemoveEvent(item);

            return NoContent();//success
        }
    }
}
