using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_3
{
    class TypeDouble : Itype<double>
    {
        public double Value_ { get; set;}

        public TypeDouble(double value_)
        {
            Value_ = value_;
        }
    }
}
