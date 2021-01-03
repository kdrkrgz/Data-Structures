namespace TreeDataStructure.Tree
{
    // * Binary Search Tree ile arama, ekleme, silme, dolaşma, minimum ve maksimum gibi işlemleri gerçekleştireceğimiz sınıftır. 
    public class BTS
    {
        public Node root;
        public BTS() => root = null;

        public void Add(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
               Node node = root;
               Node parentNode;
               while (true)
               {
                   parentNode = node;
                   if (i < node.Data)
                   {
                       //* sol dal
                       node = node.left;
                       if (node == null)
                       {
                           parentNode.left = newNode;
                           break;
                       }
                   }
                   else
                   {
                       //* sağ dal
                       node = node.right;
                       if (node == null)
                       {
                           parentNode.right = newNode;
                           break;
                       }
                   }
               } 
            }
        }
        
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                root.Goster();
                InOrder(root.right);
            }
        }

        public void PreOrder(Node root)
        {
            if (root != null)
            {
                root.Goster();
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                root.Goster();
            }
        }
    
        public int Minimum(){
            Node node = root;
            while (node.left != null)
                node = node.left;

            return node.Data;
        }

        public int Maximum(){
            Node node = root;
            while (node.right != null)
                node = node.right;

            return node.Data;
        }

        public Node Find(int value)
        {
            Node node = root;
            while(node.Data != value)
            {
                if (value < node.Data)
                    node = node.left;
                else
                    node = node.right;
                
                if (node == null)
                    return null;
            }
            return node;
        }
    
        public void Delete(int value)
        {
            root = KayitSil(root, value);
        }

        private Node KayitSil(Node root, int value)
        {
            //* root değerine bakarak tree yapısının boş olup olmadığı kontrol edilir.
            if (root == null)
                return root;
            //* Recursive olarak ilerle
            if(value < root.Data)
                root.left = KayitSil(root.left, value);
            else if(value > root.Data)
                root.right = KayitSil(root.right, value);
            //* root silinecekse 
            else
            {
                if (root.left == null)
                    return root.right;
                else if(root.right == null)
                    return root.left;
                // * iki çocuklu bir node varsa: subtree inorder ilerlemek gerekir.
                root.Data = MinValue(root.right);
                // * minimum deperi dikkate alarak silme işlemi
                root.right = KayitSil(root.right, root.Data);
            }
            return root;
        }

        private int MinValue(Node root)
        {
            int minimumValue = root.Data;
            while(root.left != null)
            {
                minimumValue = root.left.Data;
                root = root.left;
            }
            return minimumValue;
        }
    }
}