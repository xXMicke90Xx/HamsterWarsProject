using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using HamsterWars.Client;

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
        public async Task<IActionResult> Index(IFormFile postedFile)
        {
            //string wwwPath = _webHostEnvironment.WebRootPath;
            //string contentPath = _webHostEnvironment.ContentRootPath;

            //string path = _webHostEnvironment.WebRootPath + @"...\wwwroot\images\hamsters";

            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            var fileName = Path.GetFileName(postedFile.FileName);
            var myUniqueFileName = Convert.ToString(Guid.NewGuid());
            var fileExtension = Path.GetExtension(fileName);
            var newFileName = String.Concat(myUniqueFileName, fileExtension);
            var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "hamsters")).Root + $@"\{newFileName}";

            using (FileStream stream = System.IO.File.Create(filepath))
            {
                await postedFile.CopyToAsync(stream);
                stream.Flush();
                return Ok();
            }

        }


        //if (image == null || image.Length == 0) return BadRequest("Upload any Image");

        //string fileName = image.FileName;
        //string extensions = Path.GetExtension(fileName);


        //string[] allow = { ".jpg", ".png" };

        //if (!allow.Contains(extensions.ToLower())) return BadRequest("Invalid Image");

        //string fileNameNew = $"{Guid.NewGuid()}{extensions}";
        //string filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot", "images", "hamsters", fileNameNew);

        //using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        //{
        //    await image.CopyToAsync(filestream);
        //}

        //return Ok($"Files/{fileNameNew}");
    }
}


