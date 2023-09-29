using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public interface Collection
    {
        void add(object e);

        void Remove(object e);

        bool contain(object e);

        int Size();
        
        bool IsEmpty();
    }

}
