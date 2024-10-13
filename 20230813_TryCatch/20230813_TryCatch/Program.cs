using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230813_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Try-Catch
            //Programımız içerisinde çalışma esnasında bazı durumlarda hatalar ile karşı karşıya gelebiliriz
            //Potansiyel hata verebilecek olan satırların try-catch mekanizması içerisinde hatayı yakalayıp, hata vermesini engelleyebiliriz.Kullanıcıyı yönlendirebiliriz

            //Syntax
            //try
            //{
            // Potansiyel hata verebilecek olan komut satırları bu alanda yazılır.Komut satırlarında herhangi bir hata varsa"catch" içerisine girer
            //}
            //catch (Exception)
            //{
            //    "try" içerisinde bulunan komut satırlarında hata oluştuğunda  bu alandaki komut satırları işleme alınır
            //}

            Console.Write("Sayı Giriniz : ");
            try
            {
                int sayi=int.Parse(Console.ReadLine());
                Console.WriteLine("Girilen Sayı = "+sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("---------------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine("-----------------");
                Console.WriteLine("Hatalı Bir Değer Girdiniz");
                
            }


            Console.ReadKey();
        }
    }
}
