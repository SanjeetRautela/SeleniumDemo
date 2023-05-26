using SeleniumDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Helpers
{
    public class FileHelper
    {
        public static string ReadFile(string filePath)
        {
            return File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + filePath);
        }
    }
}
