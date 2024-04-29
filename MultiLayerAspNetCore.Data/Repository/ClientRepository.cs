using MultiLayerAspNetCore.Core.ViewModel;
using MultiLayerAspNetCore.Data.Context;
using MultiLayerAspNetCore.Domain.Interface;
using MultiLayerAspNetCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerAspNetCore.Data.Repository
{
    public class ClientRepository : IClientRepository
    {
        public ApplicationDbContext _dbContext;
        public ClientRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Client AddClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
            return client;
        }
        public bool IsClientExist(Guid clientId)
        {
            return _dbContext.Clients.Find(clientId) == null ? false : true;
        }
       
        public Client GetClient(Guid clientId)
        {
            return _dbContext.Clients.Find(clientId);
        }

        public Client UpdateClient(Client model)
        {
            var client = _dbContext.Clients.Find(model.ClientId);
            if (client == null)
            {
                return null;
            }
            client.CompanyName = model.CompanyName;
            client.Email = model.Email;
            client.FirstName = model.FirstName;
            client.LastName = model.LastName;
            client.PhoneNumber = model.PhoneNumber;
            client.UpdatedAt = DateTime.Now;
            client.Address = model.Address;
            _dbContext.Clients.Update(client);
            _dbContext.SaveChanges();
            return client;
        }
        public bool DeleteClient(Guid clientId)
        {
            var client = _dbContext.Clients.Find(clientId);
            if (client == null)
            {
                return false;
            }
            _dbContext.Clients.Remove(client);
            _dbContext.SaveChanges();
            return true;
        }

    }
}
