using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    public class JsonStorageProvider : IStorageProvider
    {
        private string sourcePath;

        public string SourcePath => sourcePath;

        public JsonStorageProvider(string sourcePath)
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
