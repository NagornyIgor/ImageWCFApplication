using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace ImageService
{
    public class ImageHandlerService : IImageHandlerService
    {
        public byte[] GetImage(string imageName)
        {
            try
            {
                return File.ReadAllBytes($"{ConfigurationManager.AppSettings["StoragePath"]}{imageName}");
            }
            catch (Exception ex)
            {
                return null; 
            }
        }

        public IEnumerable<string> GetImageNames()
        {
            return Directory.GetFiles(ConfigurationManager.AppSettings["StoragePath"]).Select(n => Path.GetFileName(n));
        }

        public void SaveImage(FileModel image)
        {
            var path = $"{ConfigurationManager.AppSettings["StoragePath"]}{image.Name}";

            if (File.Exists(path))
                throw new FaultException("This file already exists in the folder.");

            File.WriteAllBytes(path, image.Content);
        }
    }
}
