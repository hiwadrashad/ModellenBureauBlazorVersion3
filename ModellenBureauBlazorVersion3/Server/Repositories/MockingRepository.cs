using Data.Models;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.DAL
{
    public class MockingRepository : IDataRepository
    {
        private List<AdminModel> _admins { get; set; }
        private List<ClientModel> _clients { get; set; }
        private List<EventModel> _events { get; set; }
        private List<FemaleModelModel> _femaleModels { get; set; }
        private List<MaleModeModel> _maleModels { get; set; }

        private static MockingRepository _MockingdataService;

        private MockingRepository()
        {

        }

        public static MockingRepository GetMockDataService()
        {
            if (_MockingdataService == null)
            {
                _MockingdataService = new MockingRepository();
                _MockingdataService.InitData();
            }
            return _MockingdataService;
        }

        public void InitData()
        {
            _admins = new List<AdminModel>()
            {
            new AdminModel()
            {
             id = Guid.NewGuid().ToString(),
             Password = "adminpassword",
             Username = "adminusername"
            },
                  new AdminModel()
            {
             id = Guid.NewGuid().ToString(),
             Password = "adminpassword2",
             Username = "adminusername2"
            }
            };

            _clients = new List<ClientModel>()
            {
            new ClientModel()
            {
             id = Guid.NewGuid().ToString(),
             BTWNumber = "12345",
             data = new NAWDataModel()
             {
              Age = 22,
              City = "New york",
              EmailAdress = "test@hotmail.com",
              FirstName = "test",
              LastName = "test",
              PostalCode = "test",
              StreetName = "test",
              StreetNumber = "test",
              TelephoneNumber = "067884756"
             },
             Events = new List<EventModel>()
             {
             new EventModel()
             {
              Public = true,
              id = Guid.NewGuid().ToString()
             }
             }
             , Invited = true,
              KVKNumber = "12342341",
             Password = "clientpassword",
             UserName = "clientusername"
            },
                   new ClientModel()
            {
             id = Guid.NewGuid().ToString(),
             BTWNumber = "12345",
             data = new NAWDataModel()
             {
              Age = 22,
              City = "New york",
              EmailAdress = "test@hotmail.com",
              FirstName = "test",
              LastName = "test",
              PostalCode = "test",
              StreetName = "test",
              StreetNumber = "test",
              TelephoneNumber = "067884756"
             },
             Events = new List<EventModel>()
             {
             new EventModel()
             {
              Public = true,
              id = Guid.NewGuid().ToString()
             }
             }
             , Invited = true,
              KVKNumber = "12342341",
             Password = "clientpassword2",
             UserName = "clientusername2"
            }
            };

            _events = new List<EventModel>()
            {
             new EventModel()
             {
              id = Guid.NewGuid().ToString(),
              FemaleModels = new List<FemaleModelModel>()
              {
               new FemaleModelModel()
               {
                id = Guid.NewGuid().ToString(),
                Invited = true,
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred
                },
                Measurements = new FemaleMeasurementsModel()
                {
                 backlength = Data.Enums.Female.BackLength.fourtyonepointeight,
                 cutwidth = Data.Enums.Female.CutWidth.eightyfive,
                 hipwidth = Data.Enums.Female.HipWidth.ninetyeight,
                 sittingheight = Data.Enums.Female.SittingHeight.thirty,
                 sleevelength = Data.Enums.Female.SleeveLength.eightyonepointfive,
                 upperarmwidth = Data.Enums.Female.UpperArmWidth.thirty,
                 upperwidth = Data.Enums.Female.UpperWidth.eightyseven

                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "Utrecht",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "tets",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "tets",
                  TelephoneNumber = "06765876568"
                 },
                 Password = "femalepassword5",
                 previousevents = new List<EventModel>()
                 {
                  new EventModel()
                  {
                   id = Guid.NewGuid().ToString(),
                   Public = true,
                  }
                 },
                 Username = "femaleusername5"
               }
              }
             },
              new EventModel()
             {
              id = Guid.NewGuid().ToString(),
              Public = true,
              Organizer = new ClientModel()
                  {
             id = Guid.NewGuid().ToString(),
             BTWNumber = "12345",
             data = new NAWDataModel()
             {
              Age = 22,
              City = "New york",
              EmailAdress = "test@hotmail.com",
              FirstName = "test",
              LastName = "test",
              PostalCode = "test",
              StreetName = "test",
              StreetNumber = "test",
              TelephoneNumber = "067884756"
             },
             Events = new List<EventModel>()
             {
             new EventModel()
             {
              Public = true,
              id = Guid.NewGuid().ToString()
             }
             }
             , Invited = true,
              KVKNumber = "12342341",
             Password = "clientpassword3",
             UserName = "clientusername3"
            },
              MaleModels = new List<MaleModeModel>()
              { 
               new MaleModeModel() {
                id = Guid.NewGuid().ToString(),
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred,
                }
                , Invited = true,
                Measurements = new MaleMeasurementsModel()
                {
                 backlength = Data.Enums.Male.BackLength.fourtyseven,
                 cutwidth = Data.Enums.Male.CutWidth.eightyeight,
                 hipwidth = Data.Enums.Male.HipWidth.ninetyeight,
                 upperwidth = Data.Enums.Male.UpperWidth.ninetysix
                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "test",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "test",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "test",
                  TelephoneNumber = "0676575675"
                 }
                 ,
                 Password = "malepassword4",
                 previousevents = new List<EventModel>()
                 {
                 new EventModel()
                 {
                  id = Guid.NewGuid().ToString(),
                  Public = true
                 }
                 },
                 Username = "malepassword4"
               },
                  new MaleModeModel() {
                id = Guid.NewGuid().ToString(),
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred,
                }
                , Invited = true,
                Measurements = new MaleMeasurementsModel()
                {
                 backlength = Data.Enums.Male.BackLength.fourtyseven,
                 cutwidth = Data.Enums.Male.CutWidth.eightyeight,
                 hipwidth = Data.Enums.Male.HipWidth.ninetyeight,
                 upperwidth = Data.Enums.Male.UpperWidth.ninetysix
                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "test",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "test",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "test",
                  TelephoneNumber = "0676575675"
                 }
                 ,
                 Password = "malepassword5",
                 previousevents = new List<EventModel>()
                 {
                 new EventModel()
                 {
                  id = Guid.NewGuid().ToString(),
                  Public = true
                 }
                 },
                 Username = "malepassword5"
               }
              },
              FemaleModels = new List<FemaleModelModel>()
              {
               new FemaleModelModel()
               {
                id = Guid.NewGuid().ToString(),
                Invited = true,
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred
                },
                Measurements = new FemaleMeasurementsModel()
                {
                 backlength = Data.Enums.Female.BackLength.fourtyonepointeight,
                 cutwidth = Data.Enums.Female.CutWidth.eightyfive,
                 hipwidth = Data.Enums.Female.HipWidth.ninetyeight,
                 sittingheight = Data.Enums.Female.SittingHeight.thirty,
                 sleevelength = Data.Enums.Female.SleeveLength.eightyonepointfive,
                 upperarmwidth = Data.Enums.Female.UpperArmWidth.thirty,
                 upperwidth = Data.Enums.Female.UpperWidth.eightyseven

                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "Utrecht",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "tets",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "tets",
                  TelephoneNumber = "06765876568"
                 },
                 Password = "femalepassword3",
                 previousevents = new List<EventModel>()
                 {
                  new EventModel()
                  {
                   id = Guid.NewGuid().ToString(),
                   Public = true,
                  }
                 },
                 Username = "femaleusername3"
               },
                new FemaleModelModel()
               {
                id = Guid.NewGuid().ToString(),
                Invited = true,
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred
                },
                Measurements = new FemaleMeasurementsModel()
                {
                 backlength = Data.Enums.Female.BackLength.fourtyonepointeight,
                 cutwidth = Data.Enums.Female.CutWidth.eightyfive,
                 hipwidth = Data.Enums.Female.HipWidth.ninetyeight,
                 sittingheight = Data.Enums.Female.SittingHeight.thirty,
                 sleevelength = Data.Enums.Female.SleeveLength.eightyonepointfive,
                 upperarmwidth = Data.Enums.Female.UpperArmWidth.thirty,
                 upperwidth = Data.Enums.Female.UpperWidth.eightyseven

                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "Utrecht",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "tets",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "tets",
                  TelephoneNumber = "06765876568"
                 },
                 Password = "femalepassword4",
                 previousevents = new List<EventModel>()
                 {
                  new EventModel()
                  {
                   id = Guid.NewGuid().ToString(),
                   Public = true,
                  }
                 },
                 Username = "femaleusername4"
               }
              }
             }
            };

            _femaleModels = new List<FemaleModelModel>()
            {
                new FemaleModelModel()
               {
                id = Guid.NewGuid().ToString(),
                Invited = true,
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred
                },
                Measurements = new FemaleMeasurementsModel()
                {
                 backlength = Data.Enums.Female.BackLength.fourtyonepointeight,
                 cutwidth = Data.Enums.Female.CutWidth.eightyfive,
                 hipwidth = Data.Enums.Female.HipWidth.ninetyeight,
                 sittingheight = Data.Enums.Female.SittingHeight.thirty,
                 sleevelength = Data.Enums.Female.SleeveLength.eightyonepointfive,
                 upperarmwidth = Data.Enums.Female.UpperArmWidth.thirty,
                 upperwidth = Data.Enums.Female.UpperWidth.eightyseven

                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "Utrecht",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "tets",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "tets",
                  TelephoneNumber = "06765876568"
                 },
                 Password = "femalepassword",
                 previousevents = new List<EventModel>()
                 {
                  new EventModel()
                  {
                   id = Guid.NewGuid().ToString(),
                   Public = true,
                  }
                 },
                 Username = "femaleusername"
               },
                 new FemaleModelModel()
               {
                id = Guid.NewGuid().ToString(),
                Invited = true,
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred
                },
                Measurements = new FemaleMeasurementsModel()
                {
                 backlength = Data.Enums.Female.BackLength.fourtyonepointeight,
                 cutwidth = Data.Enums.Female.CutWidth.eightyfive,
                 hipwidth = Data.Enums.Female.HipWidth.ninetyeight,
                 sittingheight = Data.Enums.Female.SittingHeight.thirty,
                 sleevelength = Data.Enums.Female.SleeveLength.eightyonepointfive,
                 upperarmwidth = Data.Enums.Female.UpperArmWidth.thirty,
                 upperwidth = Data.Enums.Female.UpperWidth.eightyseven

                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "Utrecht",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "tets",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "tets",
                  TelephoneNumber = "06765876568"
                 },
                 Password = "femalepassword2",
                 previousevents = new List<EventModel>()
                 {
                  new EventModel()
                  {
                   id = Guid.NewGuid().ToString(),
                   Public = true,
                  }
                 },
                 Username = "femaleusername2"
               }
            };

            _maleModels = new List<MaleModeModel>()
            {
               new MaleModeModel()
               {
                id = Guid.NewGuid().ToString(),
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred,
                }
                , Invited = true,
                Measurements = new MaleMeasurementsModel()
                {
                 backlength = Data.Enums.Male.BackLength.fourtyseven,
                 cutwidth = Data.Enums.Male.CutWidth.eightyeight,
                 hipwidth = Data.Enums.Male.HipWidth.ninetyeight,
                 upperwidth = Data.Enums.Male.UpperWidth.ninetysix
                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "test",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "test",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "test",
                  TelephoneNumber = "0676575675"
                 }
                 ,
                 Password = "malepassword",
                 previousevents = new List<EventModel>()
                 {
                 new EventModel()
                 {
                  id = Guid.NewGuid().ToString(),
                  Public = true
                 }
                 },
                 Username = "maleusername"
               },
               new MaleModeModel()
               {
                id = Guid.NewGuid().ToString(),
                biodata = new BioDataModel()
                {
                 eyecolor = Data.Enums.BioMarker.EyeColor.blue,
                 haircolor = Data.Enums.BioMarker.HairColor.black,
                 height = Data.Enums.BioMarker.Height.abovetwohundred,
                }
                , Invited = true,
                Measurements = new MaleMeasurementsModel()
                {
                 backlength = Data.Enums.Male.BackLength.fourtyseven,
                 cutwidth = Data.Enums.Male.CutWidth.eightyeight,
                 hipwidth = Data.Enums.Male.HipWidth.ninetyeight,
                 upperwidth = Data.Enums.Male.UpperWidth.ninetysix
                }
                ,
                 NAWData = new NAWDataModel()
                 {
                  Age = 21,
                  City = "test",
                  EmailAdress = "test@hotmail.com",
                  FirstName = "test",
                  LastName = "test",
                  PostalCode = "test",
                  StreetName = "tets",
                  StreetNumber = "test",
                  TelephoneNumber = "0676575675"
                 }
                 ,
                 Password = "malepassword2",
                 previousevents = new List<EventModel>()
                 {
                 new EventModel()
                 {
                  id = Guid.NewGuid().ToString(),
                  Public = true
                 }
                 },
                 Username = "maleusername2"
               }
            };
        }

        public bool AddAdmin(AdminModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _admins.Add(model);
            return true;
        }

        public bool AddClient(ClientModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _clients.Add(model);
            return true;
        }

        public bool AddEvent(EventModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _events.Add(model);
            return true;
        }

        public bool AddFemaleModel(FemaleModelModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _femaleModels.Add(model);
            return true;
        }

        public bool AddMaleModel(MaleModeModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _maleModels.Add(model);
            return true;
        }

        public AdminModel AddAdminReturnType(AdminModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _admins.Add(model);
            return model;
        }

        public ClientModel AddClientReturnType(ClientModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _clients.Add(model);
            return model;
        }

        public EventModel AddEventReturnType(EventModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _events.Add(model);
            return model;
        }

        public FemaleModelModel AddFemaleModelReturnType(FemaleModelModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _femaleModels.Add(model);
            return model;
        }

        public MaleModeModel AddMaleModelReturnType(MaleModeModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _maleModels.Add(model);
            return model;
        }

        public bool RemoveAdmin(AdminModel model)
        {
            _admins.Remove(model);
            return true;
        }

        public bool RemoveClient(ClientModel model)
        {
            _clients.Remove(model);
            return true;
        }

        public bool RemoveEvent(EventModel model)
        {
            _events.Remove(model);
            return true;
        }

        public bool RemoveFemaleModel(FemaleModelModel model)
        {
            _femaleModels.Remove(model);
            return true;
        }

        public bool RemoveMaleModel(MaleModeModel model)
        {
            _maleModels.Remove(model);
            return true;
        }

        public List<AdminModel> ReturnAllAdmins()
        {
            return _admins;
        }

        public List<ClientModel> ReturnAllClients()
        {
            return _clients;
        }

        public List<EventModel> ReturnAllEvents()
        {
            return _events;
        }

        public List<FemaleModelModel> ReturnFemaleModels()
        {
            return _femaleModels;
        }

        public List<MaleModeModel> ReturnMaleModels()
        {
            return _maleModels;
        }

        public AdminModel ReturnAdmin(string id)
        {
            return _admins.Where(a => a.id == id).FirstOrDefault();
        }

        public ClientModel ReturnClient(string id)
        {
            return _clients.Where(a => a.id == id).FirstOrDefault();
        }

        public EventModel ReturnEvent(string id)
        {
            return _events.Where(a => a.id == id).FirstOrDefault();
        }

        public FemaleModelModel ReturnFemaleModel(string id)
        {
            return _femaleModels.Where(a => a.id == id).FirstOrDefault();
        }

        public MaleModeModel ReturnMaleModel(string id)
        {
            return _maleModels.Where(a => a.id == id).FirstOrDefault();
        }

        public bool UpdateAdmin(AdminModel model)
        {
            var item = _admins.Where(a => a.id == model.id).FirstOrDefault();
            item = model;
            return true;
        }

        public bool UpdateClient(ClientModel model)
        {
            var item = _clients.Where(a => a.id == model.id).FirstOrDefault();
            item = model;
            return true;
        }

        public bool UpdateEvent(EventModel model)
        {
            var item = _events.Where(a => a.id == model.id).FirstOrDefault();
            item = model;
            return true;
        }

        public bool UpdateFemaleModel(FemaleModelModel model)
        {
            var item = _femaleModels.Where(a => a.id == model.id).FirstOrDefault();
            item = model;
            return true;
        }

        public bool UpdateMaleModel(MaleModeModel model)
        {
            var item = _maleModels.Where(a => a.id == model.id).FirstOrDefault();
            item = model;
            return true;
        }
    }
}
