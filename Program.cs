using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            string one = "Nastya";
            string two = "Sakun";
            int comp = String.Compare(one, two);

            if (comp < 0)
                Console.WriteLine("первая строка перед второй в алфавите");
            else
                Console.WriteLine("вторая строка перед первой в алфавите");
            //b

            string oneB = "abc";
            string twoB = "def";
            string threeB = "ghi";
            string concat = String.Concat(oneB, twoB, threeB);
            string copy = String.Copy(threeB);
            string sub = oneB.Substring(1,2);
            string [] split = twoB.Split(new char[] { ',' } );

            string splt = null;

            foreach (var temp in split)
            {
                splt += temp;
            }

            string insert = oneB.Insert(2, "-");
            string remove = twoB.Remove(2, 1);
            Console.WriteLine(" Сцепление: " + concat+"\n"+" Копирование: "+copy+"\n"+" Выделение подстроки: "+ sub+"\n"+" Разделение строки: "+splt+"\n Вставка подстроки в заданную позицию: "+ insert+"\n Удаление подстроки: "+remove);

            //с

            string oneC = "";
            string twoC = null;
            string threeC = "Nastya";
            Console.WriteLine("\0"+String.Concat(threeC, twoC) +";"+ String.Concat(oneC, twoC)+";"+ String.Concat(oneC, twoC).Length);

            //d

            StringBuilder oneD = new StringBuilder("LOVE", 10);
            oneD.Append(new char[] { 'i', 's', 'M', 'A', 'D', 'N', 'E', 'S', 'S' });
            Console.WriteLine("\0"+oneD);
            oneD.Insert(0, "OUR_");
            Console.WriteLine("\0"+oneD);
            oneD.Remove(0, 3);
            Console.WriteLine("\0" + oneD);
            oneD.Insert(5, "_");
            oneD.Insert(8, "_");
            Console.WriteLine("\0"+oneD);
        }
    }
}
