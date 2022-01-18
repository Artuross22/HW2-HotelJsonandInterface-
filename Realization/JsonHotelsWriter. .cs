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

        public void AddHotel(Hotel hotel)
        {
            if (!File.Exists(SourcePath))
                throw new Exception("File not found.");

            string jsonString = File.ReadAllText(SourcePath);

            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonString);
            hotels.Add(new Hotel { Name = hotel.Name, HotelId = hotel.HotelId, FoundedDate = hotel.FoundedDate, TouristСapacity = hotel.TouristСapacity, Rating = hotel.Rating });

            string serealizeHotel = JsonConvert.SerializeObject(hotels);
            File.WriteAllText(SourcePath, serealizeHotel);
        }
    }
}
