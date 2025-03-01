namespace animalFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();
            Console.WriteLine("please enter the species type");
            String AnimalSelected = Console.ReadLine();
            IAnimal animal = factory.GetAnimal(AnimalSelected);
            Console.WriteLine("Common name: {0} Genus: {1} Species: {2}",
                animal.getCommonName(), animal.getGenus(), animal.getSpecies());
        }
    }
}
