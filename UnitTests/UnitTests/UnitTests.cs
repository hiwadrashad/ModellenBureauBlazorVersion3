using Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private IAdminDataService adminrepo { get; set; }
        private IClientDataService clientrepo { get; set; }
        private IEventDataService eventrepo { get; set; }
        private IFemaleModelDataService femalerepo { get; set; }
        private IMaleModelDataService malerepo { get; set; }

        public AdminModel adminmodel = new AdminModel()
        {
            id = Guid.NewGuid().ToString(),
            Password = "adminpassword",
            Username = "adminusername"
        };

        public ClientModel clientmodel = new ClientModel()
        {
            id = Guid.NewGuid().ToString(),
            BTWNumber = "test",
            data = new NAWDataModel()
            {
                Age = "test",
                City = "test",
                EmailAdress = "test@hotmail.com",
                FirstName = "test",
                LastName = "test",
                PostalCode = "test",
                StreetName = "test",
                StreetNumber = "test",
                TelephoneNumber = "test"
            },
            Invited = true,
            KVKNumber = "test",
            Password = "testclient",
            UserName = "testclient"

        };

        public EventModel eventmodel = new EventModel()
        {
            id = Guid.NewGuid().ToString(),
            City = "test",
            NameEvent = "test",
            Public = true

        };

        public MaleModeModel malemodel = new MaleModeModel()
        {
            id = Guid.NewGuid().ToString(),
            Invited = true,
            Password = "test",
            Username = "test"
        };


        public FemaleModelModel femalemodel = new FemaleModelModel()
        {
            id = Guid.NewGuid().ToString(),
            Invited = true,
            Password = "test",
            Username = "test"
        };

        public void AdminDependencyInjection()
        {
            if (adminrepo == null)
            {
                var services = new ServiceCollection();
                services.AddHttpClient<IAdminDataService, AdminDataService>(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:44393/");
                });

                var serviceprovider = services.BuildServiceProvider();
                adminrepo = serviceprovider.GetService<IAdminDataService>();
            }
        }

        //public void DepenDencyInjection<T, A>() where T : class where A : class
        //{
        //    var services = new ServiceCollection();
        //    services.AddHttpClient<T, A>(client =>
        //    {
        //        client.BaseAddress = new Uri("https://localhost:44393/");
        //    });

        //    var serviceprovider = services.BuildServiceProvider();
        //    adminrepo = serviceprovider.GetService<T>();
        //}
        public void ClientDependencyInjection()
        {
            if (clientrepo == null)
            {
                var services = new ServiceCollection();
                services.AddHttpClient<IClientDataService, ClientDataService>(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:44393/");
                });

                var serviceprovider = services.BuildServiceProvider();
                clientrepo = serviceprovider.GetService<IClientDataService>();
            }
        }
        public void EventDependencyInjection()
        {
            if (eventrepo == null)
            {
                var services = new ServiceCollection();
                services.AddHttpClient<IEventDataService, EventDataService>(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:44393/");
                });

                var serviceprovider = services.BuildServiceProvider();
                eventrepo = serviceprovider.GetService<IEventDataService>();
            }

        }

        public void FemaleDependencyInjection()
        {
            if (femalerepo == null)
            {
                var services = new ServiceCollection();
                services.AddHttpClient<IFemaleModelDataService, FemaleModelDataService>(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:44393/");
                });

                var serviceprovider = services.BuildServiceProvider();
                femalerepo = serviceprovider.GetService<IFemaleModelDataService>();
            }
        }

        public void MaleDependencyInjection()
        {
            if (malerepo == null)
            {
                var services = new ServiceCollection();
                services.AddHttpClient<IMaleModelDataService, MaleModelDataService>(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:44393/");
                });

                var serviceprovider = services.BuildServiceProvider();
                malerepo = serviceprovider.GetService<IMaleModelDataService>();
            }
        }

        [TestMethod]
        [TestCategory("Post")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddAdmin()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AdminDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await adminrepo.AddAdmin(adminmodel),"not added admin properly");
        }
        [TestMethod]
        [TestCategory("Delete")]
        public async Task DeleteAdmin()
        {
            AdminDependencyInjection();
            await adminrepo.AddAdmin(adminmodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await adminrepo.DeleteAdminModel(adminmodel.id), " not removed admin properly");
        }

        [TestMethod]
        [TestCategory("GetAll")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task GetAllAdmins()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AdminDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await adminrepo.GetAllAdmins(), "didn't get all admins properly");
        }

        [TestMethod]
        [TestCategory("Get")]
        public async Task GetAdmin()
        {
            AdminDependencyInjection();
            await adminrepo.AddAdmin(adminmodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await adminrepo.GetAdminModelDetails(adminmodel.id), "didn't get admin properly");
        }
        [TestMethod]
        [TestCategory("Post")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddClient()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            ClientDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await clientrepo.AddClient(clientmodel), "not added client properly");
        }
        [TestMethod]
        [TestCategory("Delete")]
        public async Task DeleteClient()
        {
            ClientDependencyInjection();
            await clientrepo.AddClient(clientmodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await clientrepo.DeleteClient(clientmodel.id), " not removed client properly");
        }

        [TestMethod]
        [TestCategory("GetAll")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task GetAllClients()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            ClientDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await clientrepo.GetAllClients(), "didn't get all client properly");
        }

        [TestMethod]
        [TestCategory("Get")]
        public async Task GetClient()
        {
            ClientDependencyInjection();
            await clientrepo.AddClient(clientmodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await clientrepo.GetClientModelDetails(clientmodel.id), "didn't get client properly");
        }

        [TestMethod]
        [TestCategory("Post")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddEvent()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            EventDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await eventrepo.AddEvent(eventmodel), "not added event properly");
        }
        [TestMethod]
        [TestCategory("Delete")]
        public async Task DeleteEvent()
        {
            EventDependencyInjection();
            await eventrepo.AddEvent(eventmodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await eventrepo.DeleteEvent(eventmodel.id), " not removed event properly");
        }

        [TestMethod]
        [TestCategory("GetAll")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task GetAllEvents()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            EventDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await eventrepo.GetAllEvents(), "didn't get all events properly");
        }

        [TestMethod]
        [TestCategory("Get")]
        public async Task GetEvent()
        {
            EventDependencyInjection();
            await eventrepo.AddEvent(eventmodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await eventrepo.GetEventModelDetails(eventmodel.id), "didn't get event properly");
        }


        [TestMethod]
        [TestCategory("Post")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddFemaleModel()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            FemaleDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await femalerepo.AddFemaleModel(femalemodel), "not added model properly");
        }
        [TestMethod]
        [TestCategory("Delete")]
        public async Task DeleteFemaleModel()
        {
            FemaleDependencyInjection();
            await femalerepo.AddFemaleModel(femalemodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await femalerepo.DeleteFemaleModel(femalemodel.id), " not removed model properly");
        }

        [TestMethod]
        [TestCategory("GetAll")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task GetAllFemaleModels()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            FemaleDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await femalerepo.GetAllFemaleModels(), "didn't get all models properly");
        }

        [TestMethod]
        [TestCategory("Get")]
        public async Task GetFemaleModel()
        {
            FemaleDependencyInjection();
            await femalerepo.AddFemaleModel(femalemodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await femalerepo.GetFemaleModelDetails(femalemodel.id), "didn't get model properly");
        }

        [TestMethod]
        [TestCategory("Post")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddMaleModel()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            MaleDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await malerepo.AddMaleModel(malemodel), "not added model properly");
        }
        [TestMethod]
        [TestCategory("Delete")]
        public async Task DeleteMaleModel()
        {
            MaleDependencyInjection();
            await malerepo.AddMaleModel(malemodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await malerepo.DeleteMaleModel(malemodel.id), " not removed model properly");
        }

        [TestMethod]
        [TestCategory("GetAll")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task GetAllMaleModels()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            MaleDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await malerepo.GetAllMaleModels(), "didn't get all models properly");
        }

        [TestMethod]
        [TestCategory("Get")]
        public async Task GetMaleModel()
        {
            MaleDependencyInjection();
            await malerepo.AddMaleModel(malemodel);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await malerepo.GetMaleModelDetails(malemodel.id), "didn't get model properly");
        }
    }
}
