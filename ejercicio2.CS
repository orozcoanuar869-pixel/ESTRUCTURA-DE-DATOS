
using System;
using System.Collections.Generic;

// ==========================================
// 1. CLASE NODE
// ==========================================
public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

// ==========================================
// 2. CLASE BINARY SEARCH TREE
// ==========================================
public class BinarySearchTree
{
    public Node Root;

    // Insercion recursiva
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Mostrar el arbol
    public void Display(Node root, int space = 0)
    {
        if (root == null)
            return;

        space += 5;

        Display(root.Right, space);

        Console.WriteLine();

        for (int i = 5; i < space; i++)
            Console.Write(" ");

        Console.WriteLine(root.Data);

        Display(root.Left, space);
    }

    // Identificar nodos hoja
    public void ShowLeaves(Node root)
    {
        if (root == null)
            return;

        if (root.Left == null && root.Right == null)
            Console.Write(root.Data + " ");

        ShowLeaves(root.Left);
        ShowLeaves(root.Right);
    }

    // Contar nodos hoja
    public int CountLeaves(Node root)
    {
        if (root == null)
            return 0;

        if (root.Left == null && root.Right == null)
            return 1;

        return CountLeaves(root.Left) +
               CountLeaves(root.Right);
    }

    // Busqueda
    public bool Search(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.Data == key)
            return true;

        return key < root.Data
            ? Search(root.Left, key)
            : Search(root.Right, key);
    }
}

// ==========================================
// 3. CLASE TREE TRAVERSALS
// ==========================================
public class TreeTraversals
{
    // Preorden: Raiz, Izquierda, Derecha
    public void PreOrder(Node node)
    {
        if (node == null)
            return;

        Console.Write(node.Data + " ");

        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // Inorden: Izquierda, Raiz, Derecha
    public void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);

        Console.Write(node.Data + " ");

        InOrder(node.Right);
    }

    // Posorden: Izquierda, Derecha, Raiz
    public void PostOrder(Node node)
    {
        if (node == null)
            return;

        PostOrder(node.Left);
        PostOrder(node.Right);

        Console.Write(node.Data + " ");
    }

    // BFS: Recorrido por niveles
    public void LevelOrder(Node root)
    {
        if (root == null)
            return;

        Queue<Node> queue = new Queue<Node>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }

    // Mostrar todos los recorridos
    public void ShowAllTraversals(Node root)
    {
        Console.WriteLine("\nRECORRIDOS DEL ARBOL BST:");

        Console.Write("Preorden: ");
        PreOrder(root);

        Console.Write("\nInorden: ");
        InOrder(root);

        Console.Write("\nPosorden: ");
        PostOrder(root);

        Console.Write("\nPor niveles (BFS): ");
        LevelOrder(root);

        Console.WriteLine();
    }
}

// ==========================================
// 4. CLASE PROGRAM
// ==========================================
public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        int[] claves = { 45, 23, 67, 12, 34, 56, 89 };

        // Insertar claves
        foreach (int clave in claves)
        {
            bst.Insert(clave);
        }

        // Mostrar arbol
        Console.WriteLine("ARBOL BST RESULTANTE:");
        bst.Display(bst.Root);

        // Mostrar nodos hoja
        Console.WriteLine("\nNODOS HOJA:");
        bst.ShowLeaves(bst.Root);

        // Contar nodos hoja
        Console.WriteLine("\n\nCANTIDAD DE NODOS HOJA: "
            + bst.CountLeaves(bst.Root));

        // Ejecutar recorridos
        TreeTraversals traversals = new TreeTraversals();

        traversals.ShowAllTraversals(bst.Root);
    }
}
