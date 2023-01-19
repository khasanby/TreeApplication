using FactoryPattern.ServiceInterfaces;
using FactoryPattern.Services;

class Program
{
    public static void Main(string[] args)
    {
        ITreeService treeService = new TreeService();

        /// Trees dictionary stores type id of the tree
        /// for key and trees' count for its value property.
        Dictionary<int, int> trees = new();

        Console.WriteLine("===============================================================");
        Console.WriteLine("Welcome to Farm Calculator application!");
        Console.WriteLine("Choose trees you want to plant");
        Console.WriteLine("===============================================================");
        treeService.TreeChoosing(trees);
    }       
}