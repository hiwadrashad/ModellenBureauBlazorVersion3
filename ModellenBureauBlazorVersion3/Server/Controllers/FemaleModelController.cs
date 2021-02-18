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
    public class FemaleModelController : ControllerBase
    {
        IDataRepository _dataService = MockingRepository.GetMockDataService();

        [HttpGet]

        public IEnumerable<FemaleModelModel> Get()
        {
            return _dataService.ReturnFemaleModels();
        }

        [HttpGet("{id}")]

        FemaleModelModel Get(string id)
        {
            return _dataService.ReturnFemaleModel(id);

        }

        [HttpPost]
        public IActionResult Post([FromBody] FemaleModelModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            model.Image = GeneralStaticdata.chosenimage;
            model.imagepath = GeneralStaticdata.ImagePath;
            GeneralStaticdata.chosenimage = null;
            GeneralStaticdata.ImagePath = null;
            return Created("femalemodel", _dataService.AddFemaleModelReturnType(model));
        }

        [HttpPut]
        public IActionResult Put([FromBody] FemaleModelModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var item = _dataService.ReturnFemaleModel(model.id);

            if (item == null)
                return NotFound();

            _dataService.UpdateFemaleModel(model);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id == null)
                return BadRequest();

            var item = _dataService.ReturnFemaleModel(id);
            if (item == null)
                return NotFound();

            _dataService.RemoveFemaleModel(item);

            return NoContent();//success
        }
    }
}
