using HotelJsonandInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    class SqlStorageProvider : IStorageProvider
    {
        public IHotelsReader CreateReader()
        {
            return new SqlHotelReader();
        }

        public IHotelsWriter CreateWriter()
        {
            return new SqlHotelWrite();
        }
    }
}
