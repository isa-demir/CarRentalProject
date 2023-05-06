﻿
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelper : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(file.FileName); //dosya uzantisi alinir
                string guid = GuidHelper.GuidHelper.CreateGuid(); //benzersiz kimlik olusturulur
                string filePath = guid + extension; //asdasd.jpg

                using (FileStream fileStream = File.Create(root+filePath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush(); //arabellekten silme islemi yapar.
                    return filePath;
                }
            }
            return null;
        }
    }
}
