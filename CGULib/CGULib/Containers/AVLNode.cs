using System;

namespace CGULib.Containers
{
    /// <summary>
    /// AVLNode Base class transcribed from:
    /// https://www.geeksforgeeks.org/avl-tree-set-1-insertion/
    /// https://www.geeksforgeeks.org/avl-tree-set-2-deletion/
    /// 
    /// IComparable interface to be implemented by derived class.
    /// </summary>
    public abstract class AVLNode<T> : IComparable<T>
    {
        protected T key;
        protected AVLNode<T> left, right;
        protected int height;

        public T Key { get => key; }
        public int Height { get => height; }
        public bool HasLeft { get => left != null; }
        public bool HasRight { get => right != null; }

        public AVLNode(T key)
        {
            this.key = key;
            height = 1;
        }

        public static int GetHeight(AVLNode<T> node)
        {
            if (node == null)
                return 0;
            else
                return node.height;
        }

        public static int GetBalance(AVLNode<T> node)
        {
            if (node == null)
                return 0;
            else
                return GetHeight(node.left) - GetHeight(node.right);
        }

        public virtual AVLNode<T> Insert(AVLNode<T> root, AVLNode<T> node)
        {
            if (root == null)
                return node;

            switch (node.CompareTo(root.key))
            {
                case -1:
                    root.left = Insert(root.left, node);
                    break;
                case 1:
                    root.right = Insert(root.right, node);
                    break;
                case 0:
                    return root;
            }

            root.height = 1 + Math.Max(GetHeight(root.left), GetHeight(node.right));

            int balanceFactor = GetBalance(root);

            if(balanceFactor > 1 && node.CompareTo(root.left.key) < 0)
                return RotateRight(root);
            
            else if(balanceFactor < -1 && node.CompareTo(root.right.key) > 0)
                return RotateLeft(root);
            
            else if(balanceFactor > 1 && node.CompareTo(root.left.key) > 0)
            {
                root.left = RotateLeft(root.left);
                return RotateRight(root);
            }
            else if(balanceFactor < -1 && node.CompareTo(root.right.key) < 0)
            {
                root.right = RotateRight(root.right);
                return RotateLeft(root);
            }

            return root;
        }

        public virtual AVLNode<T> Delete(AVLNode<T> root, AVLNode<T> node)
        {
            if (root == null)
                return root;

            switch (node.CompareTo(root.key))
            {
                case 1:
                    root.right = Delete(root.right, node);
                    break;
                case -1:
                    root.left = Delete(root.left, node);
                    break;
                case 0:
                    if(!root.HasLeft || !root.HasRight)
                    {
                        AVLNode<T> tempNode = root.HasLeft ? root.left : root.right;

                        if (tempNode == null)
                        {
                            tempNode = root;
                            root = null;
                        }
                        else
                            root = tempNode;
                    }
                    else
                    {
                        AVLNode<T> tempNode = Min(root.right);
                        root.key = tempNode.key;
                        root.right = Delete(root.right, tempNode);
                    }
                    break;
            }

            if (root == null)
                return root;

            root.height = 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));

            int balanceFactor = GetBalance(root);

            if (balanceFactor > 1 && GetBalance(root.left) >= 0)
                return RotateRight(root);

            else if (balanceFactor > 1 && GetBalance(root.left) < 0)
            {
                root.left = RotateLeft(root.left);
                return RotateRight(root);
            }

            else if (balanceFactor < -1 && GetBalance(root.right) <= 0)
                return RotateLeft(root);

            else if (balanceFactor < -1 && GetBalance(root.right) > 0)
            {
                root.right = RotateRight(root.right);
                return RotateLeft(root);
            }

            return root;
        }

        public virtual AVLNode<T> Min(AVLNode<T> node)
        {
            while (node.HasLeft)
                node = node.left;
            return node;
        }

        public virtual AVLNode<T> Max(AVLNode<T> node)
        {
            while (node.HasRight)
                node = node.right;
            return node;
        }

        protected virtual AVLNode<T> RotateRight(AVLNode<T> root)
        {
            AVLNode<T> x = root.left;
            AVLNode<T> T2 = x.right;
 
            x.right = root;
            root.left = T2;
 
            root.height = 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
            x.height = 1 + Math.Max(GetHeight(x.left), GetHeight(x.right));
 
            return x;
        }

        protected virtual AVLNode<T> RotateLeft(AVLNode<T> root)
        {
            AVLNode<T> y = root.right;
            AVLNode<T> T2 = y.left;
 
            y.left = root;
            root.right = T2;
 
            root.height = 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
            y.height = 1 + Math.Max(GetHeight(y.left), GetHeight(y.right));
 
            return y;
        }

        public abstract int CompareTo(T other);
    }
}
