using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IManager<T>
{
    List<T> GetAll();
    T Create(T category);
    T Update(T category);
    void Delete(int id);
}
