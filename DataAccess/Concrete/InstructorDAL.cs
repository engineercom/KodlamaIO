using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class InstructorDAL : IDAL<Instructor>
{
    List<Instructor> instructors;
    public InstructorDAL()
    {
        Instructor instructor1 = new Instructor() { Id = 1, Name = "Engin", SurName = "Demiroğ" };
        Instructor instructor2 = new Instructor() { Id = 2, Name = "Halit Enes", SurName = "Kalaycı" };
        instructors = new List<Instructor>() { instructor1, instructor2 };
    }
    public Instructor Create(Instructor instructor)
    {
        instructors.Add(instructor);
        return instructor;
    }

    public void Delete(int id)
    {
        instructors.Remove(InstructorById(id));

    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public Instructor Update(Instructor instructor)
    {

     Instructor i= InstructorById(instructor.Id);
        i.Name = instructor.Name;
        i.SurName = instructor.SurName;
        i.PhotoPath=instructor.PhotoPath;
        return i;

    }
    public Instructor InstructorById(int id) {
        return instructors.Find(x=>x.Id==id);
   
    }
}
