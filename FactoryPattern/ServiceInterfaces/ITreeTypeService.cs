using FactoryPattern.TreeTypes;

namespace FactoryPattern.ServiceInterfaces
{
    public interface ITreeTypeService
    {
        /// <summary>
        /// Method to get a tree type.
        /// </summary>
        public TreeType GetTreeType(int typeId);

        /// <summary>
        /// Method to print tree types according to tree id.
        /// </summary>
        public void PrintTreeTypes(List<TreeType> treeTypesList);

        /// <summary>
        /// Method to get a tree type.
        /// </summary>
        public List<TreeType> GetTreeTypes(int treeId);
    }
}
