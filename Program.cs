class Program
{

    static void Main(string[] args)
    {
        Console.Write("Cümle yazınız:");
        string cumle = Console.ReadLine();
        cumleCevir();


        void cumleCevir()
        {
            string[] kelimeler = cumle.Split(' ');
            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] karakterler = kelimeler[i].ToCharArray();
                char ilk = karakterler[0];
                karakterler[0] = karakterler[karakterler.Length - 1];
                karakterler[karakterler.Length - 1] = ilk;
                
                for (int p = 0; p < karakterler.Length; p++)
                {
                    Console.Write(karakterler[p]);
                };
                Console.Write(" ");
            }
        }
    }


}