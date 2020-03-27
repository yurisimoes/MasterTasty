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

        [HttpGet]
        public async Task<ActionResult> GetAll([FromServices] IUser service){
            if (!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            try{
                return Ok(await service.GetAll());
            }
            catch (ArgumentException e){;
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
        
    }
}