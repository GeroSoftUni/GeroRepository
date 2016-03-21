using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {

        public string FirtsName { get; set; }
        public string SecondName { get; set; }
        public string TurdName { get; set; }
        public int Course { get; set; }
        public Specalty Specalty { get; set; }
        public Univesety Universety { get; set; }
        public string Mail { get; set; }
        public string TelefoneNumber { get; set; }
        public string asd { get; set; }

    }

    enum Univesety
    {
        Sofiiski,
        Gabrvo
    }
    enum Specalty
    {
        TMM,
        KTT,
        KST
    }
}
