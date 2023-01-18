using FactoryPattern.FactoryInterfaces;
using FactoryPattern.FactoryMethods;
using FactoryPattern.ServiceInterfaces;
using FactoryPattern.TreeBases;
using FactoryPattern.Trees;
using FactoryPattern.TreeTypes;

namespace FactoryPattern.Services
{
    public sealed class TreeService : ITreeService
    {
        /// <summary>
        /// Method for choosing tree according to user input.
        /// </summary>
        public void TreeChoosing(Dictionary<int, int> treesWithCount)
        {
            ITreeTypeService typeService = new TreeTypeService();
            
            Console.WriteLine("1.Apple \n2.Cherry \n3.Orange \n4.Peach");
            Console.Write("Please enter a tree number: ");
            
            int treeId = InputCheck(Console.ReadLine(), new int[4] { 1, 2, 3, 4 });
            var treeTypesList = typeService.GetTreeTypes(treeId);
            typeService.PrintTreeTypes(treeTypesList);

            int enteredNum = InputCheck(Console.ReadLine(), new int[2] { 1, 2 });
            int typeId = treeTypesList[enteredNum - 1].Id;

            TreeTypeChoosing(treesWithCount, treeId, typeId);
        }


        /// <summary>
        /// Method to check input from console.
        /// </summary>
        public int InputCheck(string number, int[] options)
        {
            bool isNumber = int.TryParse(number, out int inputNum);

            if (isNumber && options.Contains(inputNum))
            {
                return inputNum;
            }
            else
            {
                do
                {
                    Console.Write("Input is wrong, try again: ");
                    isNumber = int.TryParse(Console.ReadLine(), out inputNum);
                }
                while (!isNumber || inputNum <= 0 || !options.Contains(inputNum));
                return inputNum;
            }
        }


        /// <summary>
        /// Method to check validity of tree count entered from console.
        /// </summary>
        public int CountCheck(string count)
        {
            bool isNum = int.TryParse(count, out int number);
            if(isNum && number > 0)
            {
                return number;
            }
            else
            {
                do
                {
                    Console.Write("Wrong input for count, try again: ");
                    isNum = int.TryParse(Console.ReadLine(), out number);
                }
                while (!isNum || number <= 0);
                return number;
            }
        }


        /// <summary>
        /// Method to create a tree according to tree id and tree type id.
        /// </summary>
        public void TreeTypeChoosing(Dictionary<int, int> treesWithCount, int treeId, int typeId)
        {
            ITreeFactory treeFactory = new TreeFactory();
            var tree = treeFactory.CreateTree(treeId, typeId);
            Console.Write($"How many {tree.TreeType.TypeName}s do you want to plant: ");
            int count = CountCheck(Console.ReadLine());
            treesWithCount.Add(tree.TreeType.Id, count);

            Console.Write("Want more trees? y/n: ");
            var inputString = Console.ReadLine();
            while (inputString != "y" && inputString != "n")
            {
                Console.Write("Wrong input, please enter y or n: ");
                inputString = Console.ReadLine();
            }
            MoreTrees(treesWithCount, inputString);
        }


        /// <summary>
        /// Method to select more trees.
        /// </summary>
        public void MoreTrees(Dictionary<int, int> treesWithCount, string yesOrNo)
        {
            if (yesOrNo == "y")
            {
                TreeChoosing(treesWithCount);
            }
            else if (yesOrNo == "n")
            {
                PrintInfo(treesWithCount);
            }
        }


        /// <summary>
        /// Method to get a tree by it id.
        /// </summary>
        public ITreeBase GetTreeById(int treeId)
        {
            List<ITreeBase> trees = new List<ITreeBase>()
            {
                new Apple(), new Cherry(), new Orange(), new Peach()
            };
            return trees.First(c => c.Id == treeId);
        }

        /// <summary>
        /// Method to print info about selected trees.
        /// </summary>
        public void PrintInfo(Dictionary<int,int> treesWithCount)
        {
            ITreeTypeService typeService = new TreeTypeService();
            int avgRiseTime = 0;
            int area = 0;

            Console.WriteLine("===============================================================");
            Console.WriteLine($"Trees you chose:");

            foreach (var pair in treesWithCount)
            {
                var treeType = typeService.GetTreeType(pair.Key);
                Console.WriteLine(treeType.TypeName+ ": " + pair.Value);
                var tree = GetTreeById(treeType.TreeId);
                avgRiseTime += (int)(tree.MaxHeight / tree.RiseSpeed);
                area += (int)(tree.MaxAreaSize * pair.Value);
            }

            Console.WriteLine($"Total area required: {area}m2. \nAverage rise time: {avgRiseTime} years.");
            Console.WriteLine("===============================================================");
        }
    }
}
