using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Zadanie3.Interface
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}