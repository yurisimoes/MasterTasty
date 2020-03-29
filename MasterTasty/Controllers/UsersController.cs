using System;
using System.Net;
using System.Threading.Tasks;
using Application.Interfaces.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MasterTasty.Controllers{
    
    [ApiController]
    [Route("[controller]")]
    
    public class UsersController : ControllerBase{

        private IUser _service;

        public UsersController(IUser service){
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll(){
            if (!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            try{
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e){;
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}