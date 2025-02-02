using System.Collections;

namespace Advanced_C__2
{
    internal class Program
    {
        #region First One
        public static void Swap(int x, int y, ArrayList arr)
        {
            object? Temp = arr[x];
            arr[x] = arr[y];
            arr[y] = Temp;

        }
        public static void MyReverse(ArrayList arr)
        {
            int start = 0;
            int end = arr.Count - 1;
            while (start < end)
            {
                Swap(start, end, arr);
                start++;
                end--;
            }
        }
        #endregion

        #region Second
        static public List<int> Even(List<int> num)
        {
            List<int> list = new List<int>();
            for(int i=0;i<num.Count;i++)
            {
                if (num[i]%2==0)
                    list.Add(num[i]);
            }
            return list;
        }
        #endregion
        static void Main(string[] args)
        {
            #region First-Point
            //ArrayList names = new ArrayList();
            //names.Add("Mohamed Hesham");
            //names.Add("omar");
            //names.Add("ali");
            //names.Add("Amr");
            //names.Add(2025);
            //MyReverse(names);
            ////********************
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Second-Point
            List<int> number = new List<int>();
            number.AddRange([1,2,3,4,5,6,7,8,9,10]);
            List<int>EvenNumber= Even(number);

            foreach(int item in EvenNumber)
                Console.WriteLine(item);
            #endregion
        }
    }
}
