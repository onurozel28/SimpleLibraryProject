using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            Boolean devamet = true;
            try
            { 
                Console.WriteLine("**** KÜTÜPHANEMİZE HOŞGELDİNİZ ****");
                Console.WriteLine("**********************************");
                Console.WriteLine("KÜTÜPHANEMİZDE TÜRKÇE VE YABANCI OLMAK ÜZERE 2 BÖLÜMÜMÜZ BULUNMAKTADIR\n\n");
                Console.WriteLine("|||||| TÜRKÇE KİTAPLAR KATEGORİSİ  -------------------------  YABANCI KİTAPLAR KATEGORİSİ ||||||\n");
                Console.WriteLine("1-Saatleri Ayarlama Enstitüsü - Ahmet Hamdi Tanpınar  |    6-1984 - George Orwell ");
                Console.WriteLine("2-Tutunamayanlar - Oğuz Atay                          |    7-Suç ve Ceza - Fyodor Dostoyevsky ");
                Console.WriteLine("3-Kürk Mantolu Madonna - Sabahattin Ali               |    8-Yüzüklerin Efendisi- J.R.R. Tolkien ");
                Console.WriteLine("4-İnce Memed - Yaşar Kemal                            |    9-Uçurtma Avcısı - Khaled Hosseini ");
                Console.WriteLine("5-Aşk - Elif Şafak                                    |    10-Bülbülü Öldürmek - Harper Lee ");
                Console.WriteLine();
                while (devamet)
                {
                    Console.WriteLine("\n\n********İŞLEM MENÜSÜ******");
                    Console.WriteLine("1-Ürün Fiyatı sorgulama");
                    Console.WriteLine("2-Yeni okur kaydı ");
                    Console.WriteLine("3-Günün kitabı");
                    Console.WriteLine("4-Kitap arşivi");
                    Console.WriteLine("5-Yeni kitap satın al");
                    Console.WriteLine("YAPMAK SİTEDİĞİNİZ İŞLEMİ SEÇİNİZ:");
                    char secim1 = Char.Parse(Console.ReadLine());
                    if (secim1 == '1')
                    {
                        Console.WriteLine("Fiyatını sorgulamak istediğiniz ürünü seçiniz:\n");
                        string secim2 = (Console.ReadLine());
                        switch (secim2)
                        {
                            case "1": Console.WriteLine("Saatleri Ayarlama Enstitüsü - Ahmet Hamdi Tanpınar\nFiyat=100TL"); break;
                            case "2": Console.WriteLine("Tutunamayanlar - Oğuz Atay\nFiyat=60 TL"); break;
                            case "3": Console.WriteLine("Kürk Mantolu Madonna - Sabahattin Ali \nFiyat=95 TL"); break;
                            case "4": Console.WriteLine("İnce Memed - Yaşar Kemal\nFiyat=65 TL"); break;
                            case "5": Console.WriteLine("Aşk - Elif Şafak\nFiyat=75 TL"); break;
                            case "6": Console.WriteLine("1984 - George Orwell\nFiyat=100 TL"); break;
                            case "7": Console.WriteLine("Suç ve Ceza - Fyodor Dostoyevsky\nFiyat=80 TL"); break;
                            case "8": Console.WriteLine("Yüzüklerin Efendisi- J.R.R. Tolkien\nFiyat=70 TL"); break;
                            case "9": Console.WriteLine("Uçurtma Avcısı - Khaled Hosseini\nFiyat=65 TL"); break;
                            case "10": Console.WriteLine("Bülbülü Öldürmek - Harper Lee\nFiyat=55 TL"); break;
                            default: Console.WriteLine("Kütüphanemizde bulunmayan bir ürün seçtiniz! Lütfen tekrar seçim yapınız!"); break;

                        }
                    }
                    else if (secim1 == '2')
                    {
                        Console.WriteLine("Kayıt bölümüne hoşgeldiniz.\n");
                        string ad, soyad, okul;
                        Console.Write("Adınız:");
                        ad = Console.ReadLine();
                        Console.Write("Soyadınız:");
                        soyad = Console.ReadLine();
                        Console.WriteLine("Hangi okulda okuyorsunuz?");
                        okul = Console.ReadLine();
                        try
                        {
                            string dosya = @"C:\Users\onurs\OneDrive\Masaüstü\Yeniokurkaydı.txt";
                            StreamWriter sw = new StreamWriter(dosya);
                            Console.WriteLine("KAYDINIZ OLUŞTURULMUŞTUR!\n");
                            sw.WriteLine("Adınız:" + ad);
                            sw.WriteLine("Soyadınız:" + soyad);
                            sw.WriteLine("Okulunuz:" + okul);
                            sw.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Dosya kaydı sırasında bir hata oluştu: " + ex.Message);
                        }
                    }
                    else if (secim1 == '3')
                    {
                        Console.WriteLine("GÜNÜN KİTABI ------> Kürk Mantolu Madonna - Sabahattin Ali ");
                    }
                    else if (secim1 == '4')
                    {
                        Console.WriteLine("***** KİTAP ARŞİVİNE HOŞGELDİNİZ ********");
                        FileStream fs = new FileStream(@"C:\Users\onurs\OneDrive\Masaüstü\kitaparsiviniz.txt", FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        string metin = sr.ReadLine();
                        while (metin != null)
                        {
                            Console.WriteLine(metin);
                            metin = sr.ReadLine();
                        }
                        sr.Close();
                        fs.Close();
                    }
                    else if (secim1 == '5')
                    {
                        for (int i = 1; i <= 50; i++)
                        {
                            Console.Write("Almak istediğiniz kitabı seçiniz:");
                            string secim3 = Console.ReadLine();
                            if (secim3 == "1")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> Saatleri Ayarlama Enstitüsü - Ahmet Hamdi Tanpınar");
                                toplamfiyat = toplamfiyat + 100;
                            }
                            else if (secim3 == "2")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> Tutunamayanlar - Oğuz Atay");
                                toplamfiyat = toplamfiyat + 60;
                            }
                            else if (secim3 == "3")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> Kürk Mantolu Madonna - Sabahattin Ali");
                                toplamfiyat = toplamfiyat + 95;
                            }
                            else if (secim3 == "4")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> İnce Memed - Yaşar Kemal");
                                toplamfiyat = toplamfiyat + 65;
                            }
                            else if (secim3 == "5")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> Aşk - Elif Şafak");
                                toplamfiyat = toplamfiyat + 75;
                            }
                            else if (secim3 == "6")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> 1984 - George Orwell");
                                toplamfiyat = toplamfiyat + 100;
                            }
                            else if (secim3 == "7")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> Suç ve Ceza - Fyodor Dostoyevsky");
                                toplamfiyat = toplamfiyat + 80;
                            }
                            else if (secim3 == "8")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> Yüzüklerin Efendisi- J.R.R. Tolkien");
                                toplamfiyat = toplamfiyat + 70;
                            }
                            else if (secim3 == "9")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> Uçurtma Avcısı - Khaled Hosseini");
                                toplamfiyat = toplamfiyat + 65;
                            }
                            else if (secim3 == "10")
                            {
                                Console.WriteLine("Satın almak ödediğiniz kitap -> Bülbülü Öldürmek - Harper Lee");
                                toplamfiyat = toplamfiyat + 55;
                            }
                            else

                                Console.WriteLine("Hatalı tuşlama yaptınız!");
                            Console.WriteLine("Başka bir işlem yapmak ister misiniz?");
                            string cevap = Console.ReadLine();
                            if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "HAYIR")
                                break;


                        }
                        Console.WriteLine("Toplam tutar:" + toplamfiyat);
                        Console.WriteLine("İyi günler dileriz");
                    }
                    Console.WriteLine("Başka bir işlem yapmak ister misiniz?");
                    string cevap2 = Console.ReadLine();
                    if (cevap2 == "h" || cevap2 == "H" || cevap2 == "hayır" || cevap2 == "HAYIR")
                        break;
                }
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen geçerli bir işlem numarası girin."+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmedik bir hata oluştu: " + ex.Message);
            }
            Console.WriteLine("Programdan çıkılıyor!");
            Console.ReadKey();

        }
    }
}
