using FactoryPattern.TreeBases;

namespace FactoryPattern.FactoryInterfaces
{
    public interface ITreeFactory
    {
        /// <summary>
        /// Method to create a tree by tree id and type id.
        /// </summary>
        public ITreeBase CreateTree(int treeId, int typeId);
    }
}
