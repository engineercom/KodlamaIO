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

public class InstructorManager : IManager<Instructor>
{
    IDAL<Instructor> _instructorDAL;
    public InstructorManager(IDAL<Instructor> instructorDAL)
    {
        _instructorDAL= instructorDAL;
    }
    public Instructor Create(Instructor category)
    {
        return _instructorDAL.Create(category);
    }

    public void Delete(int id)
    {
        _instructorDAL.Delete(id);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDAL.GetAll();
    }

    public Instructor Update(Instructor category)
    {
        return _instructorDAL.Update(category);
    }
}
