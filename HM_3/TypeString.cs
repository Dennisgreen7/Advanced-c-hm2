using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_3
{
    class TypeString : Itype<string>
    {
        public string Value_ { get; set;}

        public TypeString(string value_)
        {
            Value_ = value_;
        }
    }
}
