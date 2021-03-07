using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class UploadFile
    {
        public static void FileUpload(FromDataFile objectFile,string path)
        {
            try
            {               
                if (objectFile.files.Length>0)
                {
                    path += "\\uploads\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream= System.IO.File.Create(path+Guid.NewGuid()+ objectFile.files.FileName))
                    {
                        objectFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
