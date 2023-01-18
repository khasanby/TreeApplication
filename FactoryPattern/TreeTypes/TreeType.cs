
namespace FactoryPattern.TreeTypes
{
    public class TreeType
    {
        public TreeType(int id, string typeName, int treeId)
        {
            Id = id;
            TypeName = typeName;
            TreeId = treeId;
        }

        public int Id { get; private set; }

        public string TypeName { get; private set; }

        public int TreeId { get; private set; }
    }
}
