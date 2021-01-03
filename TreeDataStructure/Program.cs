using System;
using TreeDataStructure.Tree;

namespace TreeDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tree Structure
            Console.WriteLine("########### Tree Yapısı ############");
            BTS nums = new BTS();
            nums.Add(23);
            nums.Add(16);
            nums.Add(3);
            nums.Add(22);
            nums.Add(45);
            nums.Add(37);
            nums.Add(99);

            #endregion

            #region Inorder Traversal
            Console.WriteLine("########### Inorder Dolaşma ############");
            nums.InOrder(nums.root);
            #endregion

            #region Preorder Traversal
            Console.WriteLine("########### PreOrder Dolaşma ############");
            nums.PreOrder(nums.root);

            #endregion

            #region Postorder Traversal
            Console.WriteLine("########### PostOrder Dolaşma ############");
            nums.PostOrder(nums.root);
            #endregion

            #region Min_Max
            Console.WriteLine("########### Minimum ve Maksimum Bulma ############");
            Console.WriteLine("Minimum Değer: " + nums.Minimum());
            Console.WriteLine("Maximum Değer: " + nums.Maximum());

            #endregion

            #region Search
            Console.WriteLine("########### Arama Algoritması ############");
            Console.WriteLine("Bulunan Değer: " + nums.Find(99).Data);

            #endregion

            #region Delete
            Console.WriteLine("########### Silme Algoritması ############");

            // * yaprak silme
            nums.Delete(3);
            nums.InOrder(nums.root);
            Console.WriteLine();

            // * parent node silme
            nums.Delete(16);
            nums.InOrder(nums.root);
            Console.WriteLine();

            // * root silme
            nums.Delete(23);
            nums.InOrder(nums.root);
            Console.WriteLine();

            #endregion
            
            Console.ReadKey();


        }
    }
}
