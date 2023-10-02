using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//hi
namespace Collection
{
    public class ArrayStack : Stack
    {
    
        private int SIZE;
        private object[] data;
        private int cap;

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
        public ArrayStack(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            if(isEmpty())
                throw new System.MissingMemberException();
            return data[SIZE-1];
        }

        public object pop()
        {
            object e = peek();
            data[--SIZE] = null;
            return e;
        }

        public void push(object e)
        {
            ensureCapacity();
            data[SIZE] = e;
        }

        public int size()
        {
            return SIZE;
          
        }
    }
}
