using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Student :Person 
    {
        public Student(string id,string fullname,string faculty, float averageScore)
            :base(id,fullname) 
        {
            Faculty = faculty;
            this.averageScore = averageScore;
        }
        public Student()
        {

        }

        public string Faculty { get; set; }
        public float averageScore { get; set; }

        public void addSV()
        {
            Console.WriteLine("Nhap MSSV: ");
            ID  = Console.ReadLine();
            Console.WriteLine("Nhap ho va ten: ");
            Fullname= Console.ReadLine();
            Console.WriteLine("Nhap DTB: ");
            averageScore =float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Khoa");
            Faculty = Console.ReadLine();
        }

        public void ShowSV()
        {
            Console.WriteLine("MSSV: {0} Ho va ten: {1} DTB: {2} KHoa: {3}",this.ID,this.Fullname,this.Faculty, this.averageScore);
        }
    }
}
