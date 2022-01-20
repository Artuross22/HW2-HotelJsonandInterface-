using HotelJsonandInterface.Interface;
using HotelJsonandInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HotelJsonandInterface.Realization
{
    public class HotelManager : IHotelsManager 

    {

        protected IStorageProvider storageProvider;

        protected IStorageProvider sqlStorageProvider;

        public HotelManager(IStorageProvider provider , IStorageProvider sqlProvider )
        {
            storageProvider = provider;
            sqlStorageProvider = sqlProvider;


        }

        public void AddHotel(Hotel hotel)
        {
            int? hotelId = hotel.HotelId;

            if (hotelId == null && hotel.HotelId == 0)
                throw new Exception("Invalid id");

            var recording = storageProvider.CreateWriter();
            recording.AddHotel(hotel);

        }

        public Hotel GetHotelById(int id)
        {
            var reader = storageProvider.CreateReader();
            return reader.GetById(id);
        }

        public List<Hotel> GetTopHotels(int topHotels)
        {
            var hotelInformation = storageProvider.CreateReader();
            var getTop = hotelInformation.GetAll();
            var topHotel = getTop.Where(x => x.Rating >= topHotels).ToList();
            return topHotel;
        }




        public void SQLAddHotel(Hotel hotel)
        {
            int? rating = hotel.Rating;

            if (rating == null)
                throw new Exception("Invalid rating");
          

            if(rating <=  1 && rating >= 5)
                throw new Exception("rating not 0 and not more than 5");

         
            var baseMethodAdd = sqlStorageProvider.CreateWriter();
            baseMethodAdd.AddHotel(hotel);
          


        }

        public Hotel SQLGetHotelById(int id)
        {
            var getById = sqlStorageProvider.CreateReader();
            return getById.GetById(id);

        }

        public List<Hotel> SQLGetTopHotels(int betweenOne, int betweenTwo)
        {
            var hotelInformation = sqlStorageProvider.CreateReader();
            var  allhotel = hotelInformation.GetAll();
            var mediumHotels = allhotel.Where(x => x.Rating >= betweenOne && x.Rating <= betweenTwo).ToList();
            return mediumHotels;
        }
      
    }
}
