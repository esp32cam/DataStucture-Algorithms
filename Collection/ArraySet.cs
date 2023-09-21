﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection;

namespace Collection
{
    public class ArraySet : ArrayCollection, Set
    {
        public ArraySet(int cap) : base(cap) { }
        public new void add(object e)
        {
            if (!base.contains(e))
                base.add(e);
        }
    }
}
