using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Infrastructure
{
    public class ImageParser
    {
        private List<string> AllowedExtensions = new List<string>(new string[] { ".png", ".jpeg", ".jpg" });

        public byte[] ConvertToBytes(IFormFile file)
        {
            if (file == null)
            {
                throw new ArgumentNullException("Image does not exist");
            }

            var fileExtension = Path.GetExtension(file.FileName);

            if (IsValidExtension(fileExtension))
            {
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyToAsync(memoryStream);
                    return memoryStream.ToArray();
                }
            }
            else
            {
                throw new ArgumentException("Wrong image type");
            }
        }

        private bool IsValidExtension(string extension) => AllowedExtensions.Contains(extension);

        public List<byte[]> ConvertToBytes(IFormFileCollection files)
        {
            List<byte[]> list = new List<byte[]>();

            foreach (var file in files)
            {
                list.Add(ConvertToBytes(file));
            }

            return list;
        }
    }
}
