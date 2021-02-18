using Data.Models;
using Logic.DAL;
using Logic.Interfaces;
using Logic.StaticResources;
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
    public class MaleModelController : ControllerBase
    {
        IDataRepository _dataService = MockingRepository.GetMockDataService();

        [HttpGet]

        public IEnumerable<MaleModeModel> Get()
        {
            return _dataService.ReturnMaleModels();
        }

        [HttpGet("{id}")]

        MaleModeModel Get(string id)
        {
            return _dataService.ReturnMaleModel(id);

        }

        [HttpPost]
        public IActionResult Post([FromBody] MaleModeModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            model.Image = GeneralStaticdata.chosenimage;
            model.imagepath = GeneralStaticdata.ImagePath;
            GeneralStaticdata.chosenimage = null;
            GeneralStaticdata.ImagePath = null;
            return Created("event", _dataService.AddMaleModelReturnType(model));
        }

        [HttpPut]
        public IActionResult Put([FromBody] MaleModeModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var item = _dataService.ReturnMaleModel(model.id);

            if (item == null)
                return NotFound();

            _dataService.UpdateMaleModel(model);

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
