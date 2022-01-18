using HotelJsonandInterface.Interface;
using HotelJsonandInterface.Models;
using HotelJsonandInterface.Realization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelJsonandInterface
{
    public class Program
    {
        private const string Source = "C:\\Users\\user\\source\\repos\\HotelJsonandInterface\\Hotel.js";
        static void Main(string[] args)
        {
            ISqlStorageProvider sqlStorageProvider = new SqlStorageProvider();
            IStorageProvider storageProvider = new JsonStorageProvider(Source);

            IHotelsManager manager = new HotelManager(storageProvider , sqlStorageProvider);
            Hotel hotel = new Hotel { Name = "Chermos", FoundedDate = "08.10.1990", TouristСapacity = 1900, Rating = 5, HotelId = 999 };
            manager.AddHotel(hotel);
            manager.GetTopHotels(5);
            manager.GetHotelById(3);

            Hotel hotels = new Hotel { Name = "NewChermos", FoundedDate = "08.10.1990", TouristСapacity = 1900, Rating = 5,};
            manager.SQLGetHotelById(3);
            manager.SQLAddHotel(hotels);
            manager.SQLGetTopHotels(3, 4);

        }
    }
}
