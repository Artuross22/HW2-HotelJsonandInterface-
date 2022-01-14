using HotelJsonandInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    class SqlStorageProvider : ISqlStorageProvider
    {
        public ISqlReader SqlCreateReader()
        {
            return new SqlHotelReader();
        }

        public ISqlWriter SqlCreateWriter()
        {
            return new SqlHotelWrite();
        }
    }
}
