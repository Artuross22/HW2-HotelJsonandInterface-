using HotelJsonandInterface.Interface;
using HotelJsonandInterface.Realization;
using System;

namespace HotelJsonandInterface
{
    class Program
    {
        private const string Source = "C:\\Users\\user\\source\\repos\\HotelJsonandInterface\\Hotel.js";
        static void Main(string[] args)
        {

            IStorageProvider storageProvider = new JsonStorageProvider(Source);
            IHotelsManager manager = new HotelManager(storageProvider);
            var resultGetId = manager.GetHotelById(13);
            var resultTopHptels = manager.GetTopHotels();
            manager.AddHotel(5);



        }
    }
}
