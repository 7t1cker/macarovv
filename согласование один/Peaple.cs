using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace согласование_один
{
    

    public class peaple
    {
        protected string familis;
        protected string name;
        protected string ochectvo;
        protected short age;
        protected string sport;
        protected string mirovou_rekord;
        protected string ed_izmerenie;
        protected short point_sity;
        protected int point_langch;
        protected bool activ;
        protected bool copca = false;




        public string[] meru = new string[100];
        public int sot = 0;
        public void solt(string g)
        {
            meru[sot] = g; sot++;
        }
        public bool vvod_clov(string prov)
        {
            char[] op = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ', '`', '~', '?', '!', '@', '"', '№', '#' };
            if (prov == null) { return false; }
            for (int i = 0; i < prov.Length; i++)
            {
                for (int q = 0; q < op.Length; q++)
                {
                    if (prov[i] == op[q]) { return false; }
                }

            }
            return true;
        }
        public void ASUj()
        {
            Console.WriteLine($"{familis} {name} {ochectvo} {age}");
        }
        public void vvod_dannux(string familis, string name, string ochectvo)
        {
            if ((vvod_clov(familis) && vvod_clov(name) && vvod_clov(name)) == true)
            {
                this.name = name; this.familis = familis; this.ochectvo = ochectvo;
            }
            else { return; }
        }

        public virtual void check()
        {
            Console.WriteLine($"{ochectvo}");
            //Console.WriteLine($"{sport} {mirovou_rekord} {ed_izmerenie} {familis} {name} {ochectvo}");

            //for (int i = 0; i < 12; i++)
            //{
            //    if (meru[i] == null) { break; }
            //    Console.WriteLine(meru[i]);
            //}
        }
        public virtual void stat()
        {
            if (activ == true)
            {
                Console.WriteLine($"{familis} {name} {ochectvo} ");
            }
        }
       public short o
        {
            get { return age; }
        }
        public void Copi()
        {
            if (copca == false) { copca = true; }
            else { copca = false; }
        }
        public bool Copka
        {
            get { return copca; }
        }
        public string Famils
        {
            set { familis = value; }
        }
        public string Name
        {
            set { name = value; }
        }
        public int Point_langch
        {
            get { return point_langch; }
        }
        public string Ochectvo
        {
            set { ochectvo = value; }
        }
        public short Age
        {
            set { age = value; }
        }
    }
    public class Футбол : peaple
    {
        public Футбол(string familis, string name, string ochectvo, short age, int point_langch, bool activ)
        {
            this.familis = familis;
            this.name = name;
            this.ochectvo = ochectvo;
            this.age = age;
            this.point_langch = point_langch;
            this.activ = activ;

        }
        public Футбол()
        {
            Random random = new Random();
            familis = zapolniphe.familop[random.Next(0, 10)]; name = zapolniphe.nameop[random.Next(0, 10)]; ochectvo = zapolniphe.otchestvoop[random.Next(0, 10)]; age = Convert.ToInt16(random.Next(18, 45));
            point_langch = 1;
            if (random.Next(0, 2) == 1)
            {
                activ = false;
            }
            else { activ = true; }
        }
        public Футбол(short kert)
        {
            Random random = new Random();
            familis = zapolniphe.familop[random.Next(0, 10)]; name = zapolniphe.nameop[random.Next(0, 10)]; ochectvo = zapolniphe.otchestvoop[random.Next(0, 10)]; age = kert;
            point_langch = 1;
            if (random.Next(0, 2) == 1)
            {
                activ = false;
            }
            else { activ = true; }
        }
        //public Футбол(short age, string familis, string name, string ochectvo) : base("Футбол", "987", "Голы", familis, name, ochectvo)
        //{

        //}
        public override void stat()
        {
            if (activ == true)
            {
                Console.WriteLine("Футбол активен");
            }
        }
        public virtual void Trena()
        {
            Console.WriteLine("Тренеруется");
        }
       
    }
    public class Волейбол : peaple
    {
        //public override void Trena()
        //{
        //    Console.WriteLine("t,kfuy");
        //}
        public override void stat()
        {
            if (activ == true)
            {
                Console.WriteLine("Волейбол активен");
            }
        }

        public Волейбол(string familis, string name, string ochectvo, short age, int point_langch, bool activ)
        {
            this.familis = familis;
            this.name = name;
            this.ochectvo = ochectvo;
            this.age = age;
            this.point_langch = point_langch;
            this.activ = activ;

        }
        public Волейбол(short kert)
        {
            Random random = new Random();
            familis = zapolniphe.familop[random.Next(0, 10)]; name = zapolniphe.nameop[random.Next(0, 10)]; ochectvo = zapolniphe.otchestvoop[random.Next(0, 10)]; age = kert;
            point_langch = 1;
            if (random.Next(0, 2) == 1)
            {
                activ = false;
            }
            else { activ = true; }
        }
        public Волейбол()
        {
            Random random = new Random();
            familis = zapolniphe.familop[random.Next(0, 10)]; name = zapolniphe.nameop[random.Next(0, 10)]; ochectvo = zapolniphe.otchestvoop[random.Next(0, 10)]; age = Convert.ToInt16(random.Next(18, 45));
            point_langch = 1;
            if (random.Next(0, 2) == 1)
            {
                activ = false;
            }
            else { activ = true; }
        }
    }
    public class Баскетбол : Волейбол
    {

    }
    public class Плавонье : Баскетбол
    {

    }

    public class Художественная_гимнастика : Плавонье
    {

    }
    public class Хоккей_на_траве : Художественная_гимнастика
    {

    }
    public class Тхэквондо : Хоккей_на_траве
    {

    }
    public class Триатлон : Тхэквондо
    {

    }
    public class Теннис : Триатлон
    {

    }
    public class Стрельба_из_лука : Теннис
    {

    }
    public class Стрельба : Стрельба_из_лука
    {

    }
    public class Спортивная_гимнастика : Стрельба
    {

    }
    public class Софтбол : Спортивная_гимнастика
    {

    }
    public class Современное_пятиборье : Софтбол
    {

    }
    public class Скейтбординг : Современное_пятиборье
    {

    }
    public class Скалолазание : Скейтбординг
    {

    }
    public class Синхронное_плавание : Скалолазание
    {

    }
    public class Серфинг : Синхронное_плавание
    {

    }
    public class регби : Серфинг
    {

    }
    public class Прыжки_на_батуте : регби
    {

    }
    public class Прыжки_в_воду : Прыжки_на_батуте
    {

    }
    public class Пляжный_волейбол : Прыжки_в_воду
    {

    }
    public class Плавание : Пляжный_волейбол
    {

    }

   public  class Megachel : Плавание
    {
        private string familis;
        private string name;
        private string ochectvo;
        private short age;
        protected string [] sport;
        protected string [] mirovou_rekord;
        protected string [] ed_izmerenie;
        private int a, s, d, f, g;

    }
}
