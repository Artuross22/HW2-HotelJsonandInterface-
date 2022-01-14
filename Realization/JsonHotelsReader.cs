using HotelJsonandInterface.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    public class JsonHotelsReader : IHotelsReader
    {
        public string SourcePath { get; }

        
        public JsonHotelsReader(string path)
        {
            SourcePath = path;
        }

        public List<Hotel> GetAll()
        {
            if (!File.Exists(SourcePath))
                throw new Exception("File not found.");

            string jsonString = File.ReadAllText(SourcePath);
            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonString);         
         
            if (hotels == null)
                return new List<Hotel>();

            return hotels;
        }

        public Hotel GetById(int Id)
        {
            if (!File.Exists(SourcePath))
                throw new Exception("File not found.");

            string jsonString = File.ReadAllText(SourcePath);
            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonString);
            var result = hotels.Where(p => p.HotelId == Id).FirstOrDefault();
            return result;
        }
    }
}
