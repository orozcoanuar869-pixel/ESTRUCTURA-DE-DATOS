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

public class TreeTraversals
{
    // Recorrido Preorden: Raíz, Izquierda, Derecha
    public void PreOrder(Node node)
    {
        if (node == null)
            return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
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

    // Recorrido Posorden: Izquierda, Derecha, Raíz
    public void PostOrder(Node node)
    {
        if (node == null)
            return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    public static void Main()
    {
        // Árbol del Ejercicio 1
        Node root = new Node(45);

        root.Left = new Node(23);
        root.Right = new Node(67);

        root.Left.Left = new Node(12);
        root.Left.Right = new Node(34);

        root.Right.Left = new Node(56);
        root.Right.Right = new Node(89);

        TreeTraversals tree = new TreeTraversals();

        Console.WriteLine("Recorrido Preorden:");
        tree.PreOrder(root);

        Console.WriteLine("\n\nRecorrido Inorden:");
        tree.InOrder(root);

        Console.WriteLine("\n\nRecorrido Posorden:");
        tree.PostOrder(root);

        Console.ReadKey();
    }
}
