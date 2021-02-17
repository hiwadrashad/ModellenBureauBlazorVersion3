using Logic.StaticResources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUpload : ControllerBase
    {
        private readonly IHostEnvironment _environment;

        public ImageUpload(IHostEnvironment environment)
        {
            this._environment = environment;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] IFormFile image)
        {
            if (image == null || image.Length == 0)
                return BadRequest("Upload a file");

            string filename = image.FileName;
            string extension = Path.GetExtension(filename);

            string[] allowedExtensions = { ".jpg", ".png", ".bmp" };

            if (!allowedExtensions.Contains(extension))
                return BadRequest("File is not a valid image");

            string newFileName = $"{Guid.NewGuid()}{extension}";
            string filePath = Path.Combine(_environment.ContentRootPath,"wwwroot", "Images", newFileName);

            using (var FileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await image.CopyToAsync(FileStream);
            }

            GeneralStaticdata.chosenimage = image;

            return Ok($"Images/{newFileName}");
        }
    }
}
