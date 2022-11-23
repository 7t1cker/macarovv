using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using согласование_один;


namespace Program
{

    class Program
    {
        public static string tipo = "", ap = "", pp = "", ip = "", app = ""; public static short ao = -1; public static int lopch = 0;
        static public LinkedList<peaple[]> Sbor = new LinkedList<peaple[]>();
        static public peaple [] хранилище = new peaple [2];
        static public int count = 0;
        static public int[] unit_point;
        static void Main()
        {
            pik();
        }
        public static void pik()
        {
            Console.WriteLine();
            fam.call_collec(0);
            string re = Console.ReadLine();
            if (Anti_frod.chek_int(re) == false) { pik(); }
            else
            {
                int a = int.Parse(re);
                switch (a)
                {
                    default: pik(); break;
                    case 1:
                        fam.call_collec(1);
                        tipo = Console.ReadLine();
                        if (Anti_frod.chek_int(tipo) == false) { pik(); }
                        a = int.Parse(tipo);
                        if (a == 1) { Console.Clear(); auto_zap(); }
                        else if (a == 2) { Console.Clear(); unit_point = new int[2]; cliker(); regulator(); }
                        else if (a == 3) { nedo(); }
                        else { pik(); }

                        if (Sbor.Count > 1) { sort(); }
                        pik();
                        break;
                    //case 2: mer(); break;
                    case 3:
                        if (Sbor.Count != 0)
                        {
                            foreach (var c in Sbor) { for (int i = 0; i < 2; i++) { c[i].stat(); } }
                        }
                        pik(); break;
                    case 4:

                        Console.Clear();
                        if (Sbor.Count != 0)
                        {
                            foreach (var c in Sbor)
                            { c[0].ASUj(); }
                        }
                        pik(); break;
                    case 5: zapolniphe.Zapolni(); pik(); break;
                    case 9: return;
                }
                //static void mer()
                //{
                //    Console.WriteLine("1. Олимпиада");
                //    int a = int.Parse(Console.ReadLine());
                //    switch (a)
                //    {
                //        case 1: olimp we = new olimp(хранилище); pik(); break;
                //    }
                //}
            }
        }
        static void sort()
        {
            if (Sbor.Count > 1)
            {
                short[] mass = new short[Sbor.Count];
                int i = 0;
                foreach (var c in Sbor) { mass[i] = c[0].o; i++; }
                var len = mass.Length;
                for (var q = 1; q < len; q++)
                {
                    for (var j = 0; j < len - q; j++)
                    {
                        if (mass[j] > mass[j + 1])
                        {
                            Swap(ref mass[j], ref mass[j + 1]);
                        }
                    }
                }
                int ooop = 0;


                LinkedList<peaple[]> Sbor_2 = new LinkedList<peaple[]>();
                
                
                    for (int qwe = 0; qwe < mass.Length; qwe++) {
                    foreach (var c in Sbor) { if (c[0].o == mass[qwe] && c[0].Copka != true) { Sbor_2.AddLast(c); c[0].Copi(); } }
                }
                Sbor = Sbor_2;
                foreach (var c in Sbor) { c[0].Copi(); }
            }
        }
        static void Swap(ref short e1, ref short e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        static void cliker()
        {
            Console.WriteLine("Введите данные");
            //string tipo = "", ap = "", pp = "", ip = "", app = ""; short ao = -1; 
            void onet()
            {
                Console.WriteLine("Введите имя: ");
                tipo = Console.ReadLine();
                if (Anti_frod.chek_str(tipo, 1) == false) { Console.WriteLine("что то не так"); onet(); }
                lopch = Anti_frod.Barka(tipo);
            }
            onet();
            void dou()
            {
                Console.WriteLine("Введите фамилию: ");
                ap = Console.ReadLine();
                if (Anti_frod.chek_str(ap, 1) == false) { dou(); }
                if (Anti_frod.Barka(ap) != lopch) { dou(); }
            }
            dou();
            void kiko()
            {
                Console.WriteLine("Введите Очество: ");
                pp = Console.ReadLine();
                if (Anti_frod.chek_str(pp, 1) == false) { kiko(); }
                if (Anti_frod.Barka(pp) != lopch) { kiko(); }
            }
            kiko();
            void rorap()
            {
                Console.WriteLine("Возраст: ");
                app = Console.ReadLine();
                if (Anti_frod.chek_int(app) == false) { rorap(); }
                ao = short.Parse(app);
            }
            rorap();
        }
        static void auto_zap()
        {

            Футбол чел = new Футбол(); хранилище[count] = чел; count++;
            Волейбол чел2 = new Волейбол(); хранилище[count] = чел2; count++;
            Sbor.AddLast(хранилище);
            хранилище = new peaple[10]; count = 0;
            Console.Clear();
        }
        static void regulator()
        {
            for (int i = 0; i < unit_point.Length; i++) { unit_point[i] = 0; }
            void cirk()
            {
                fam.call_collec(2);
                string re = Console.ReadLine();
                if (Anti_frod.chek_int(re) == false) { Console.WriteLine("Тут  не цифры"); cirk(); }
                int a = int.Parse(re);
                if (a < 1 || a > 2) { Console.WriteLine("Только такой и спорт есть"); cirk(); }
                if (a == 1) { unit_point[0] = 1; }
                if (a == 2) { unit_point[1] = 1; }
                Kio();
            }
            cirk();
            void Kio()
            {
                fam.call_collec(3);
                string re = Console.ReadLine();
                if (Anti_frod.chek_int(re) == false) { Console.WriteLine("Тут  не цифры"); regulator(); }
                int a = int.Parse(re);
                if (a == 1) { Console.Clear(); cirk(); }
                else if (a == 2) { claim_pop(); }
                else { Console.Clear(); cirk(); }
            }
            
        }
        static void nedo()
        {
            void rorap()
            {
                Console.Write("Введите возраст: ");
              
                app = Console.ReadLine();
                Console.WriteLine();
                if (Anti_frod.chek_int(app) == false) { rorap(); }
                ao = short.Parse(app);
            }
            rorap();
            Футбол чел = new Футбол(ao); хранилище[count] = чел; count++;
            Волейбол чел2 = new Волейбол(ao); хранилище[count] = чел2; count++;
            Sbor.AddLast(хранилище);
            хранилище = new peaple[10]; count = 0;
            Console.Clear();

        }
        static void claim_pop()
        {
            if (unit_point[0] == 1)
            {
                Футбол чел = new Футбол(ap, tipo, pp, ao, lopch, true); хранилище[count] = чел; count++;
            }
            else
            {
                Футбол чел = new Футбол(ap, tipo, pp, ao, lopch, false); хранилище[count] = чел; count++;
            }
                if (unit_point[1] == 1)
            {
                Волейбол чел = new Волейбол(ap, tipo, pp, ao, lopch, true); хранилище[count] = чел; count++;
            }
            else
            {
                Волейбол чел = new Волейбол(ap, tipo, pp, ao, lopch, false); хранилище[count] = чел; count++;
            }
            Sbor.AddLast(хранилище);
            хранилище = new peaple[10]; count = 0;
            Console.Clear();
        }
    }
}
