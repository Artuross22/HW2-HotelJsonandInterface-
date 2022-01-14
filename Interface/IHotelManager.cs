using HotelJsonandInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Interface
{
    public interface IHotelsManager
    {
        Hotel GetHotelById(int id);

        void AddHotel(int? id);

        List<Hotel> GetTopHotels(int topHotels);

        Hotel SQLGetHotelById(int id);

        void SQLAddHotel(int? id);

        List<Hotel> SQLGetTopHotels(int one, int two);
       
    }
}
