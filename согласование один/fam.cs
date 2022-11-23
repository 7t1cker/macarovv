using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace согласование_один
{
    internal class fam
    {
       public  static void call_collec(int a)
        {
            if (a == 0)
            {
                
                Console.WriteLine("1. Cоздать спортсмена");
                Console.WriteLine("2. мероприятие");
                Console.WriteLine("3. Статусы");
                Console.WriteLine("4. Cпорсмены");
                Console.WriteLine("5. Изменить данные");
                Console.WriteLine("9. выйти");
            }
            else if (a == 1)
            {
                Console.Clear();
                Console.WriteLine("1. Создать пустого спортсмена");
                Console.WriteLine("2. Полностью записать");
                Console.WriteLine("3. Вписать только возраст и спорт");
            }
            else if (a == 2)
            {
                Console.Clear();
                Console.WriteLine("Выберити спорт");
                Console.WriteLine("1. Футбол");
                Console.WriteLine("2. Волкейбол");
            }
            else if (a == 3)
            {
                Console.Clear();
                Console.WriteLine("Хотите ещё добавить спорт?");
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Нет");
            }
            else if (a == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Что хотите изменить?");
                Console.WriteLine("1. Имя");
                Console.WriteLine("2. Фамилия");
                Console.WriteLine("3. Очество");
                Console.WriteLine("4. Возраст");
               // Console.WriteLine("5. Спортивные навыки");
                Console.Write("Ваш выбор: ");

            }
        }
        
    }
    
}
