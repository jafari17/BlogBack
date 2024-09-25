using Microsoft.AspNetCore.Mvc;

namespace BlogBack.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public ImageController(IWebHostEnvironment environment)
        {
            this._environment = environment;
        }


        [HttpGet("GetImage")]
        public async Task<string> GetPost(string randomUUID, string Filename)
        {
            Console.WriteLine("=====");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("GetPost(string randomUUID, string Filename)");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("=====");
            var r = GetImagebyProduct(randomUUID,Filename);

            if (r != null)
            {
            }

            return r;
        }


        [HttpPost("UploadImage")]
        public async Task<IActionResult> UploadImage()
        {
            Console.WriteLine("=====");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("UploadImage()");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("=====");
            string Results = "falseeeeeee";
            try
            {
                var nameBool = Request.Form.TryGetValue("name", out var name);
                var randomUUIDBool = Request.Form.TryGetValue("randomUUID", out var randomUUID);
                 
                var _uploadedfiles = Request.Form.Files;
                foreach (IFormFile source in _uploadedfiles)
                {
                    string Filename = source.FileName;
                    string Filepath = GetFilePath(randomUUID);
                    //string Filepath = GetFilePath();

                    if (!System.IO.Directory.Exists(Filepath))
                    {
                        System.IO.Directory.CreateDirectory(Filepath); 
                    }

                    string imagepath = Filepath + $"\\{Filename}";

                    if (System.IO.File.Exists(imagepath))
                    {
                        System.IO.File.Delete(imagepath);
                    }
                    using (FileStream stream = System.IO.File.Create(imagepath))
                    {
                        await source.CopyToAsync(stream);

                        var x = GetImagebyProduct(randomUUID, Filename);

                        if (x != null)
                        {
                            Results = x;
                        } 
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Ok(true);
        }




        [HttpGet("GetListImage")]
        public async Task<IActionResult> GetListUrlImageByPostDirectory(string postDirectory)
        {
            Console.WriteLine("=====");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("GetListUrlImageByPostDirectory");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("=====");
            string Filepath = GetFilePath(postDirectory);
            List<string> listImage = new List<string>();

            if (System.IO.Directory.Exists(Filepath))
            {
                string[] files = Directory.GetFiles(Filepath);
                 
                foreach (string filePath in files)
                {
                    string[] parts = filePath.Split('\\');
                    string fileNameWithExtension = parts[parts.Length - 1];

                    Console.WriteLine(fileNameWithExtension);

                    listImage.Add(GetImagebyProduct(postDirectory, fileNameWithExtension));
                }
            }
            return Ok(listImage);
        }

         


        [HttpPost("UploadTest")]
        public async Task<IActionResult> UploadTest()
        { 
            string c = "https://localhost:44391//uploads/Product/p102/image.png"; 
            return Ok(c);
        }
         
        [NonAction]
        private string GetFilePath(string randomUUID)
        {
            Console.WriteLine("=====");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("GetFilePath(string randomUUID)");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("=====");
            //return this._environment.WebRootPath + "\\Uploads\\Product\\" + randomUUID;
            return this._environment.WebRootPath + "\\" + randomUUID;
        }

 

        [NonAction]
        private string GetImagebyProduct(string randomUUID ,string Filename)
        {
            Console.WriteLine("=====");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("GetImagebyProduct(string randomUUID ,string Filename)");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("=====");
            string ImageUrl = string.Empty;
            string HostUrl = "http://localhost:8080/";
            string Filepath = GetFilePath(randomUUID);
            string Imagepath = Filepath + $"\\{Filename}";
            if (!System.IO.File.Exists(Imagepath))
            {
                ImageUrl = HostUrl + $"/uploads/common/noimage.png";
            }
            else
            {
                //ImageUrl = HostUrl + "/uploads/Product/"+ randomUUID + $"/{Filename}";
                ImageUrl = HostUrl + "/"+ randomUUID + $"/{Filename}";
            }
            return ImageUrl;

        }
    }
}
