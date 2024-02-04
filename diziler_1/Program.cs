namespace diziler_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dizinin eleman sayısını giriniz: ");
        int elemanSayisi = int.Parse(Console.ReadLine());
        int[] sayilar = new int[elemanSayisi];
        
        for (int i = 0; i < elemanSayisi; i++)
        {
            Console.WriteLine("{0}. sayıyı giriniz: ", i+1);
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;

        foreach(var sayi in sayilar) {
            toplam+= sayi;
        }
        double ortalama = toplam / elemanSayisi;
        
        Console.Write("Girdiğiniz sayıların ortalaması: " + ortalama);
        
    }
}
