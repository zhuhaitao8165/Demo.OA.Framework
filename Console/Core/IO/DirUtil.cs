using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.IO
{
    public static class DirUtil
    {
        public static void DeleteBinAndObjDir(string path)
        {
            var dirs = Directory.GetDirectories(path);
            foreach (var dirpath in dirs)
            {
                DirectoryInfo info = new DirectoryInfo(dirpath);
                if (info.Name.ToUpper() == "BIN" || info.Name.ToUpper() == "OBJ")
                {
                    Directory.Delete(dirpath, true);
                }
                else
                {
                    DeleteBinAndObjDir(dirpath);
                }
            }
        }
    }
}
