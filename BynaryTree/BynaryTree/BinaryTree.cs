namespace BynaryTree
{
    public class BinaryTree
    {
        public TreeNode? Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private TreeNode InsertRec(TreeNode? root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return root;
            }

            if (value < root.Value)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else
            {
                root.Right = InsertRec(root.Right, value);
            }

            return root;
        }

        public void InOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left!);
                Console.Write(root.Value + " ");
                InOrderTraversal(root.Right!);
            }
        }

        public void PrintTree()
        {
            PrintTreeRec(Root, 0);
        }

        private void PrintTreeRec(TreeNode root, int depth)
        {
            if (root == null)
            {
                return;
            }

            const int SpacesPerLevel = 4;

            PrintTreeRec(root.Right, depth + 1);

            Console.Write(new string(' ', depth * SpacesPerLevel));
            Console.WriteLine(root.Value);

            PrintTreeRec(root.Left, depth + 1);
        }

        public bool Search(int value)
        {
            return SearchRec(Root, value);
        }

        private bool SearchRec(TreeNode root, int value)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Value == value)
            {
                return true;
            }
            else if (value < root.Value)
            {
                return SearchRec(root.Left!, value);
            }
            else
            {
                return SearchRec(root.Right!, value);
            }

        }
    }
}
