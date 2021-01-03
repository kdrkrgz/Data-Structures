using System;

namespace TreeDataStructure.Tree
{
    public class Node
    {
        public int Data;
        public Node left;
        public Node right;

        public void Goster() => Console.WriteLine(Data + " ");
    }
}