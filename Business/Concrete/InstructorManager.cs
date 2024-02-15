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
        _instructorDAL = instructorDAL;
    }
    public Instructor Create(Instructor category)
    {
        try
        {
            return _instructorDAL.Create(category);
        }
        catch (Exception ex)
        {
            ExMessage(ex.Message);
            throw ex;
        }
    }

    public void Delete(int id)
    {
        try
        {
            _instructorDAL.Delete(id);
        }
        catch (Exception ex)
        {

            ExMessage(ex.Message);
            throw ex;
        }
    }

    public List<Instructor> GetAll()
    {
        try
        {
            return _instructorDAL.GetAll();
        }
        catch (Exception ex)
        {

            ExMessage(ex.Message);
            throw ex;
        }
    }

    public Instructor Update(Instructor category)
    {
        try
        {
            return _instructorDAL.Update(category);
        }
        catch (Exception ex)
        {

            ExMessage(ex.Message);
            throw ex;
        }
    }
    public void ExMessage(string ex)
    {

        Console.WriteLine(ex);
    }
}
