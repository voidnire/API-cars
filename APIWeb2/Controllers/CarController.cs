using APIWeb2.Context;
using APIWeb2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace APIWeb2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public CarController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetCar()
        {
            return Ok(new{
                success = true,
                 data = await _appDbContext.Car.ToListAsync()
                });
        }

        [HttpPost]
        public async Task<IActionResult> PostCar(Car car) //create
        {
            _appDbContext.Car.Add(car);
            await _appDbContext.SaveChangesAsync();
            return Ok(new
            {
                success= true,
                data= car
            });
        }
    }
}
