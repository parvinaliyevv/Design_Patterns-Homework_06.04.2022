using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// Public static slass for working with folders
    /// </summary>
    public static class DirectoryService
    {

        /// <summary>
        /// the method returns the path to the folder of this project
        /// </summary>
        /// <returns>Path directory</returns>
        public static string GetProjectFolderPath()
        {
            var parentDirectory = Directory.GetCurrentDirectory().Split("\\bin")[0];

            return parentDirectory;
        }
    }
}
