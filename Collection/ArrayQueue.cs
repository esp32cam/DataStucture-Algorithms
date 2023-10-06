using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class ArrayQueue : Queue
    {
        private int cap;
        private int SIZE;
        private object[] data;
        private int firstindex;

        private void ensureCapacity()
        {
            object[] tempdata;
            if (SIZE + 1 > data.Length)

                //Increase Capacity
                tempdata = new object[2 * data.Length];
            else if (data.Length > cap && data.Length > 2 * SIZE)
                //Decrease Capacity
                tempdata = new object[data.Length / 2 + 1];
            else return;
            for (int i = 0, j = firstindex; i < SIZE; i++, j = (j + 1) % data.Length)
                tempdata[i] = data[j];
            firstindex = 0;
            data = tempdata;
        }
        public object dequeue()
        {
            object e = peek();
            data[firstindex] = null;
            firstindex = (firstindex + 1) % data.Length;
            SIZE--;
            return e;
        }

        public void enqueue(object e)
        {
            ensureCapacity();
            int k = (firstindex + SIZE) % data.Length;
            data[k] = e;
            SIZE++;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            if (isEmpty())
                throw new System.MissingMemberException();
            return data[firstindex];
        }

        public int size()
        {
            return SIZE;
        }
    }
}
