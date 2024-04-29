using MultiLayerAspNetCore.Core.ViewModel;
using MultiLayerAspNetCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerAspNetCore.Core.Common
{
    public class Mapper
    {
        public static Client MapClientViewModelToClientEntity(ClientViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Client
            {
                ClientId =model.ClientId,
                CompanyName = model.CompanyName,
                CreatedAt = model.CreatedAt,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                UpdatedAt = model.UpdatedAt,
                Address = model.Address,
            };
        }
        public static ClientViewModel MapClientEntityToClientViewModel(Client model)
        {
            if (model == null)
            {
                return null;
            }
            return new ClientViewModel
            {
                ClientId = model.ClientId,
                CompanyName = model.CompanyName,
                CreatedAt = model.CreatedAt,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                UpdatedAt = model.UpdatedAt,
                Address = model.Address,
            };
        }
        public static ClientViewModel MapClientRequestViewModelToClientViewModel(ClientRequestViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new ClientViewModel
            {
                ClientId = Guid.NewGuid(),
                CompanyName = model.CompanyName,
                CreatedAt = DateTime.Now,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                UpdatedAt = DateTime.Now,
                Address = model.Address,
            };
        }
    }
}
