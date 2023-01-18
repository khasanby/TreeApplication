using FactoryPattern.TreeBases;
using FactoryPattern.TreeTypes;

namespace FactoryPattern.Trees
{
    public class Apple : ITreeBase
    {
        /// <summary>
        /// Id of an apple tree.
        /// </summary>
        public int Id => 1;

        // <summary>
        /// Name of fruit tree.
        /// </summary>
        public string Name => nameof(Apple);

        /// <summary>
        /// Rising speed of the tree per year in metres.
        /// </summary>
        public double RiseSpeed => 1.5;

        /// <summary>
        /// Max area where tree fit in in metre squares.
        /// </summary>
        public double MaxAreaSize => 0.55;

        /// <summary>
        /// Max height of a tree.
        /// </summary>
        public double MaxHeight => 11.5;

        /// <summary>
        /// Tree type.
        /// </summary>
        public TreeType TreeType { get; set; }
    }
}
