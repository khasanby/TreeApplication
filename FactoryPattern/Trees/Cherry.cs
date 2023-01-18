using FactoryPattern.TreeBases;
using FactoryPattern.TreeTypes;

namespace FactoryPattern.Trees
{
    public class Cherry : ITreeBase
    {
        /// <summary>
        /// Id of an apple tree.
        /// </summary>
        public int Id => 2;

        // <summary>
        /// Name of fruit tree.
        /// </summary>
        public string Name => nameof(Cherry);

        /// <summary>
        /// Rising speed of the tree per year in metres.
        /// </summary>
        public double RiseSpeed => 1.35;

        /// <summary>
        /// Max area where tree fit in in metre squares.
        /// </summary>
        public double MaxAreaSize => 0.85;

        /// <summary>
        /// Max height of a tree.
        /// </summary>
        public double MaxHeight => 13.7;

        /// <summary>
        /// Tree type.
        /// </summary>
        public TreeType TreeType { get; set; }
    }
}
