using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace MergeTwoList
{
    //You are given two sorted lists list1 and list2.
    //Merge the two lists into one sorted list.
    public class Program
    {
        static List<int> mergedList = new List<int>();
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 4 };
           List<int> list2 = new List<int> { 1 , 3, 4};
            Merging(list1, list2);
            Console.WriteLine(String.Join(" ",mergedList));


        }
        public static void Merging(List<int> list1, List<int> list2)
        {
            int count;
            if (list1.Count == list2.Count) count = list1.Count;
            else if (list1.Count < list2.Count) count = list1.Count;
            else count = list2.Count;
            for (int i = 0; i < count; i++)
            {
                if (list1[i] < list2[i])
                {
                    mergedList.Add(list1[i]);
                    mergedList.Add(list2[i]);
                }
                else
                {
                    mergedList.Add(list2[i]);
                    mergedList.Add(list1[i]);
                }
            }
            if (list1.Count > count)
            {
                for (int i = count;i<list1.Count;i++)
                {
                    mergedList.Add(list1[i]);
                }
{ }         }
            else if(list2.Count>count)
            {
                for (int i = count; i < list2.Count; i++)
                {
                    mergedList.Add(list2[i]);
                }
            }
        }
    }
}
