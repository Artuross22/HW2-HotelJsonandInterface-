using HotelJsonandInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    public interface IHotelsReader
    {
        Hotel GetById(int? id);
        List<Hotel> GetAll();
    }
}
