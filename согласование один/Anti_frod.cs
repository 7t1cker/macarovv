using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace согласование_один
{
    internal class Anti_frod
    {
       public static int Barka(string o)
        {
            if (o[0] >= 'А' && o[0] <= 'ё')
            {
                return 1;
            }
            else { return 2; }
        }
        public static bool chek_int(string o)
        {
            if (o == null) { return false; }
            if (o == "") { return false; }
            int u = o.Length;
            int q = 0;
            if (u > 3) { Console.WriteLine("Ну не надо так"); return false; }// Выбираете максимально планируемое число в данном случае у меня 999 добовляя еденицу вы делаете + 9 
            for (int i = 0; i < o.Length; i++)
            {
                if (o[i] != '0' && o[i] != '1' && o[i] != '2' && o[i] != '3' && o[i] != '4' && o[i] != '5' && o[i] != '6' && o[i] != '7' && o[i] != '8' && o[i] != '9')
                {
                    q++; break;
                }

            }
            if (q == 0)
            {
                if (int.Parse(o) > 128 || int.Parse(o) == 0) { Console.WriteLine(); return false; }

                return true;
            }
            else { return false; }
        }
        public static bool chek_str(string o, short pop)
        {
            if (o == null) { return false; }
            if (o == "") { return false; }
            if (o.Length < 4) { return false; }
            char[] drive = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '@', '/', ',', '?', '.', '-', '_', '#', '^', '!', ' ', '*', ':', ' ' };
            for (int i = 0; i < drive.Length; i++)
            {
                if (drive[i] == o[0]) { return false; }
            }
            if (o[0] >= 'А' && o[0] <= 'ё')
            {
                Console.WriteLine("это русский");
                for (int i = 0; i < o.Length; i++)
                {
                    if (o[i] < 'А' || o[i] > 'ё')
                    {

                        return false;
                    }
                }
                if (pop == 1)
                {
                    if (o[0] >= 'а' && o[0] <= 'ё')
                    {
                        Console.WriteLine("Требуется большая буква");
                        return false;
                    }
                }
                return true;
            }
            else
            {

                for (int i = 0; i < o.Length; i++)
                {
                    if ((o[i] < 'A' || o[i] > 'z') || o[i] == '[' || o[i] == ']' || o[i] == '^' || o[i] == '_' || o[i] == '`')
                    {
                        Console.WriteLine("Языковой барьер английский");
                        return false;
                    }
                    if (pop == 1)
                    {
                        if (o[0] >= 'a' && o[0] <= 'z')
                        {
                            Console.WriteLine("Требуется большая буква");
                            return false;
                        }
                    }
                }
                return true;
            }
        }
        public static void int_vvod(string prov)
        {
            char[] op = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            short c = 0;
            for (int i = 0; i < prov.Length; i++)
            {
                for (int q = 0; q < op.Length; q++)
                {
                    if (prov[i] == op[q]) { c++; break; }
                }
            }
            if (c != prov.Length) {  }
        }
    }
}
