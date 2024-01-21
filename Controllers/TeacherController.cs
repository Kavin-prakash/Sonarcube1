using Microsoft.AspNetCore.Mvc;
using CreateWebapi.Data;
using CreateWebapi.Model;
using Microsoft.EntityFrameworkCore;
namespace CreateWebapi.Controllers{
[ApiController]

  public class AddTeacherController : ControllerBase{
      private readonly AppDbContext context;
        public AddTeacherController(AppDbContext context){
            this.context=context; 
        }
    [Route("api/AddTeacher")]
     [HttpPost]
    public async Task<IActionResult> Post(Teacher Teacher)
    {
        context.Add(Teacher);
        await context.SaveChangesAsync();
        return Ok();
    }

  }
}