using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Threading.Channels;

namespace Tasklar18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();   
            //Task9(); 
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            //VurmaCedveli();
        }

        static void Task1()
        {
        l1:
            Console.Write("Daxilinde a ve b simvolu olan istenilen metn daxil edin: ");
            string Metn = Console.ReadLine();


            int aSayi = 0;
            int bSayi = 0;

            foreach (char a in Metn)
            {
                if (a == 'a')
                {
                    aSayi++;
                }
            }
            foreach (char b in Metn)
            {
                if (b == 'b')
                {
                    bSayi++;
                }
            }
            if (aSayi == 0 || bSayi == 0)
            {
                Console.WriteLine("Metnde a ve ya b herfinin sayi 0dir.");
                goto l1;
            }
            Console.WriteLine($"Metndeki a simvollarinin sayi {aSayi}, b simvollarinin sayi {bSayi}-dir");
            int nisbet = aSayi / bSayi;
            Console.WriteLine($"Metndeki a ve b simbollarinin nisbeti: {nisbet}");
        }
        static void Task2()
        {
        l2:
            Console.Write("Metn daxil edin:");
            string Metn = Console.ReadLine();
            char aSimvolu = 'a';
            for (int i = 0; i < Metn.Length; i += 2)
            {


                if (Metn[i] != aSimvolu)
                {
                    Console.WriteLine("Tek yerde duran simvollarin hamisi a deyil!");
                    goto l2;
                }


            }
            Console.WriteLine("Tek yerde duranlarin hamisi a simvoludur!");

        }
        static void Task3()

        {
            Console.Write("Metn daxil edin: ");
            string Metn = Console.ReadLine();

            int bSayi = 0;

            for (int i = 0; i < Metn.Length; i += 2)
            {


                if (Metn[i] == 'b')
                {
                    bSayi++;
                }
            }

            Console.WriteLine($"Tek yerde duran b simvollarin sayi: {bSayi}");



        }
        static void Task4()
        {
            Console.Write("Metn daxil edin: ");
            string Metn = Console.ReadLine();
            int a = Metn.IndexOf('a');
            if ((a + 1) % 2 == 0)

            {
                Console.WriteLine("ilk rast gelinen a simvolunun yeri cut ededdir ");
            }
            else
            {
                Console.WriteLine("Ilk rast gelinen a simvolunun yeri tek ededdir ");
            }
        }
        static void Task5()
        {
            Console.Write("Icinde a, b, c simvollari olan metn daxil edin: ");
        l5:
            string Metn = Console.ReadLine();
            int a = Metn.IndexOf('a');
            int b = Metn.IndexOf('b');
            int c = Metn.IndexOf('c');



            if (a == -1 || b == -1 || c == -1)
            {
                Console.WriteLine("Simvollardan hansisa yoxdur!");
                goto l5;
            }
            else
            {


                if (a < c && a < b)
                {
                    Console.WriteLine($"Ilk gelen simvol a-dir.");
                }
                else if (c < a && c < b)
                {
                    Console.WriteLine("Ilk gelen simvol c-dir");
                }
                else if (b < a && b < c)
                {
                    Console.WriteLine("Ilk gelen simvol b-dir");
                }
            }


        }
        static void Task6()
        {
            string Metn = Console.ReadLine();
            int a = Metn.IndexOf('a');
            int b = Metn.LastIndexOf('a');
            if (a == b)
            {
                Console.WriteLine("a simvolunun sol ve sag terefden indexleri eynidir");
            }
            else
            {
                Console.WriteLine("a simvolunun sol ve sag terefden indexleri eyni deyil");
            }


        }
        static void Task7()
        {
            Console.Write("Icinde a, b, c simvollari olan metn daxil edin: ");
        l8:
            string Metn = Console.ReadLine();
            int a = Metn.IndexOf('a');
            int b = Metn.IndexOf('b');
            int c = Metn.IndexOf('c');



            if (a == -1 || b == -1 || c == -1)
            {
                Console.WriteLine("Simvollardan hansisa yoxdur!");
                goto l8;
            }
            else
            {
                if (a < b && b < c)
                {
                    Console.WriteLine("a simvolu bden qabag ve b simvolu c simvolundan qabag gelir");

                }
                else
                {
                    Console.WriteLine("A simvolu bden qabag ve b simvolu c simvolundan qabag gelmelidir!");
                    goto l8;
                }
            }
        }
        static void Task8()
        {
            Console.Write("Metn daxil edin: ");
            string Metn = Console.ReadLine();
            int a = Metn.IndexOf('a');
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Metn[a + 1]);
            }

        }
        static void Task9()
        {
            Console.Write("Metn daxil edin: ");
        l10:
            string Metn = Console.ReadLine();
            int a = Metn.Length;
            char a1 = Metn[a - 1];
            char a2 = Metn[a - 2];
            char a3 = Metn[a - 3];

            char b1 = Metn[0];
            char b2 = Metn[1];
            char b3 = Metn[2];

            if (a1 == b1 && a2 == b2 && a3 == b3)
            {
                Console.WriteLine("Verilmis metindeki ilk 3 simvol son 3 simvolun tersine formasiyla eynidir!");
            }
            else
            {
                Console.WriteLine("Eyni deyil!");
                goto l10;
            }
        }
        static void Task10()
        {
            Console.Write("Metn daxil edin: ");
            string Metn = Console.ReadLine();
            string Netice = "";
            foreach (char c in Metn)
            {
                if (!char.IsDigit(c))
                {
                    Netice += c;
                }
            }

            Console.WriteLine(Netice);
        }
        static void Task11()
        {
            Console.Write("Metn daxil edin: ");
            string Metn = Console.ReadLine();


            string deyisilmismetn = "";

            foreach (char c in Metn)
            {

                if (c == 'a')
                {
                    deyisilmismetn += 'b';
                }
                if (c == 'b')
                {
                    deyisilmismetn += 'a';
                }


                deyisilmismetn += c;
            }



            Console.WriteLine("Yeni metn: " + deyisilmismetn);
        }

        static void Task12()
        {
        l1:
            Console.Write("Metn daxil edin: ");
            string Metn = Console.ReadLine();


            int ailkindex = Metn.IndexOf('a');


            if (ailkindex != -1)
            {

                int asonindex = Metn.LastIndexOf('a');


                if (ailkindex == asonindex)
                {


                    Console.WriteLine(Metn);
                }


                string Metn1 = Metn.Substring(ailkindex + 1, asonindex - (ailkindex + 1));
                string Metn2 = Metn.Substring(0, ailkindex + 1) + Metn1.Replace("a", "") + Metn.Substring(asonindex);


                Console.WriteLine(Metn2);
            }

            else
            {
                Console.WriteLine("Metnde a simvolu yoxdur!");
                goto l1;
            }


        }

        static void Task13()
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char oldugumuzchar = text[i];
                if (i % 2 == 0)
                {
                    Console.Write(char.ToUpper(oldugumuzchar));
                }
                else
                {
                    Console.Write(char.ToLower(oldugumuzchar));
                }
            }
        }

        static void Task14()
        {
            string Metn = "salam";
            for (int i = 0; i < Metn.Length - 1; i++)
            {
                char x = Metn[i + 1];

                if (i % 2 == 0)
                {
                    Metn = Metn.Remove(i, 1);
                    Metn = Metn.Insert(i, Char.ToUpper(x).ToString());
                }
            }


        }
        static void VurmaCedveli()
        {
            for (int a = 0; a <= 10; a++)
            {
                for (int b = 0; b <= 10; b++)
                {
                    Console.WriteLine("{0}x{1}", a, b, a * b);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

    }
}



    
