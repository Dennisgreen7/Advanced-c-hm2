using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_4
{
    class Class_Int : Interface1<int>
    {
        public int Id_ { get ; set; }

        public Class_Int(int id_)
        {
            Id_ = id_;
        }
    }
}
