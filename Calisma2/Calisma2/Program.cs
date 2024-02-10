using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DİZİLER //
            #region DİZİLER
            // Aynı türden birden fazla veriyi içeren yapıdır.
            // Diziler RAM'de birden fazla veriyi tek bir değişken altında bir veri kümesi olarak tutar.
            // Dizi, referans tipindedir. Yani RAM'in Heap kısmında tutulur.
            // Dizi içerisine tüm türde değer yerleştirilebilir. Her değer aynı türde olmalı.
            // Dizi içine yerleştirilen değerlerin konusu aynı olmalı. Örneğin aynı diziye hem maaş hem de yaş yerleştirilmesi doğru değildir.
            // Dizi içerisinde değerler index adı verilen bir sıralama ile tutulur. İndex 0'dan başlar n-1'e kadar gider. 10 elemanlı bir dizinin ilk index'i 0 son index'i 9'dur.
            // Dizi içine alınacak eleman sayısı başta belirtildiğinde belirtilen eleman sayısı aşılamaz. 

            // DİZİ TANIMLAMA
            // Aşağıda tanımlanmış dizide 7 rakamının bulunduğu alan dizinin kaç elemandan oluşacağını belirten kısımdır.
            // Bu alandaki tanımlama bellekte o kadar alanlık(7 elemanlık) yer tutar.
            // Bu dizi oluşturulduğunda herhangi bir değer atanana kadar elemanları default olarak 0'dan oluşur.
            //int[] yas = new int[7];

            // DİZİYE DEĞER ATAMA
            // Değer, index numarası belirlenerek atanır. Belirtilen indexe belirtilen değer atanır.
            // Dizilere değer atama işlevi değişkene değer atama işlevi ile aynıdır.
            // Var olmayan indexe atama yapılamaz.
            /*int[] yaslar = new int[7];
            yaslar[3] = 4; // 3. indexe 4 değeri atandı.
            yaslar[0] = 4;
            yaslar[6] = 21;


            // DEĞER OKUMA
            Console.WriteLine(yaslar);
            Console.WriteLine(yaslar[3]); // indexi 3 olan elamanın değerini döndürür.
            Console.WriteLine(yaslar[2]);
            Console.WriteLine(yaslar[8]); // HATA VERİR
            Console.ReadLine();*/

            // DİZİ İÇİNDE DÖNGÜ KULLANIMI
            /*string[] personeller = new string[10];
            personeller[0] = "Ali";
            personeller[1] = "Veli";
            personeller[2] = "Kazım";
            personeller[3] = "Mithat";
            personeller[4] = "Gözde";
            personeller[5] = "Fatma";
            personeller[6] = "Hayriye";
            personeller[7] = "Ayşe";
            personeller[8] = "Mahmut";
            personeller[9] = "Yeşim";*/

            // for
            /*for (int i = 0; i<10; i++)
            {
                Console.WriteLine(personeller[i]);
            }
            Console.ReadLine();*/

            //do-while
            /*int i = 0;
            do
            {
                Console.WriteLine(personeller[i++]);
            } while (i < 10);
            Console.ReadLine();*/

            // NOT: Dizinin eleman sayısının değişime uğrama ihtimaline karşı döngünün koşul sayısı dizinin eleman sayısana bağlı olmalı. Bunun için Length kullanılır.
            /*for (int i = 0; i<personeller.Length; i++)
            {
                Console.WriteLine(personeller[i]);
            }
            Console.ReadLine();*/

            //DİZİ TANIMLAMA VARYASYONLARI
            //int[] yaslar = new int[3]; //1
            //int[] yaslar = { 2,5,12,51,35,12 }; //2
            //int[] yaslar = new int[] { 2, 5, 12, 51, 35, 12 }; //3
            //int[] yaslar = new int[3] { 3,5,1 }; //4 ==> kaç eleman belirtildiyse o kadar eleman girilmeli.
            //int[] sayilar = new[] { 1,2,3 }; //5
            //var sayilar2 = new[] { 1, 2, 3 };//5 ==> Tür içindeki değere göre belirlenir. 
            #endregion

            // ARRAY SINIFI //
            #region ARRAY SINIFI
            #region TANIM
            // Dizilerin sahip olduğu sınıf Array sınıfıdır.
            // Bir dizi kendi türünde tanımlandığında indexer operatörü kullanılabilir ama Array türünde/sınıfında tanımlandığında kullanılamaz.
            // Algoritma üzerine işlem yapılacaksa genellikle kendi türünde tanımlanan(int[] gibi) dizi kullanılır.
            // Dizi üzerine işlem yapılacaksa genellikle Array kullanılır.
            //Array yaslar = new int[2]; 

            //Değer Atama
            //1.YOl ==> Dizi tanımlayıp oluşturulan Array sınıfına atamak
            //int[] sayi = new int[] { 1, 2, 3 };
            //Array sayi2 = sayi;

            //2.YOL ==> Kendi içinde tanımlama.
            //Array dizi = new int[] {1,2,3,4};
            //Array dizi = new int[4] { 1, 2, 3, 4 };
            //Array dizi = new[] { 1,2,3,4 };

            //3.YOl ==> SetValue Fonksiyonu kullanarak değer atama. ilk parametre değer, ikinci parametre index
            /*Array dizi = new int[3];
            dizi.SetValue(1, 0); // 0.index'e 1 değeri atama
            dizi.SetValue(11,1); // 1.index'e 11 değeri atama
            dizi.SetValue(111,2); // 2.index'e 111 değeri atama*/

            //Değer Okuma ==> Parametre olarak index'i alır.
            /*Array dizi = new int[3];
            dizi.SetValue(1, 0);
            dizi.SetValue(2,1);
            dizi.SetValue(3,2);
            object deger = dizi.GetValue(1); // 1.index'teki değeri(2) getirir.
            Console.WriteLine(deger);
            Console.ReadLine();*/
            #endregion

            #region ARRAY METOT
            #region Clear Metodu
            // Dizi içindeki belirilen bir değeri tipine uygun default değerine döndürür.
            /*Array isimler = new[] { "Ali","Veli","Kazım", "Gözde","Ayşe" };
            Array.Clear(isimler,0,3); // Sırasıyla parametreler ==> Array İsmi, başlangıç indexi, bitiş indexi(dahil değil) 
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }
            Console.ReadLine();*/
            #endregion Clear Metodu

            #region Copy Metodu
            // Array içindeki değerlerin bir başka Array'a verilmesidir. Kaynak Array(kopyalanan), Hedef Array(kopya)
            /*Array isimler = new[] { "Ali", "Veli", "Kazım", "Gözde", "Ayşe" };
            string[] isimler2 = new string[isimler.Length];*/ // Hedef, Array de olabilir.
                                                              // Hedef Array/Dizi'nin eleman sayısı kopyalanacak kaynak Array'in eleman sayısı kadar olmalı.
                                                              // 1.Kullanım
            /*Array.Copy(isimler, isimler2, 4); // Sırasıyla parametreler ==> kaynak array, hedef array, kopyalanacak değer sayısı(sırası ile)
            for (int i = 0; i < isimler2.Length; i++)
            {
                Console.WriteLine(isimler2.GetValue(i));
                //Console.WriteLine(isimler2[i]);
            }
            Console.ReadLine();*/

            // 2.Kullanım
            /*Array.Copy(isimler,1,isimler2, 1,3); // Sırasıyla parametreler ==> kaynak array, kaynak başlangıç index'i, hedef array, hedef başlangıç index'i 
            for (int i=0; i<isimler2.Length; i++)
            {
                Console.WriteLine(isimler2[i]);
            }
            Console.ReadLine();*/
            #endregion Copy Metodu

            #region IndexOf Metodu
            // Bir elemanın olup olmadığını değer üzerinden kontrol eder. Belirtilen değer varsa ilgili değerin index numarası döndürülür. Yok ise -1 döndürür.
            //Array isimler = new[] { "Ali", "Veli", "Kazım", "Gözde", "Ayşe" };

            // 1.Kullanım
            //int index = Array.IndexOf(isimler, "Fatma");
            //if (index != -1 ) // ilgili index'in olma durumu
            //{
            //    Console.WriteLine($"İlgili değer({index}) var.");
            //}
            //else
            //{
            //    Console.WriteLine($"İlgili değer({index}) yok.");
            //}
            //Console.ReadLine();

            // 2.Kullanım
            //int index = Array.IndexOf(isimler, "Fatma", 0,2); // index aralığı belirtilerek kullanımı
            #endregion IndexOf Metodu

            #region Reverse Metodu
            //Elemanların tersini alan bir metoddur. Aralık belirtilebilir.
            /*Array isimler = new[] { "Ali", "Veli", "Kazım", "Gözde", "Ayşe" };
            Array.Reverse(isimler);
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }
            Console.ReadLine();*/

            /*Array sayilar = new[] {1,2,3,4,5};
            Array.Reverse(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar.GetValue(i));
            }
            Console.ReadLine();*/
            #endregion Reverse Metodu

            #region Sort Metodu
            //Değerleri küçükten büyüğe doğru sıralar. Alfabetik sıralar.
            /*Array isimler = new[] { "Ali", "Veli", "Kazım", "Gözde", "Ayşe" };
            Array.Sort(isimler);
            for (int i = 0; i<isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i)); // Alfabetik
            }
            Console.ReadLine();*/

            /*Array sayilar = new[] { 2, 6, 2123, 0, 7123, 9, 5, 1 };
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar.GetValue(i));
            }
            Console.ReadLine();*/
            #endregion Sort Metodu

            #region CreateInstance Metodu
            // Dizi oluşturulmasını sağlayan metotdur.
            // typeof keyword ile tür ve kaç elemanlı olacağı belirtilir. 
            /*Array dizi = Array.CreateInstance(typeof(int), 3); // 1 boyutlu ve 3 elemanlı
            Console.WriteLine(dizi.Rank);
            Console.ReadLine();*/

            // Çok Boyutlu Dizi Oluşturma //
            // Dizi kaç boyutlu olacaksa o kadar sayıda eleman verilir.
            /*Array dizi = Array.CreateInstance(typeof(int),4,1,3,5,6); // 5 boyutlu
            Console.WriteLine(dizi.Rank);
            Console.ReadLine();*/
            #endregion CreateInstance Metodu

            #endregion ARRAY METOT

            #region ARRAY PREPORTY/ÖZELLİKLER
            #region IsReadOnly
            //Bir dizini sadece okunup-yazılabilir olup olmadığını bool türünde döndürür.
            /*Array isimler = new[] { "Ali", "Veli", "Kazım", "Gözde", "Ayşe" };
            bool cevap = isimler.IsReadOnly;
            Console.WriteLine(cevap);
            Console.ReadLine();*/
            #endregion

            #region IsFixedSize
            // Eleman sayısının sabit olup olmadığını bool türünde döndürür. Diziler sabit sayıda değer aldığı için true döndürür. 
            /*Array isimler = new[] { "Ali", "Veli", "Kazım", "Gözde", "Ayşe" };
            Console.WriteLine(isimler.IsFixedSize);
            Console.ReadLine();*/
            #endregion

            #region Length
            // Dizinin eleman sayısını verir.
            /*Array isimler = new[] { "Ali", "Veli", "Kazım", "Gözde", "Ayşe" };
            Console.WriteLine(isimler.Length);
            Console.ReadLine();*/
            #endregion

            #region Rank
            // Dizinin boyutunu/derecesini döndürür.
            /*Array isimler = new[] { "Ali", "Veli", "Kazım", "Gözde", "Ayşe" };
            Console.WriteLine(isimler.Rank);
            Console.ReadLine();*/
            #endregion

            #endregion ARRAY PREPORTY/ÖZELLİKLER

            #endregion

            // Ranges and Indices // ==> Konu işlenmedi. Operatörler tanımlanmıyor.
            #region RANGES AND INDICES
            #endregion RANGES AND INDICES

            // ÇOK BOYUTLU DİZİLER //
            #region ÇOK BOYUTLU DİZİLER
            // Çok boyutlu dizi tanımlamak için indexer içine "," eklenir. Virgül sayısının 1 fazlası kadar katman(boyut) eklenir.
            // Her boyutun eleman sayısı "=" diğer tarafındaki indexer'de tanımlanması gerekir.
            // Kolon ve satır numaraları 0'dan başlar.
            /*int[] sayilar = new int[] { 1, 2, 3 };*/ // Tek boyutlu

            #region Çift Boyutlu Diziler
            //int[,] sayilar2 = new int[3, 5]; // 3 kolon 5 satır
            #endregion Çift Boyutlu Diziler

            #region Değer Atama
            //int[,] sayilar = new int[3,5]; // 3 kolon 5 satır
            //sayilar[2,3] = 4; // 2.kolon 3.satıra 4 değeri atanır.

            //int[,,,,] sayilar2 = new int[5,3,4,6,6]; 
            //sayilar2[2,2,5,2,1] = 4; // belirtlilen konuma 4 değeri atandı.

            // Değer Atama İçin Farklı Bir Yol ==> Aşağıda 3 kolon 2 satır oluşturulmuştur.
            // İlk parantezde atanılan değer kadar kolon oluşur daha sonraki parantezler satır içindir. Kolon ve satır sayısı eşit olmak zorunda.
            //int[,] sayilar =
            //{
            //    {5, 6, 3 },    // [0,0] = 5 ve [1,0] = 6 ve [2,0] = 3
            //    {2, 5, 6 },    // [0,1] = 2 ve [1,1] = 5 ve [2,1] = 6 
            //    {8, 6, 2 }     // [0,2] = 8 ve [1,2] = 6 ve [2,2] = 2
            //};

            #endregion Değer Atama

            #region Değer Okuma
            //int[,] sayilar =
            //{
            //    {5, 6, 3 },    // [0,0] = 5 ve [1,0] = 6 ve [2,0] = 3
            //    {2, 5, 6 },    // [0,1] = 2 ve [1,1] = 5 ve [2,1] = 6 
            //    {8, 6, 2 }     // [0,2] = 8 ve [1,2] = 6 ve [2,2] = 2
            //};

            //Console.WriteLine(sayilar[2,1]); // 2.kolon 1.satırdaki değer = 6
            //Console.ReadLine(); 
            #endregion Değer Okuma

            #region Eleman Sayısı Bulma
            //int[,,] sayilar = new int[2,2,5];
            //Console.WriteLine(sayilar.Length); //Dizinin toplam eleman sayısını verir.(2x2x5 = 20 elemanlı)
            //Console.WriteLine("-----------------------------");
            //// Her boyutun ayrı olarak eleman sayısını öğrenme ==> GetLEngth ==> Parametre olarak boyut index'i alır.
            //Console.WriteLine(sayilar.GetLength(0)); // İlk boyut ==> 2 elemanlı
            //Console.WriteLine(sayilar.GetLength(1)); // İkinci boyut ==> 2 elemanlı
            //Console.WriteLine(sayilar.GetLength(2)); // Üçüncü boyut ==> 5 elemanlı
            //Console.ReadLine();
            #endregion Eleman Sayısı Bulma

            #region Döngü İle Kullanım
            /*int[,,] sayilar = new int[2, 2, 5];
            for (int i = 0; i < sayilar.GetLength(0); i++)
            {
                for (int j = 0; j < sayilar.GetLength(1); j++)
                {
                    for(int k = 0; k < sayilar.GetLength(2); k++)
                    {
                        Console.Write(sayilar[i, j, k] + "         ") ;
                    }
                    Console.WriteLine("");
                }
            }
            Console.ReadLine();*/
            #endregion Döngü İle Kullanım

            #endregion ÇOK BOYUTLU DİZİLER

            // DÜZENSİZ DİZİLER //
            #region DÜZENSİZ DİZİLER
            // Çok boyutlu dizilerden farkı her sütünun farklı sayıda satır alabilmesidir.

            // TANIMLAMA
            /*int[][] dizi = new int[3][];
            dizi[0] = new int[4] {1,2,3,4};
            dizi[1] = new[] {1,3,5};
            dizi[2] = new[] {2};

            // DEĞER OKUMA
            Console.WriteLine(dizi[0][2]);
            Console.ReadLine();

            // DEĞER ATAMA
            dizi[2][1] = 3;
            Console.WriteLine(dizi[2][1]);
            Console.ReadLine();*/

            // ELEMAN SAYISI ÖĞRENME ==> Belli bir kod ile öğrenilemez. Eleman sayılarının toplamı eleman sayısını verir. 

            // DÖNGÜ KULLANIMI
            //int[][] dizi = new int[3][];
            //dizi[0] = new int[4] { 1, 2, 3, 4 };
            //dizi[1] = new[] { 1, 3, 5 };
            //dizi[2] = new[] { 2 };

            //for (int i = 0; i < dizi.Length; i++) 
            //{
            //    for (int j = 0; j < dizi[i].Length; j++)
            //    {
            //        Console.Write(dizi[i][j] + "   -   ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadLine();
            #endregion DÜZENSİZ DİZİLER

            // KOLEKSİYONLAR //
            #region KOLEKSİYONLAR
            // Dizilerdeki sınırlılıkları kaldırarak aynı işlevi gören yapılardır.
            // Aldığı verilerin türü object'tir.

            #region ARRAYLIST KOLEKSİYONU

            #region TANIMLAMA-DEĞER ATAMA
            /*ArrayList yaslar = new ArrayList();

            // DEĞER ATAMA //
            // 1.YOL
            // Add fonksiyonu kullanılır. Sırasıyla(index numarasına göre) değer atar.
            yaslar.Add(4);

            for (int i = 0; i < 19; i++)
            {
                yaslar[i] = i + 10;

                yaslar.Add(i + 10);
            }*/

            // 2.YOL
            //ArrayList tanım = new ArrayList() { "Ali",457,true};
            #endregion TANIMLAMA-DEĞER ATAMA

            #region DEĞER OKUMA 
            /*ArrayList yaslar = new ArrayList();
            Console.WriteLine(yaslar[5]);
            Console.WriteLine(yaslar[6]);
            Console.ReadLine();*/
            #endregion DEĞER OKUMA

            #region BOXING-UNBOXING
            // ArrayList'in aldığı verilerin türü object'tir.
            // Veri ile ilgili işlemlerde unboxing uygulanmalıdır.

            /*ArrayList sayilar = new ArrayList();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);

            int toplam = 0;
            for (int i = 0;i < sayilar.Count; i++)
            {
                toplam += (int)sayilar[i]; // UNBOXING
            }  
            Console.WriteLine(toplam);
            Console.ReadLine();*/
            #endregion BOXING-UNBOXING

            #endregion ARRAYLIST KOLEKSİYONU

            #endregion KOLEKSİYONLAR
        }
    }
}
