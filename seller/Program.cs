using System;
namespace clown
{
    class popik
    {
        static void Main()
        {
            string []  target = new string[] { "crm.ozon.ru//profile", "https://confluence.o3.ru/pages/viewpage.action?pageId=216024852", "", "https://seller-edu.ozon.ru/" };
            for (int i = 0; i < target.Length; i++)
            {
                System.Diagnostics.Process.Start(target[i]); System.Threading.Thread.Sleep(500);
            }
        }
    }
}
