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

        protected ISqlStorageProvider sqlStorageProvider;

        public HotelManager(IStorageProvider provider , ISqlStorageProvider sqlProvider )
        {
            storageProvider = provider;
            sqlStorageProvider = sqlProvider;


        }

        public void AddHotel( int? id)
        {
            if (id == null && id == 0)
                throw new Exception("Invalid id");

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

        public List<Hotel> GetTopHotels(int topHotels)
        {
            var hotelInformation = storageProvider.CreateReader();
            var getTop = hotelInformation.GetAll();
            var topHotel = getTop.Where(x => x.Rating >= topHotels).ToList();
            return topHotel;
        }




        public void SQLAddHotel(int? id)
        {
            if (id == null)
                throw new Exception("Invalid id");
          

            if(id <=  1 && id >= 5)
                throw new Exception("rating not 0 and not more than 5");
            var check = id ?? 0;
         
            var baseMethodAdd = sqlStorageProvider.SqlCreateWriter();
            baseMethodAdd.AddHotel(check);    
            
        }

        public Hotel SQLGetHotelById(int id)
        {
            var getById = sqlStorageProvider.SqlCreateReader();
            return getById.GetById(id);

        }

        public List<Hotel> SQLGetTopHotels(int betweenOne, int betweenTwo)
        {
            var hotelInformation = sqlStorageProvider.SqlCreateReader();
            var  allhotel = hotelInformation.GetAll();
            var mediumHotels = allhotel.Where(x => x.Rating >= betweenOne && x.Rating <= betweenTwo).ToList();
            return mediumHotels;
        }
      
    }
}
