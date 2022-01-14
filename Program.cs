using HotelJsonandInterface.Interface;
using HotelJsonandInterface.Models;
using HotelJsonandInterface.Realization;
using Microsoft.EntityFrameworkCore;
using System;
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
            manager.AddHotel(5);
            manager.GetTopHotels(5);
            manager.GetHotelById(3);

            manager.SQLGetHotelById(3);
            manager.SQLAddHotel(5);
            manager.SQLGetTopHotels(3,4);
        }
    }
}
