using System;
using System.Collections.Generic;
using System.Text;

namespace TransportBLLibrary
{
    public interface IRepo<T>
    {
        bool Add(T t);
        bool Update(T t);
        ICollection<T> GetAll();
    }
}
