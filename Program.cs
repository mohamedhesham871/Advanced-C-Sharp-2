using System.Collections;
using System.Net.Http.Headers;

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

        #region four
        static public int FirstNonRepeated(Dictionary<char,int> keyValuePairs,string text)
        {
            foreach (var item in keyValuePairs)
            {
                if (item.Value == 1)
                    return text.IndexOf(item.Key);
            }
            return -1;
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
            //List<int> number = new List<int>();
            //number.AddRange([1,2,3,4,5,6,7,8,9,10]);
            //List<int>EvenNumber= Even(number);

            //foreach(int item in EvenNumber)
            //    Console.WriteLine(item);
            #endregion

            #region Three
            // FixedSizeList<int> list = new FixedSizeList<int>(3);
            // list.Add(3);
            // list.Add(4);
            // list.Add(5);
            // //list.Add(6);//Exception
            // list.GetItem(0);
            // list.GetItem(1);
            // list.GetItem(2);
            //// list.GetItem(3);//Exception
            #endregion

            #region Four
            //Console.WriteLine( "Enter Any String to Find Non-Repeated char");
            //string text= Console.ReadLine();
            //Dictionary<char,int> dic = new Dictionary<char, int>();
            //foreach(char c in text)
            //{

            //    if (dic.ContainsKey(c))
            //        dic[c]++;
            //    else
            //    dic.Add(c, 1);
            //}
            //Console.WriteLine("Index : "+FirstNonRepeated(dic,text));



            #endregion
            #region Five
            
            #endregion

            #region Five
            int Size = int.Parse(Console.ReadLine());
            int NumberOFQuery =int.Parse(Console.ReadLine());
            List<int> numbers= new List<int>(Size);
            for(int i=0;i<Size;i++)
            {
                Console.WriteLine("Enter number in List : ");
               numbers.Add(int.Parse(Console.ReadLine()));
            }
            for(int i=0;i<NumberOFQuery;i++)
            {
                Console.WriteLine("Enter number to Compare");
                int x =int.Parse(Console.ReadLine());
                int countGreater = 0;
                for(int j=0;j<numbers.Count;j++)
                {
                    if(numbers[j]>x)countGreater++;
                }
                Console.WriteLine("number is "+countGreater);
            }
            
            #endregion

        }
    }
}
