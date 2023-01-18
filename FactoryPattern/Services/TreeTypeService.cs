using FactoryPattern.ServiceInterfaces;
using FactoryPattern.TreeTypes;

namespace FactoryPattern.Services
{
    public sealed class TreeTypeService : ITreeTypeService
    {
        /// <summary>
        /// Method to get a tree type.
        /// </summary>
        public TreeType GetTreeType(int typeId)
        {
            var typesData = new List<TreeType>()
            {
                new TreeType(1, "Red apple", 1), new TreeType(2, "Golden apple", 1), new TreeType(3, "Montmorency", 2), new TreeType(4, "Bing", 2),
                new TreeType(5, "Clementine", 3), new TreeType(6, "Seville", 3), new TreeType(7, "Nectarine", 4), new TreeType(8, "Yellow peach", 4),
            };
            return typesData.First(c => c.Id == typeId);
        }

        /// <summary>
        /// Method to get a tree type.
        /// </summary>
        public List<TreeType> GetTreeTypes(int treeId)
        {
            var typesData = new List<TreeType>()
            {
                new TreeType(1, "Red apple", 1), new TreeType(2, "Golden apple", 1), new TreeType(3, "Montmorency", 2), new TreeType(4, "Bing", 2),
                new TreeType(5, "Clementine", 3), new TreeType(6, "Seville", 3), new TreeType(7, "Nectarine", 4), new TreeType(8, "Yellow peach", 4),
            };
            return typesData.Where(c => c.TreeId == treeId).ToList();
        }

        /// <summary>
        /// Method to print tree types according to tree id.
        /// </summary>
        public void PrintTreeTypes(List<TreeType> treeTypesList)
        {
            int index = 1;
            foreach (var type in treeTypesList)
            {
                Console.WriteLine($"{index}.{type.TypeName}");
                index++;
            }
            Console.Write("Please choose a tree type: ");
        }
    }
}
