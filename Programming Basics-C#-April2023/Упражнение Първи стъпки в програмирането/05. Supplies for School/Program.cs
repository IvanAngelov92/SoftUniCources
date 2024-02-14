namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packedChemicals = int.Parse(Console.ReadLine());
            int packedMarkers = int.Parse(Console.ReadLine());
            int leters = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double priceChemicals = packedChemicals * 5.80;
            double priceMarkers = packedMarkers * 7.20;
            double pricePreparation = leters * 1.20;
            double priceAllMaterials = priceChemicals + priceMarkers + pricePreparation;
            double priceWithDiscount = priceAllMaterials - (priceAllMaterials * percentDiscount) / 100;
            Console.WriteLine(priceWithDiscount);
            
        }
    }
}