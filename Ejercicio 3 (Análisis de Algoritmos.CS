using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    // Inserta un valor en el Árbol Binario de Búsqueda
    public Node Insert(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = Insert(root.Left, data);
        else if (data > root.Data)
            root.Right = Insert(root.Right, data);

        return root;
    }

    // Recorrido Inorden: Izquierda, Raíz, Derecha
    public void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    public static void Main()
    {
        BinarySearchTree tree = new BinarySearchTree();
        Node root = null;

        int[] values = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int value in values)
        {
            root = tree.Insert(root, value);
        }

        Console.WriteLine("Recorrido Inorden:");
        tree.InOrder(root);

        Console.WriteLine();
        Console.ReadKey();
    }
}
