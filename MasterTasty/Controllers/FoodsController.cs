using System;
using System.Net;
using System.Threading.Tasks;
using Application.Interfaces.Food;
using Microsoft.AspNetCore.Mvc;

namespace MasterTasty.Controllers{
    
    [ApiController]
    [Route("[controller]")]
    
    public class FoodsController : ControllerBase{
        
        [HttpGet]
        public async Task<ActionResult> GetAll([FromServices] IFood service){
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