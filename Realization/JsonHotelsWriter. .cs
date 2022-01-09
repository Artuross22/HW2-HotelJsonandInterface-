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
    class JsonHotelsWriter : IHotelsWriter
    {
        public JsonHotelsWriter(string sourcePath)
        {
            SourcePath = sourcePath;
        }

        public string SourcePath { get; }

        public void AddHotel(int? id)
        {
            if (!File.Exists(SourcePath))
                throw new Exception("File not found.");

            string jsonString = File.ReadAllText(SourcePath);
            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonString);

            hotels.Add(new Hotel("Chermos", 11 , "08.10.1990", 1900, 5));

            string serealizeHotel = JsonConvert.SerializeObject(hotels);
            File.WriteAllText(SourcePath, serealizeHotel);
        }
    }
}
