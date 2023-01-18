using FactoryPattern.TreeBases;

namespace FactoryPattern.ServiceInterfaces
{
    public interface ITreeService
    {
        /// <summary>
        /// Method for choosing tree according to user input.
        /// </summary>
        public void TreeChoosing(Dictionary<int,int> trees);

        /// <summary>
        /// Method to check input from console.
        /// </summary>
        public int InputCheck(string number, int[] options);

        /// <summary>
        /// Method to create a tree according to tree id and tree type id.
        /// </summary>
        public void TreeTypeChoosing(Dictionary<int,int> trees, int treeId, int typeId);

        /// <summary>
        /// Method to select more trees.
        /// </summary>
        public void MoreTrees(Dictionary<int, int> trees, string yesNo);

        /// <summary>
        /// Method to get a tree by it id.
        /// </summary>
        public ITreeBase GetTreeById(int treeId);

        /// <summary>
        /// Method to print info about selected trees.
        /// </summary>
        public void PrintInfo(Dictionary<int, int> trees);
    }
}
