using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces
{
    public interface IDataRepository
    {
        bool AddAdmin(AdminModel model);
        bool AddClient(ClientModel model);
        bool AddEvent(EventModel model);
        bool AddFemaleModel(FemaleModelModel model);
        AdminModel AddAdminReturnType(AdminModel model);
        ClientModel AddClientReturnType(ClientModel model);
        EventModel AddEventReturnType(EventModel model);
        FemaleModelModel AddFemaleModelReturnType(FemaleModelModel model);
        MaleModeModel AddMaleModelReturnType(MaleModeModel model);
        bool AddMaleModel(MaleModeModel model);
        bool RemoveAdmin(AdminModel model);
        bool RemoveClient(ClientModel model);
        bool RemoveEvent(EventModel model);
        bool RemoveFemaleModel(FemaleModelModel model);
        bool RemoveMaleModel(MaleModeModel model);
        List<AdminModel> ReturnAllAdmins();
        List<ClientModel> ReturnAllClients();
        List<EventModel> ReturnAllEvents();
        List<FemaleModelModel> ReturnFemaleModels();
        List<MaleModeModel> ReturnMaleModels();
        AdminModel ReturnAdmin(string id);
        ClientModel ReturnClient(string id);
        EventModel ReturnEvent(string id);
        FemaleModelModel ReturnFemaleModel(string id);
        MaleModeModel ReturnMaleModel(string id);
        bool UpdateAdmin(AdminModel model);
        bool UpdateClient(ClientModel model);
        bool UpdateEvent(EventModel model);
        bool UpdateFemaleModel(FemaleModelModel model);
        bool UpdateMaleModel(MaleModeModel model);

    }
}
