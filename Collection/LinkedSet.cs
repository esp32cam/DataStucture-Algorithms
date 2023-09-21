using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class LinkedSet : LinkHeaderCollection, Set
    {
        public new void add(object e)
        {
            if (!base.contain(e))
                base.add(e);
        }
    }
}
