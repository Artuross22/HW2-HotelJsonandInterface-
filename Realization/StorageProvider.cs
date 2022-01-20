using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    public class StorageProvider : IStorageProvider
    {
        private string sourcePath;

        public string SourcePath => sourcePath;

        public StorageProvider(string sourcePath)
        {
            this.sourcePath = sourcePath;
        }

        public IHotelsReader CreateReader()
        {
           return new JsonHotelsReader(SourcePath);         
        }

        public IHotelsWriter CreateWriter()
        {
            return new JsonHotelsWriter(SourcePath);
        }     
    }
}
