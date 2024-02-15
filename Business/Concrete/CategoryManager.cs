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
        try
        {
            return _categoryDAL.GetAll();
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
            throw ex;
        }
    }
    public Category Create(Category category)
    {

        try
        {
            return _categoryDAL.Create(category);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
            return category;
        }
    }
    public Category Update(Category category)
    {

        try
        {
            return _categoryDAL.Update(category);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return category;
        }

    }

    public void Delete(int id)
    {
        try
        {
            _categoryDAL.Delete(id);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message); 
        }
    }
}
