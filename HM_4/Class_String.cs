using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_4
{
    class Class_String : Interface1<string>
    {
        public string Id_ { get ; set ; }

        public Class_String(string id_)
        {
            Id_ = id_;
        }
    }
}
