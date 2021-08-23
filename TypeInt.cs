using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_3
{
    class TypeInt : Itype<int>
    {
        public int Value_ { get; set;}

        public TypeInt(int value_)
        {
            Value_ = value_;
        }
    }
}
