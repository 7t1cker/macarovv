using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace согласование_один
{
    public class мероприятия
    {
        protected string nam_mer;
       

    }
    public class olimp : мероприятия
    {
        //public olimp(Футбол[] d )
        //{
        //    nam_mer = "Олимпиада по футболу";
        //    Random r = new Random();
        //    int u = r.Next(0,2);
        //    Console.WriteLine(u);
        //    d[u].solt("Победа");
            
        //}
        ~olimp()
        {
            Console.WriteLine("сломлся");
        }
        //olimp(Волейбол [] d )
        //{

        //}-
    }
}
