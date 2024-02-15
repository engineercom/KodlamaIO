using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class CourseDAL : IDAL<Course>
{
    List<Course> courses;
    public CourseDAL()
    {
        Course course1 = new Course() { Id = 1, Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", CategoryId = 1, InstructorId = 1 };
        Course course2 = new Course() { Id = 3, Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)", CategoryId = 2, InstructorId = 1 };
        courses = new List<Course>() { course1, course2 };
    }
    public Course Create(Course course)
    {
        courses.Add(course);
        return course;
    }

    public void Delete(int id)
    {
        foreach (var item in courses)
        {
            if (item.Id == id)
            {
                courses.Remove(item);
                break;

            }

        }
    }
    public List<Course> GetAll()
    {
        return courses;
    }
    public Course Update(Course course)
    {
        foreach (var item in courses)
        {
            if (item.Id == course.Id)
            {
                item.Name = course.Name;
                return course;  //updated
            }

        }
        return course; //non-updated
    }
}