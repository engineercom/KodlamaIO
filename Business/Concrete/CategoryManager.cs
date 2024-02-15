using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CategoryManager : IManager<Category>
{
    IDAL<Category> _categoryDAL;

    public CategoryManager(IDAL<Category> categoryDAL)
    {
        _categoryDAL = categoryDAL;
    }
    public List<Category> GetAll()
    {
        return _categoryDAL.GetAll();
    }
    public Category Create(Category category)
    {

        return _categoryDAL.Create(category);
    }
    public Category Update(Category category)
    {

        return _categoryDAL.Update(category);

    }

    public void Delete(int id)
    {
        _categoryDAL.Delete(id);
    }
}
