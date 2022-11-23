using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace согласование_один
{
    internal class zapolniphe
    {
        public static string[] familop = new string[] { "Смирнов", "Иванов", "Кузнецов", "Соколов", "Попов", "Лебедев", "Козлов", "Новиков", "Морозов", "Ершов" };
        public static string[] nameop = new string[] { "Егор", "Тимофей", "Ваня", "Женя", "Влад", "Андрей", "Вова", "Миша", "Сергей", "Илья" };
        public static string[] otchestvoop = new string[] { "Александрович", "Игоревич", "Сергеевич", "Геннадьевич", "Дмитриевич", "Никитич", "Ильич", "Константинович", "Палыч", "Саныч" };
        static public void Zapolni()
        {
            Console.Clear();
            int u = 1;
            foreach (var c in Program.Program.Sbor) { Console.Write("{0}. ", u); c[0].ASUj(); u++; }
            Console.WriteLine("Выберете спортсмена");
            Console.Write("Ваш выбор: ");
            string re = Console.ReadLine(); Console.WriteLine();
            if (Anti_frod.chek_int(re) == false) { Zapolni(); }
            int pik = int.Parse(re);
            if (pik < 0 || pik > Program.Program.Sbor.Count) { Zapolni(); }
            fam.call_collec(4);
            re = Console.ReadLine(); short Age = 0; string tipo = ""; int lopch = -1;
            if (Anti_frod.chek_int(re) == false) { Zapolni(); }
            int a = int.Parse(re);
            switch (a)
            { 
                case 1: onet(); break;
                case 2: net(); break;
                case 3: netg(); break;
                case 4: rorap(); break;
                case 5:key_kleam(); break;
            }


            void onet()
            {
                Console.WriteLine("Введите имя: ");
                tipo = Console.ReadLine();
                if (Anti_frod.chek_str(tipo, 1) == false) { Console.WriteLine("что то не так"); onet(); }
                lopch = Anti_frod.Barka(tipo);

                GEng();
            }
            void net()
            {
                Console.WriteLine("Введите фамилию: ");
                tipo = Console.ReadLine();
                if (Anti_frod.chek_str(tipo, 1) == false) { Console.WriteLine("что то не так"); net(); }
                lopch = Anti_frod.Barka(tipo);

                GEng();
            }
            void netg()
            {
                Console.WriteLine("Введите очество: ");
                tipo = Console.ReadLine();
                if (Anti_frod.chek_str(tipo, 1) == false) { Console.WriteLine("что то не так"); netg(); }
                lopch = Anti_frod.Barka(tipo);

                GEng();
            }
            void rorap()
            {
                Console.Write("Введите возраст: ");

                tipo = Console.ReadLine();
                Console.WriteLine();
                if (Anti_frod.chek_int(tipo) == false) { rorap(); }
                Age = short.Parse(tipo);
            }
            void key_kleam()
            {

            }
            void GEng()
            {
                int qwe = 1;
                if (a == 1)
                {
                    foreach (var c in Program.Program.Sbor) {
                        if (pik == qwe)
                        {
                            if (c[0].Point_langch == lopch) { c[0].Name = tipo; } else { Console.WriteLine("Не подошло по языку"); }
                        } qwe++; 
                    }
                }
                if (a == 2)
                {
                    foreach (var c in Program.Program.Sbor)
                    {
                        if (pik == qwe)
                        {
                            if (c[0].Point_langch == lopch) { c[0].Famils = tipo; } else { Console.WriteLine("Не подошло по языку"); }
                        }
                        qwe++;
                    }
                }
                if (a == 3)
                {
                    foreach (var c in Program.Program.Sbor) {
                        if (pik == qwe)
                        {
                            if (c[0].Point_langch == lopch) { c[0].Ochectvo = tipo; } else { Console.WriteLine("Не подошло по языку"); }
                        }
                        qwe++;
                    }
                }
                if (a == 4)
                {
                    foreach (var c in Program.Program.Sbor) {
                        if (pik == qwe) { c[0].Age = Age; } qwe++; }
                }
            }
        }

    }
}
