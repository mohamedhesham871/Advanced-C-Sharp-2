using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__2
{
    internal class FixedSizeList<T>
    {
        static int SizeOFList;
        static T[] array;
         int count=0;
        //Constructor
        public FixedSizeList(int Size)
        {
            SizeOFList = Size;
            array = new T[SizeOFList];
        }
         public T  GetItem(int index)
         {
            if (index <= (count-1) && index>=0) return array[index];
            else 
                 throw new Exception("Out of Range ");
         }

         public void Add(T item)
         {
            if (count  >= SizeOFList) 
                throw new Exception("Can't Add will List is FULL");
            else
            {
               array[count++] = item;
            }
         }
    }
}
