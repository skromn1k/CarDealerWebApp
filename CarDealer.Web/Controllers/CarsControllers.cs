using CarDealer.Core.Models;
using CarDealer.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarDealerDbContext _context;

        public CarsController(CarDealerDbContext context)
        {
            _context = context;
        }

        // Получить все машины
        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return Ok(cars);
        }

        // Добавить новую машину (только для Admin)
        [HttpPost]
        public async Task<IActionResult> AddCar([FromBody] Car car, [FromQuery] bool isAdmin = false)
        {
            if (!isAdmin)
                return Forbid("Only admin can add cars."); // блокируем, если не админ

            if (car == null)
                return BadRequest("Car object is null.");

            if (car.CreatedAt == default)
                car.CreatedAt = DateTime.Now;

            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return Ok(car);
        }
    }
}