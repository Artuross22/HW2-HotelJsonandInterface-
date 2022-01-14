﻿using HotelJsonandInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJsonandInterface.Interface
{
    public interface ISqlReader
    {
        Hotel GetById(int? id);
        List<Hotel> GetAll();
    }
}