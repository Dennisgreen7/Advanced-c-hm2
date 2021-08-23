using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_3
{
    class TypeChar : Itype<char>
    {
        public char Value_ { get;set;}

        public TypeChar(char value_)
        {
            Value_ = value_;
        }
    }
}
