using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BL.Utilities
{
    public static class FileManager
    {
        public static async Task<string> SaveAsync(IFormFile file, string folder)
        {
            string uploadPath= Path.Combine(Path.GetFullPath("wwwroot"),"uploads",folder);
            if(!Directory.Exists(uploadPath)) Directory.CreateDirectory(uploadPath);
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            using (FileStream fs = new(Path.Combine(uploadPath + fileName), FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }
            return fileName;
            
        }
        public static bool CheckType(IFormFile file, string required)=> file.ContentType.Contains(required);
    }
}
