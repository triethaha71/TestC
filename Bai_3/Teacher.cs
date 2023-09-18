using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Teacher :Person
    {
        public Teacher(string id, string fullname, string address) 
            :base(id,fullname)
        {
            Address = address;            
        }

        public Teacher()
        {

        }

        public string Address { get; set; }

        public void addGV()
        {
            Console.WriteLine("Nhap MGV: ");
            ID = Console.ReadLine();
            Console.WriteLine("Nhap ten GV: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();   
        }

        public void ShowGV()
        {
            Console.WriteLine("MSSV:{0} Ho va ten: {1} Dia chi: {2}", this.ID,this.Fullname,this.Address); 
        }
    }
}
