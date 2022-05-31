using Microsoft.AspNetCore.Mvc;

namespace HamsterWars.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadsController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUploadsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] IFormFile image)
        {
            if (image == null || image.Length == 0) return BadRequest("Upload any Image");

            string fileName = image.FileName;
            string extensions = Path.GetExtension(fileName);


            string[] allow = { ".jpg", ".png" };

            if (!allow.Contains(extensions.ToLower())) return BadRequest("Invalid Image");

            string fileNameNew = $"{Guid.NewGuid()}{extensions}";
            string filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot", "Images", "hamsters", fileNameNew);

            using(var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await image.CopyToAsync(filestream);
            }

            return Ok($"Files/{fileNameNew}");
        }
    }
}
