using Data.Models;
using Logic.DAL;
using Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModellenBureauBlazorVersion3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        // GET: api/<AdminController>
        IDataRepository _dataService = MockingRepository.GetMockDataService();

        [HttpGet]

        public IActionResult Get()
        {

            return Ok(_dataService.ReturnAllAdmins());
        }

        [HttpGet("{id}")]

        AdminModel Get(string id)
        {
            return _dataService.ReturnAdmin(id);

        }

        [HttpPost]
        public IActionResult Post([FromBody] AdminModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            return Created("admin", _dataService.AddAdminReturnType(model));
        }

        [HttpPut]
        public IActionResult Put([FromBody] AdminModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var item = _dataService.ReturnAdmin(model.id);

            if (item == null)
                return NotFound();

            _dataService.UpdateAdmin(model);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {

            if (id == null)
                return BadRequest();

            var item = _dataService.ReturnAdmin(id);
            if (item == null)
                return NotFound();

            _dataService.RemoveAdmin(item);

            return NoContent();//success
        }
    }
}
