using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class CourseSchedule
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Syllabus { get; set; }                     //ders programı
    public string VideoRecording { get; set; }
    public string Evaluation { get; set; }                    //değerlendirme
}
