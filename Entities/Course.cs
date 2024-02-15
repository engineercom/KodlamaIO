using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;
//2024 Yazılım Geliştirici Yetiştirme Kampı(C#)
public class Course
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string Name { get; set; }
    //public int Completed { get; set; }

}
