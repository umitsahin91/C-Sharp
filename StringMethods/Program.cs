using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Vefasız hiç düşündünmü kalan mAğdur Giden pişman gel gör ki aşk neFesmiş aşkı Buldum boğuluyor insan uZun lafın kısası";
            string isim = "Ümit";
            bool sonuc = true;

            //String  içerisinde aradığımız değerin olup olmadığını kontrol eder.
            //Geriye boolen sonuç döndürür.
            #region Contains_Fonksiyonu
            System.Console.WriteLine("*****Contains Fonksiyonu*****");
            System.Console.WriteLine(sonuc = metin.Contains("buldum"));//true
            #endregion
            //-----------------------------------------------------------------------------------------------//

            //Sting ifadenin verilen değerle başlayıp başlamama durumunu kontrol eder.
            //Geriye boolen sonuç döndürür.
            #region StartsWith_Fonksiyonu

            System.Console.WriteLine("*****StartsWith Fonksiyonu*****");
            System.Console.WriteLine(sonuc = metin.StartsWith("vefa"));//true
            System.Console.WriteLine(sonuc = metin.StartsWith("ve"));//true
            System.Console.WriteLine(sonuc = metin.StartsWith("vefasız"));//true
            System.Console.WriteLine(sonuc = metin.StartsWith("hiç"));//false



            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String ifadenin verilen değer ile bitme durumunu kontrol eder.
            //Geriye boolen sonuç döndürür.
            #region EndsWith_Fonksiyonu

            System.Console.WriteLine("*****EndsWith Fonksiyonu*****");

            System.Console.WriteLine(sonuc = metin.EndsWith("kısası"));//true
            System.Console.WriteLine(sonuc = metin.EndsWith("asi"));//false
            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String ifadenin bir başka string ifade ile eşit olup olmadığını kontrol eder.
            //Geriye boolen sonuç döndürür.
            #region Equals_Fonksiyonu

            System.Console.WriteLine("*****Equals Fonksiyonu*****");
            System.Console.WriteLine(sonuc = metin.Equals("ümit şahin"));//false
            System.Console.WriteLine(sonuc = metin.Equals("vefasız hiç düşündünmü kalan mağdur giden pişman gel gör ki aşk nefesmiş aşkı buldum boğuluyor insan uzun lafın kısası"));//true

            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String ifadenin bir başka string ifade ile eşit olup olmama durumunu kontrol eder.
            //Geriye integer sonuç döndürür.
            //"0" , "1" yada "-1" döndürecektir.
            //"0" =>Her iki değer birbirine eşittir.
            //"1" =>Soldaki sağdakinden alfanumerik olarak büyük
            //"-1" =>Soldaki sağdakinden alfanumerik olarak küçük
            #region Compare_Fonksiyonu

            System.Console.WriteLine("*****Compare Fonksiyonu*****");
            System.Console.WriteLine(string.Compare(metin, "Z"));//-1
            System.Console.WriteLine(string.Compare(metin, "A"));//1
            System.Console.WriteLine(string.Compare(metin, metin));//0
            System.Console.WriteLine(string.Compare(metin, "v"));//1 
            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String ifadenin bir başka string ifade ile eşit olup olmama durumunu kontrol eder.
            //Geriye integer sonuç döndürür.
            //"0" , "1" yada "-1" döndürecektir.
            //"0" =>Her iki değer birbirine eşittir.
            //"1" =>Soldaki sağdakinden alfanumerik olarak büyük
            //"-1" =>Soldaki sağdakinden alfanumerik olarak küçük
            #region CompareTo_Fonksiyonu
            System.Console.WriteLine("*****CompareTo Fonksiyonu*****");
            System.Console.WriteLine(metin.CompareTo("Z"));//-1
            System.Console.WriteLine(metin.CompareTo("A"));//1
            System.Console.WriteLine(metin.CompareTo(metin));//0
            System.Console.WriteLine(metin.CompareTo("v"));//1 

            #endregion
            //-----------------------------------------------------------------------------------------------//

            //Aradığımız metinin string içerisinde olup olmamasını kontrol eder.
            //Geriye integer olarak index numarasını döndürür.
            //Aradığımız ifade kelime ise kelimenin ilk harfinin index numarasını geriye döndürür.
            //Aradığımız ifade string içerisinde yoksa geriye "-1" değerini döndürür.
            //Aradığımız ifade string içerisinde birden fazla yerde geçiyorsa ilk eşleşen değerin indexini geriye döndürür.
            #region IndexOf_Fonksiyonu
            System.Console.WriteLine("*****IndexOf Fonksiyonu*****");
            System.Console.WriteLine(metin.IndexOf("hiç"));//8
            System.Console.WriteLine(metin.IndexOf("vefa"));//0
            System.Console.WriteLine(metin.IndexOf("vefasız"));//0
            System.Console.WriteLine(metin.IndexOf("laf"));//106


            #endregion
            //-----------------------------------------------------------------------------------------------//

            //Elimizdeki metinsel ifadeye bir değer eklememizi sağlayan fonksiyondur.
            //Geriye ekleme işleminin gerçekleştiği string bir değer döndürür.
            //Ekleme işlemini yaptığımız stringde bir değişiklik olmaz
            #region Insert_Fonksiyonu           
            System.Console.WriteLine("*****Insert Foksiyonu*****");
            System.Console.WriteLine(isim.Insert(4, "Şahin"));//ÜmitŞahin
            System.Console.WriteLine(isim);//Ümit
            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String ifade de index numarasıyla verilen aralığı silmek için kullanılır.
            //Geriye silme işleminin gerçekleştiği string bir değer döndürür.
            //Silme işlemini yaptığımız stringde bir değişiklik olmaz
            #region Remove_Fonksiyonu

            System.Console.WriteLine("*****Remove Fonksiyonu*****");
            System.Console.WriteLine(metin.Remove(5));//5. indexten sonraki tüm değerleri siler.
            System.Console.WriteLine(metin.Remove(5, 20));//5. indexten başla 20 adet sil

            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String içerisinde istediğimiz karakterlerin/sözcüklerin değiştirilmesini sağlar.
            //Geriye replace işleminin gerçekleştiği string bir değer döndürür.
            //Replace işlemini yaptığımız stringde bir değişiklik olmaz
            #region Replace_Fonksiyonu

            System.Console.WriteLine("*****Replace Fonksiyonu*****");

            //karakter (char) 
            System.Console.WriteLine(metin.Replace('a', 'z'));//a olan karakterlerin hepsini z ile değiştirecektir
            //metin (string)
            System.Console.WriteLine(metin.Replace("vefa", "defa"));//vefa olan kelimelerin hepsini defa olarak değiştirecektir.
            System.Console.WriteLine(metin.Replace("bir", ""));//bir geçen bütün yerleri siler
            System.Console.WriteLine(metin.Replace("bir", string.Empty));//bir geçen bütün yerleri siler

            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String ifadeyi vermiş olduğumuz ayraca göre parçalar.
            //Geriye string[] dizisi döndürür.
            #region Split_Fonksiyonu

            System.Console.WriteLine("*****Split Fonksiyonu*****");
            string[] dizi = metin.Split(' ');
            string[] dizi2 = metin.Split('a', ' ');


            #endregion
            //-----------------------------------------------------------------------------------------------//

            //Metinsel ifadenin istediğimiz aralığını elde etmemizi sağlar.
            //Geriye  işlemin gerçekleştiği string bir değer döndürür.
            //Substring işlemini yaptığımız stringde bir değişiklik olmaz
            #region Substring_Fonksiyonu

            System.Console.WriteLine("*****Substring Fonksiyonu*****");

            //5. indexten sonraki tüm değerleri getir
            System.Console.WriteLine(metin.Substring(5));
            //5. indexten başlayacak 10 karakter getirecektir
            System.Console.WriteLine(metin.Substring(5, 10));




            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String içerisindeki tüm karakterleri küçük karakter olarak düzenler.
            //Geriye  işlemin gerçekleştiği string bir değer döndürür.
            //ToLower işlemini yaptığımız stringde bir değişiklik olmaz
            #region ToLower_Fonksiyonu

            System.Console.WriteLine("*****ToLower Fonksiyonu*****");
            System.Console.WriteLine(metin.ToLower());


            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String içerisindeki tüm karakterleri Büyük karakter olarak düzenler.
            //Geriye  işlemin gerçekleştiği string bir değer döndürür.
            //ToUpper işlemini yaptığımız stringde bir değişiklik olmaz
            #region ToUpper_Fonksiyonu

            System.Console.WriteLine("*****ToUpper Fonksiyonu*****");
            System.Console.WriteLine(metin.ToUpper());

            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String içerisinde varsa başında ve sonundaki boşlukları temizleyen fonksiyondur.
            //Fakat metinsel ifadenin içerisindeki boşlukları silmez.
            #region Trim_Fonksiyonu

            System.Console.WriteLine("*****Trim Fonksiyonu*****");
            System.Console.WriteLine("Ümit Şahin");
            System.Console.WriteLine("   Ümit Şahin   ".Trim());//Ümit Şahin

            #endregion
            //-----------------------------------------------------------------------------------------------//

            //String içerisinde varsa sonundaki boşlukları temizleyen fonksiyondur.
            #region TrimEnd_Fonksiyonu

            System.Console.WriteLine("*****TrimEnd Fonksiyonu*****");
            System.Console.WriteLine("Ümit Şahin");
            System.Console.WriteLine("   Ümit Şahin   ".TrimEnd());//Ümit Şahin
            #endregion
            //-----------------------------------------------------------------------------------------------//
            
            //String içerisinde varsa başındaki boşlukları temizleyen fonksiyondur.
            #region TrimStart_Fonksiyonu

            System.Console.WriteLine("*****TrimEnd Fonksiyonu*****");
            System.Console.WriteLine("Ümit Şahin");
            System.Console.WriteLine("   Ümit Şahin   ".TrimStart());//Ümit Şahin
            #endregion
        }
    }
}
