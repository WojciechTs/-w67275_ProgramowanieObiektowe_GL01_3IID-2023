using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Zadanie3.Interface
{
    public interface IBaseRepository<T, TEnitiy> where T : IEntity<TEnitiy>
    {
        T Get(TEnitiy id);
        void Create(T item);
        void Update(T item);
        void Delete(TEnitiy id);
        List<T> GetAll();
    }
}