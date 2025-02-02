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

        static void Main(string[] args)
        {
            #region First-Point
            ArrayList names = new ArrayList();
            names.Add("Mohamed Hesham");
            names.Add("omar");
            names.Add("ali");
            names.Add("Amr");
            names.Add(2025);
            MyReverse(names);
            //********************
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
