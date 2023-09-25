using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class ArrayList : List
    {
        private int SIZE;
        private object[] data;
        private int cap;

        public ArrayList(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }

        private void ensureCapacity()
        {
            if (SIZE + 1 > data.Length)
            {
                object[] tempdata = new object[2 * SIZE];
                for (int i = 0; i < SIZE; i++)
                    tempdata[i] = data[i];
                data = tempdata;
            }
        }
        public void add(int index, object e)
        {
            ensureCapacity();
            for (int i = SIZE; i > index; i--)
                data[i] = data[i - 1];
            data[index] = e;
            SIZE++;
            throw new NotImplementedException();
        }

        public void remove(int index)
        {
            if (index >= SIZE) return;
            for (int i = index + 1; i < SIZE; i++)
                data[i - 1] = data[i];
            data[--SIZE] = null;
            throw new NotImplementedException();
        }

        public void remove(object e)
        {
            int i = indexOf(e);
            if (i > -1)
                remove(i);
            throw new NotImplementedException();
        }

        public void set(int index, object e)
        {
            data[index] = e;
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }

        public void add(object e)
        {
            add(SIZE, e);
            throw new NotImplementedException();
        }

        public bool contain(object e)
        {
            throw new NotImplementedException();
        }

        public object get(int index)
        {
            return data[index];
            throw new NotImplementedException();
        }

        public int indexOf(object e)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }
}
