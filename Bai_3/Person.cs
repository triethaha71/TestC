using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Person
    {
        public Person(string id, string fullname)
        {
            ID = id;
            Fullname = fullname;
        }

        public Person()
        {

        }

        public string ID { get; set; }
        public string Fullname { get; set; }
    }
}
