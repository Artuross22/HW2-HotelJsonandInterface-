using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Realization
{
    public interface IStorageProvider
    {
        IHotelsReader CreateReader();

        IHotelsWriter CreateWriter();
    }
}
