using FactoryPattern.TreeBases;
using FactoryPattern.TreeTypes;

namespace FactoryPattern.Trees
{
    public class Orange : ITreeBase
    {
        /// <summary>
        /// Id of an orange tree.
        /// </summary>
        public int Id => 3;

        // <summary>
        /// Name of fruit tree.
        /// </summary>
        public string Name => nameof(Orange);

        /// <summary>
        /// Rising speed of the tree per year in metres.
        /// </summary>
        public double RiseSpeed => 1.15;

        /// <summary>
        /// Max area where tree fit in in metre squares.
        /// </summary>
        public double MaxAreaSize => 0.8;

        /// <summary>
        /// Max height of a tree.
        /// </summary>
        public double MaxHeight => 12;

        /// <summary>
        /// Tree type.
        /// </summary>
        public TreeType TreeType { get; set; }
    }
}
