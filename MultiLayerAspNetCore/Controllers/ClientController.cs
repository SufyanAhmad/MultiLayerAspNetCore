using Microsoft.AspNetCore.Mvc;
using MultiLayerAspNetCore.Core.Common;
using MultiLayerAspNetCore.Core.Interface;
using MultiLayerAspNetCore.Core.ViewModel;
using MultiLayerAspNetCore.Data.Context;
using MultiLayerAspNetCore.Domain.Model;

namespace MultiLayerAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        /// <summary>
        ///add client into system 
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        [Route("add-client")]
        public IActionResult AddClient(ClientRequestViewModel model)
        {
            var response = _clientService.AddClient(Mapper.MapClientRequestViewModelToClientViewModel(model));
            return Ok(new ResponseViewModel { Status = "Success", Message = "Record Added Successfully", Data = response });
        }

        /// <summary>
        ///get client details from system 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="400">If the item is null</response>
        [HttpGet]
        [Route("get-client/{clientId}")]
        public IActionResult GetClient(Guid clientId)
        {

            var clientExist = _clientService.IsClientExist(clientId);
            if (clientExist == false)
            {
                return BadRequest(new ResponseViewModel { Status = "Error", Message = "client against this Id does not exist", Data = clientId });
            }
            var response = _clientService.GetClient(clientId);  
            return Ok(new ResponseViewModel { Status = "Success", Message = "Record get Successfully", Data = response });
        }

        /// <summary>
        ///update client details into system 
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="400">If the item is null</response>
        [HttpPut]
        [Route("update-client/{clientId}")]
        public IActionResult UpdateClient(Guid clientId, ClientRequestViewModel model)
        {

            var clientExist = _clientService.IsClientExist(clientId);
            if (clientExist == false)
            {
                return BadRequest(new ResponseViewModel { Status = "Error", Message = "client against this Id does not exist", Data = clientId });
            }
            var request = Mapper.MapClientRequestViewModelToClientViewModel(model);
            request.ClientId = clientId;
            var response = _clientService.UpdateClient(request);
            return Ok(new ResponseViewModel { Status = "Success", Message = "Record updated Successfully", Data = response });
        }

        /// <summary>
        ///delete client from system 
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        /// <response code="400">If the item is null</response>
        [HttpDelete]
        [Route("delete-client/{clientId}")]
        public IActionResult DeleteClient(Guid clientId)
        {

            var clientExist = _clientService.IsClientExist(clientId);
            if (clientExist == false)
            {
                return BadRequest(new ResponseViewModel { Status = "Error", Message = "client against this Id does not exist", Data = clientId });
            }
            var response = _clientService.DeleteClient(clientId);
            return Ok(new ResponseViewModel { Status = "Success", Message = "Record Deleted Successfully", Data = clientId });
        }
    }
}
