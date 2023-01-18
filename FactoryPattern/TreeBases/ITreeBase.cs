
using FactoryPattern.TreeTypes;

namespace FactoryPattern.TreeBases
{
    public interface ITreeBase
    {
        /// <summary>
        /// Gets tree id.
        /// </summary>
        public int Id { get; }

        // <summary>
        /// Gets name of fruit tree.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets rising speed of the tree per year in metres.
        /// </summary>
        public double RiseSpeed { get; }

        /// <summary>
        /// Gets max area where tree fit in in metre squares.
        /// </summary>
        public double MaxAreaSize { get; }

        /// <summary>
        /// Gets max height of a tree.
        /// </summary>
        public double MaxHeight { get; }

        /// <summary>
        /// Gets the type of the tree.
        /// </summary>
        public TreeType TreeType { get; }
    }
}
