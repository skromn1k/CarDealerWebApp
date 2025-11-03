namespace CarDealer.Web.Controllers
{
    using CarDealer.Core.Interfaces;
    using CarDealer.Core.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [ApiController]
    [Route("api/[controller]")]
    public class InquiriesController : ControllerBase
    {
        private readonly IInquiryService _service;

        public InquiriesController(IInquiryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllInquiriesAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetInquiryByIdAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Inquiry inquiry)
        {
            await _service.AddInquiryAsync(inquiry);
            return CreatedAtAction(nameof(GetById), new { id = inquiry.Id }, inquiry);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteInquiryAsync(id);
            return NoContent();
        }
    }
}