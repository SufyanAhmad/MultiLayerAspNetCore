using MultiLayerAspNetCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerAspNetCore.Domain.Interface
{
    public interface IClientRepository
    {
        Client AddClient(Client client);
        bool IsClientExist(Guid clientId);
        Client GetClient(Guid clientId);
        Client UpdateClient(Client client);
        bool DeleteClient(Guid clientId);
    }
}
