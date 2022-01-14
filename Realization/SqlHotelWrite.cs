using HotelJsonandInterface.Interface;
using HotelJsonandInterface.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{


    class SqlHotelWrite : ISqlWriter
    {
        protected ApplicationContext ApplicationContext
        {
            get => new  ApplicationContext();         
        }
        public void AddHotel(int rating)
        {
            
            if (rating <= 0 && rating >= 5)
                throw new Exception("rating less than 0 and not more than 5"); 

            Hotel myHotel = new Hotel { Name = "MyHotel", FoundedDate = "01.02.2000", TouristСapacity = 2000, Rating = rating };
            Hotel hotel = new Hotel { Name = "Chermosh", FoundedDate = "01.02.2000", TouristСapacity = 2000, Rating = 5 };
            Hotel hote2 = new Hotel { Name = "Bukovina", FoundedDate = "01.02.2005", TouristСapacity = 900, Rating = 4 };
            Hotel hote3 = new Hotel { Name = "Brashow", FoundedDate = "01.02.2007", TouristСapacity = 420, Rating = 3 };
            Hotel hote4 = new Hotel { Name = "Transilvania", FoundedDate = "01.02.1980", TouristСapacity = 370, Rating = 2 };
            Hotel hote5 = new Hotel { Name = "NewHotel", FoundedDate = "01.02.2020", TouristСapacity = 100, Rating = 1 };

            var db = new ApplicationContext();
            db.Hotels.Add(hote5);
            db.Hotels.AddRange(myHotel , hotel, hote2, hote3, hote4, hote5);
            db.SaveChanges();

        }
    }
}
