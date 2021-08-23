using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_3
{
    class TypeManagement<T> where T : Itype<T>
    {
        private T[] List_ = new T[10];
        public int Count_ = 0;
        public void Add_(T obj) 
        {
            List_[Count_++] = obj.Value_;
            Array.Sort(List_);
        }
        public T this[int num]
        {
            get
            {
                return List_[num].Value_;
            }
        }
    }
}
