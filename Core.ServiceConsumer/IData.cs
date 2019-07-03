using System;
using System.Collections;
using System.Collections.Generic;
using Core.ServiceConsumer.Models;

namespace Core.ServiceConsumer
{
    public interface IData
    {
        IEnumerable<CarItem> GetCarList();
    }
}
