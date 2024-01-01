namespace Odev_Sayi_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahmin;
            int can = 100;
            Console.WriteLine("seviye seciniz:\n1-kolay\n2-orta\n3-zor");
            int zorluk = int.Parse(Console.ReadLine());
            int value = 0;
            switch (zorluk)
            {
                case 1:
                    value = 10;
                    break;
                case 2:
                    value = 55;
                    break;
                case 3:
                    value = 100;
                    break;
                default:
                    break;
            }

            Random rnd = new Random();
            int sayı = rnd.Next(value);
            do
            {
                Console.WriteLine("sayı tahmin et");
                tahmin = int.Parse(Console.ReadLine());
                if (zorluk == 1)
                {
                    if (tahmin != sayı)
                    {
                        can -= 20;
                        if (can == 0)
                        {
                            Console.WriteLine("CANIN BİTTİ...");
                            break;
                        }
                    }
                }

                else if (zorluk == 2)
                {
                    if (tahmin != sayı)
                    {
                        can -= 50;
                        if (can == 0)
                        {
                            Console.WriteLine("CANIN BİTTİ...");
                            break;
                        }
                    }
                }
                else if (zorluk == 3)
                {
                    if (tahmin != sayı)
                    {
                        can -= 100;
                        if (can == 0)
                        {
                            Console.WriteLine("CANIN BİTTİ...");
                            break;
                        }
                    }

                }
                if (tahmin < sayı)
                {
                    Console.WriteLine("Büyük bir sayı tahmin ediniz");
                }
                else if (tahmin > sayı)
                {
                    Console.WriteLine("Küçük bir sayı tahmin ediniz");
                }
            }
            while (tahmin != sayı);
            if (tahmin == sayı)
            {
                Console.WriteLine("dogru tahmin...");
            }
        }
    }
}
