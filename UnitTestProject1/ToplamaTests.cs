using ExamplePlay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class ToplamaTests
    {
        int sayi1, sayi2;
        [TestInitialize]
        public void Metoda_Yolla()
        {
            sayi1 = 10;
            sayi2 = 20;
            Console.WriteLine("İlk olarak TestInitialize çalışır. Tüm testlerde ortak olan elemanlar burada toplanır.");
        }
        [TestMethod]
        public void Topladimi()
        {
            Console.WriteLine("İlk metod çalıştı.");
           string bekledigimDeger = "30"; //Metottan dönmesini beklediğim değer.

            //Act => Eyleme geçtiğim kısım. Test edeceğim metodu kullandığım yer.
            string metoddanDönenDeger = Toplama.Topla(sayi1, sayi2);

            //Assert => Test sonucunu aldığımız yer. Testin geçerli veya geçersiz cevabını alacağız.
            Assert.AreEqual(bekledigimDeger,metoddanDönenDeger);
        }
        [TestMethod]
        public void Tam_Sayiya_Donusturuluyormu()
        {
            Console.WriteLine("İkinci metod çalıştı.");
            //Arrange
            bool bekledigimDeger = true;
            //Act
            bool donenDeger = Toplama.TamSayiDonusum(sayi1, sayi2);
            //Assert
            Assert.AreEqual(bekledigimDeger,donenDeger);
        }
        [TestCleanup]
        public void EnSonHamle()
        {
            Console.WriteLine("TestCleanup en son çalışır. " +
                "En son yapılması gereken işlemler burada yazılır.");
        }
    }
}
