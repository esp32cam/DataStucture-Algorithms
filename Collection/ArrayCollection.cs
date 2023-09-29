using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection;

namespace Collection
{
    public class ArrayCollection : Collection
    {
        private int SIZE;
        private object[] data;
        private int cap;

        public ArrayCollection(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }
        private void ensureCapacity()
        {
            if (SIZE++ > data.Length)
            {
                object[] tempdata = new object[2 * SIZE];
                for (int i = 0; i < SIZE; i++)
                    tempdata[i] = data[i];
                data = tempdata;
            }
        }

        public void add(object e)
        {
            ensureCapacity();
            data[SIZE++] = e;
        }
        private int indexOf(object e)
        {
            for (int i = 0; i < SIZE; i++)
                if (data[i].Equals(e))
                    return i;
            return -1;
        }
        public bool contains(object e)
        {
            return indexOf(e) != -1;
        }
        

        public int Size()
        {
            return SIZE;
        }

        public bool IsEmpty()
        {
            return SIZE == 0;
        }

        public void Remove(object e)
        {
            int i = indexOf(e);
            if (i != -1)
            {
                data[i] = data[--SIZE];
                data[SIZE] = null;
            }
                
                
        }
        public void contain(object e)
        {
            throw new NotImplementedException();
        }

        public void remove(object e)
        {
            throw new NotImplementedException();
        }

        bool Collection.contain(object e)
        {
            throw new NotImplementedException();
        }

    }
}
