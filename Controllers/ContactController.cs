using Microsoft.AspNetCore.Mvc;
using PersonalPortfolio.Models;
namespace PersonalPortfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SubmitMessage([FromBody] ContactMessage message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                // Simulate processing time 
                await Task.Delay(500);
                // In a real application, you would:
                // - Save to database
                // - Send email notification
                // - Log the submission
                return Ok(new { success = true, message = "Message received successfully!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { success = false, message = $"An error occured processing your message: \n {ex}" });
            }
        }
    }
}