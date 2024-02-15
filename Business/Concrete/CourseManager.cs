using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CourseManager : IManager<Course>
{
    IDAL<Course> _courseDAL;
    public CourseManager(IDAL<Course> courseDAL)
    {
        _courseDAL=courseDAL;
    }
    public Course Create(Course category)
    {
        return _courseDAL.Create(category);
    }

    public void Delete(int id)
    {
        _courseDAL.Delete(id);
    }

    public List<Course> GetAll()
    {
        return _courseDAL.GetAll();
    }

    public Course Update(Course category)
    {
        return _courseDAL.Update(category);
    }
}
