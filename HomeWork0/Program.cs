namespace HomeWork0
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tapsiriq.1

            //int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var nQuery =
            //    from Num in n1
            //    where (Num % 2) == 0
            //    select Num;
            //foreach (int Num in nQuery)
            //{
            //    Console.Write("{0} ", Num);
            //}

            //Tapsiriq.2

            //int[] n1 = {
            //    1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            //};


            //var nQuery =
            //from Num in n1
            //where Num > 0
            //where Num < 12
            //select Num;
            //foreach (var Num in nQuery)
            //{
            //    Console.Write("{0}  ", Num);
            //}

            //Tapsiriq.3

            //var arr1 = new[] { 3, 9, 2, 8, 6, 5 };


            //var sqNo = from int Number in arr1
            //           let SqrNo = Number * Number
            //           where SqrNo > 20
            //           select new { Number, SqrNo };

            //foreach (var a in sqNo)
            //    Console.WriteLine(a);

            //Console.ReadLine();

            //Tapsiriq.4

            //int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            //var n = from x in arr1
            //        group x by x into y
            //        select y;
            //foreach (var arrNo in n)
            //{
            //    Console.WriteLine("Number " + arrNo.Key + " görünür " + arrNo.Count() + " defe");
            //}

            //Tapsiriq.5

            //string str;

            //Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
            //Console.Write("\n----------------------------------------------------------------------------\n");
            //Console.Write("Input the string : ");
            //str = Console.ReadLine();
            //Console.Write("\n");

            //var FreQ = from x in str
            //           group x by x into y
            //           select y;
            //Console.Write("The frequency of the characters are :\n");
            //foreach (var ArrEle in FreQ)
            //{
            //    Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            //}

            //Tapsiriq.6

            //string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //Console.Write("\nLINQ : Name of the days of a week : ");
            //Console.Write("\n------------------------------------------------\n");


            //var days = from WeekDay in dayWeek
            //           select WeekDay;
            //foreach (var WeekDay in days)
            //{
            //    Console.WriteLine(WeekDay);
            //}
            //Console.WriteLine();

            //Tapsiriq.7

            //int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            //var m = from x in nums
            //        group x by x into y
            //        select y;

            //foreach (var arr in m)
            //{
            //    Console.WriteLine(arr.Key + "\t" + arr.Sum() + "\t\t\t" + arr.Count());
            //}
            //Console.WriteLine();

            //Tapsiriq.8

            //int i = 0;
            //List<int> templist = new List<int>();
            //templist.Add(60);
            //templist.Add(90);
            //templist.Add(300);
            //templist.Add(22);
            //templist.Add(166);
            //templist.Add(666);
            //templist.Add(15);

            //Console.Write("\nLINQ : Create a list of numbers and display the numbers greater than 80 : ");
            //foreach (var lstnum in templist)
            //{
            //    Console.Write(lstnum + " ");
            //}
            //List<int> FilterList = templist.FindAll(x => x > 80 ? true : false);
            //Console.WriteLine("\n\nThe numbers greater than 80 are : ");
            //foreach (var num in FilterList)
            //{
            //    Console.WriteLine(num);
            //}

            //Tapsiriq.9

            //int i = 0;
            //int memlist, n, m;
            //List<int> templist = new List<int>();
            //Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : ");
            //Console.Write("\n----------------------------------------------------------------------------------------\n");

            //Console.Write("Input the number of members on the List : ");
            //n = Convert.ToInt32(Console.ReadLine());

            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("Member {0} : ", i);
            //    memlist = Convert.ToInt32(Console.ReadLine());
            //    templist.Add(memlist);
            //}

            //Console.Write("\nInput the value above you want to display the members of the List : ");
            //m = Convert.ToInt32(Console.ReadLine());

            //List<int> FilterList = templist.FindAll(x => x > m ? true : false);
            //Console.WriteLine("\nThe numbers greater than {0} are : ", m);
            //foreach (var num in FilterList)
            //{
            //    Console.WriteLine(num);
            //}

            //Tapsiriq.10

           

        }
    }
}