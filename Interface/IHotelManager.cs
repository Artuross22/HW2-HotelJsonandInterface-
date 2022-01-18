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

        void AddHotel(Hotel hotel);

        List<Hotel> GetTopHotels(int topHotels);

        Hotel SQLGetHotelById(int id);

        void SQLAddHotel(Hotel hotel);

        List<Hotel> SQLGetTopHotels(int one, int two);
       
    }
}
