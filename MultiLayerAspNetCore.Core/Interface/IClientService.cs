using MultiLayerAspNetCore.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerAspNetCore.Core.Interface
{
    public interface IClientService
    {
        ClientViewModel AddClient(ClientViewModel client);
        bool IsClientExist(Guid clientId);
        ClientViewModel GetClient(Guid clientId);
        ClientViewModel UpdateClient(ClientViewModel client);
        bool DeleteClient(Guid clientId);   
    }
}
