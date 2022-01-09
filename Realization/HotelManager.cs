using HotelJsonandInterface.Interface;
using HotelJsonandInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    public class HotelManager : IHotelsManager

    {
        protected IStorageProvider storageProvider;

        public HotelManager(IStorageProvider provider)
        {
            storageProvider = provider;
        }

        public void AddHotel( int? id)
        {
            int hotellId = id ?? 0;
            if (hotellId == 0)
                Console.WriteLine("ID not specified");
            var recording = storageProvider.CreateWriter();
            recording.AddHotel(hotellId);
        }

        public Hotel GetHotelById(int id)
        {
            var reader = storageProvider.CreateReader();
            return reader.GetById(id);
        }

        public List<Hotel> GetTopHotels()
        {
            var hotelInformation = storageProvider.CreateReader();
            var getTop = hotelInformation.GetAll();
            var topHotel = getTop.Where(x => x.Rating >= 3).ToList();
            return topHotel;
        }
    }
}
