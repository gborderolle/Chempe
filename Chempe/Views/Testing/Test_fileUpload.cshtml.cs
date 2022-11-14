using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chempe.Views
{
    public class Test_fileUploadModel : PageModel
    {
        private IWebHostEnvironment _environment;
        public string Message1 { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        public Test_fileUploadModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public string Clicked()
        {
            return "I was clicked";
        }

        public async Task OnPostAsync()
        {
            var file = Path.Combine(_environment.ContentRootPath, "uploads", Upload.FileName);
            Message1 = "";
            try
            {
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    await Upload.CopyToAsync(fileStream);
                    Message1 = "El archivo se subió correctamente";
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }


    }
}
