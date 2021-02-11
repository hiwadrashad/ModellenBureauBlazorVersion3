using Data.Models;
using Logic.DAL;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;


#nullable enable

namespace Logic.GeneralFunctions
{
    public class ControllerLogic <T> : ControllerBase
    {

        IDataRepository _dataService = MockingRepository.GetMockDataService();

        public IEnumerable<T>? Get()
        {
            if (typeof(T) == typeof(AdminModel))
            {
                return (IEnumerable<T>)_dataService.ReturnAllAdmins();
            }
            if (typeof(T) == typeof(ClientModel))
            {
                return (IEnumerable<T>)_dataService.ReturnAllClients();
            }
            if (typeof(T) == typeof(EventModel))
            {
                return (IEnumerable<T>)_dataService.ReturnAllEvents();
            }
            if (typeof(T) == typeof(FemaleModelModel))
            {
                return (IEnumerable<T>)_dataService.ReturnFemaleModels();
            }
            if (typeof(T) == typeof(MaleModeModel))
            {
                return (IEnumerable<T>)_dataService.ReturnMaleModels();
            }
            else return null;
           
        }

        AdminModel GetAdminById(string id)
        {
            return _dataService.ReturnAdmin(id);

        }

        public IActionResult CreateAdmin([FromBody] AdminModel model)
        {
            if (model == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Created("admin", _dataService.AddAdminReturnType(model));
        }

        public IActionResult UpdateAdmin([FromBody] AdminModel model)
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

        public IActionResult DeleteAdmin(string id)
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
#nullable disable
