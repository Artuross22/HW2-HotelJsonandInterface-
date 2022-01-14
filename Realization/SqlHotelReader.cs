using HotelJsonandInterface.Interface;
using HotelJsonandInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    class SqlHotelReader : ISqlReader
    {
        protected ApplicationContext ApplicationContext
        {
            get
            {
                return new ApplicationContext();
            }
        }

        public List<Hotel> GetAll()
        {
            var db = new ApplicationContext();
            var returnListHotels = db.Hotels.ToList();
            return returnListHotels;
        }

        public Hotel GetById(int? id)
        {
            if (id == null)
               throw new Exception("Id does not exist");
            var db = new ApplicationContext();
            var returnListHotels = db.Hotels.ToList();
            var result = returnListHotels.Where(p => p.HotelId == id).FirstOrDefault();
            return result;          
        }
    }
}
