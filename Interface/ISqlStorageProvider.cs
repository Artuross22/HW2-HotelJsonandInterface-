using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Interface
{
  public interface ISqlStorageProvider
    {
        ISqlReader SqlCreateReader();

        ISqlWriter SqlCreateWriter();
    }
}
