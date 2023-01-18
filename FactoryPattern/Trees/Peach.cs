using FactoryPattern.TreeBases;
using FactoryPattern.TreeTypes;

namespace FactoryPattern.Trees
{
    public class Peach : ITreeBase
    {
        /// <summary>
        /// Id of an orange tree.
        /// </summary>
        public int Id => 4;

        // <summary>
        /// Gets name of fruit tree.
        /// </summary>
        public string Name => nameof(Peach);

        /// <summary>
        /// Gets rising speed of the tree per year in metres.
        /// </summary>
        public double RiseSpeed => 1.2;

        /// <summary>
        /// Gets max area where tree fit in in metre squares.
        /// </summary>
        public double MaxAreaSize => 0.75;

        /// <summary>
        /// Gets max height of a tree.
        /// </summary>
        public double MaxHeight => 10.5;

        /// <summary>
        /// Tree type.
        /// </summary>
        public TreeType TreeType { get; set; }
    }
}
