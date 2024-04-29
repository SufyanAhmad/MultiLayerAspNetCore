using MultiLayerAspNetCore.Core.Common;
using MultiLayerAspNetCore.Core.Interface;
using MultiLayerAspNetCore.Core.ViewModel;
using MultiLayerAspNetCore.Domain.Interface;
using MultiLayerAspNetCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerAspNetCore.Core.Service
{
    public class ClientService : IClientService
    {
        public IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public ClientViewModel AddClient(ClientViewModel client)
        {
            return Mapper.MapClientEntityToClientViewModel(_clientRepository.AddClient(Mapper.MapClientViewModelToClientEntity(client)));
        }
        public ClientViewModel GetClient(Guid clientId)
        {
            return Mapper.MapClientEntityToClientViewModel(_clientRepository.GetClient(clientId));
        }
        public bool IsClientExist(Guid clientId)
        {
            return _clientRepository.IsClientExist(clientId);
        }

        public ClientViewModel UpdateClient(ClientViewModel client)
        {
            return Mapper.MapClientEntityToClientViewModel(_clientRepository.UpdateClient(Mapper.MapClientViewModelToClientEntity(client)));
        }
        public bool DeleteClient(Guid clientId)
        {
            return _clientRepository.DeleteClient(clientId);
        }
    }
}
