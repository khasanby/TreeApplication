using FactoryPattern.FactoryInterfaces;
using FactoryPattern.ServiceInterfaces;
using FactoryPattern.Services;
using FactoryPattern.TreeBases;
using FactoryPattern.Trees;

namespace FactoryPattern.FactoryMethods
{
    public sealed class TreeFactory : ITreeFactory
    {
        /// <summary>
        /// Method to create a tree with specific type.
        /// </summary>
        public ITreeBase CreateTree(int treeId, int typeId)
        {
            ITreeTypeService typeService = new TreeTypeService();
            switch (treeId)
            {
                case 1:
                    var apple = new Apple();
                    apple.TreeType = typeService.GetTreeType(typeId);
                    return apple;
                case 2:
                    var orange = new Orange();
                    orange.TreeType = typeService.GetTreeType(typeId);
                    return orange;
                case 3:
                    var peach = new Peach();
                    peach.TreeType = typeService.GetTreeType(typeId);
                    return peach;
                case 4:
                    var cherry = new Cherry();
                    cherry.TreeType = typeService.GetTreeType(typeId);
                    return cherry;
                default:
                    throw new ArgumentException("No trees created");
            }
        }
    }
}
