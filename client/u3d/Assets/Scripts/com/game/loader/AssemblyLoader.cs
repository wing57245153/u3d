using System;
using System.Collections.Generic;
using System.IO;

namespace Game.Loader
{
    class AssemblyLoader
    {
        public byte[] LoaderAssembly(string path)
        {
            byte[] bytes = null;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryReader r = new BinaryReader(fs);

                bytes = r.ReadBytes(10000);
            }

            return bytes;
        }
    }
}
