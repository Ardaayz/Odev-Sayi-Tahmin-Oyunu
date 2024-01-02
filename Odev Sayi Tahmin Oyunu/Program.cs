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
            int value = 0; int eksilt = 0;
            
            switch (zorluk)
            {
                case 1:
                    value = 10;
                    eksilt = 10;
                    
                    break;
                case 2:
                    value = 55;
                    eksilt = 50;
                    break;
                case 3:
                    value = 100;
                    eksilt=100;
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

                if (tahmin == sayı)
                {
                    Console.WriteLine("DOGRU TAHMİN...");
                }
                if (tahmin < sayı)
                {      
                    can -= eksilt;
                }
                else if (tahmin > sayı)
                { 
                    can -= eksilt;
                }
                if (can == 0) { break; }
            }
            while (tahmin != sayı);

        }
    }
}
