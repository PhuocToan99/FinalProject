
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AVLTree
{
    class AVLTreeNode<T> : IComparable
       where T : IComparable
    {

        #region Properties
        //Khai bao cac thuoc tinh cua cay

        public T Value { get; set; }

        public AVLTreeNode<T> LeftChild { get; set; } //Cay con trai
        public AVLTreeNode<T> RightChild { get; set; } //Cay con phai
        public AVLTreeNode<T> Parent { get; set; } //Node cha

        public bool IsLeaf //Ham khoi tao la cay
        {
            get { return LeftChild == null && RightChild == null; }
        }
        public bool CheckLeftChild
        {
            get { return LeftChild != null; }
        }
        public bool CheckRightChild // Ham khoi tao cay con phai
        {
            get { return RightChild != null; }
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
        #endregion

        public AVLTreeNode(T value)
        {
            this.Value = value;
        }
        public AVLTreeNode()
        {

        }

        #region IComparable Members
        //Vi node la dai luong nguoi dung khoi tao nen cac phep toan so sanh phari duoc cai dat
        public int CompareTo(object obj)
        {
            AVLTreeNode<T> node = obj as AVLTreeNode<T>;

            return this.Value.CompareTo(node.Value);
        }

        #endregion

        public static bool operator <(AVLTreeNode<T> node1, AVLTreeNode<T> node2) //Khoi tao phep so sanh  < cho gia tri cua node
        {
            return node1.Value.CompareTo(node2.Value) < 0;
        }
        public static bool operator >(AVLTreeNode<T> node1, AVLTreeNode<T> node2) //Khoi tao phep so sanh  > cho gia tri cua node
        {
            return node1.Value.CompareTo(node2.Value) > 0;
        }
    }

    class AVLTree<T>
        where T : IComparable
    {
        #region Properties

        public AVLTreeNode<T> Root { get; set; } //Node goc
        private List<T> _list; //Danh sach de in ket qua duyet
        public int Count { get; private set; } //Bien dem so node cua cay

        #endregion

        public AVLTree() //Khoi tao cay
        {
            Count = 0;
            _list = new List<T>();
        }

        public AVLTree(T value)
            : this()
        {
            Add(value);
        }

        #region InOrder Traversal
        public virtual List<T> InOrderTraverse() // DuyetLNR
        {
            _list.Clear(); // Khoi tao danh sach trong
            InOrderTraverse(Root);
            return _list;
        }
        private void InOrderTraverse(AVLTreeNode<T> node) //Ham duyet cua LNR
        {
            if (node == null)
                return;
            InOrderTraverse(node.LeftChild);
            _list.Add(node.Value);
            InOrderTraverse(node.RightChild);
        }
        #endregion

        #region PreOrder Traversal
        public virtual List<T> PreOrderTraverse()
        {
            _list.Clear();// Khoi tao danh sach trong
            PreOrderTraverse(Root);
            return _list;
        }
        private void PreOrderTraverse(AVLTreeNode<T> node)//Ham duyet cua NLR
        {
            if (node == null)
                return;
            _list.Add(node.Value);
            PreOrderTraverse(node.LeftChild);
            PreOrderTraverse(node.RightChild);
        }
        #endregion

        #region PostOrder Traversal
        public virtual List<T> PostOrderTraverse()
        {
            _list.Clear();// Khoi tao danh sach trong
            PostOrderTraverse(Root);
            return _list;
        }
        private void PostOrderTraverse(AVLTreeNode<T> node)//Ham duyet cua LRN
        {
            if (node == null)
                return;
            PostOrderTraverse(node.LeftChild);
            PostOrderTraverse(node.RightChild);
            _list.Add(node.Value);
        }
        #endregion

        #region Add Node //Them node

        public virtual int GetHeight()  //Ham tinh chieu cao cay
        {
            return this.GetHeight(this.Root);
        }
        public int GetHeight(AVLTreeNode<T> startNode)
        {
            //Neu  cay rong=>Chieu cao cay la 0
            if (startNode == null)
                return 0;
            //Neu ton tai cay
            //Duyet cay con trai de lay chieu cao,tuong tu voi cay con phai
            //Sum tat ca+1(node goc)
            else
                return 1 + Math.Max(GetHeight(startNode.LeftChild), GetHeight(startNode.RightChild));
        }

        #endregion
        private AVLTreeNode<T> balance_tree(AVLTreeNode<T> parent)
        {
            int b_factor = balance_factor(parent);//Khoi tao hang so can bang cua cay
            if (b_factor > 1)//Cay bi mat can bang
            {
                if (balance_factor(parent.LeftChild) > 0)
                {
                    parent = RotateLL(parent);//Quay trai
                }
                else
                {
                    parent = RotateLR(parent);//Quay trai phai
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(parent.RightChild) > 0)
                {
                    parent = RotateRL(parent);//Quay phai trai
                }
                else
                {
                    parent = RotateRR(parent);//Quay phai phai
                }
            }
            return parent;
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
            //Ham bo tro cho cac ham xu li lien quan den hang so can bang cua cay
        }
        private int getHeight(AVLTreeNode<T> current)//Ham tinh chieu cao cu cay 
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.LeftChild);//Chieu cao cay con trai
                int r = getHeight(current.RightChild);//Chieu cao cay con phai
                int m = max(l, r);
                height = m + 1;//Chieu cao cua toan cay(+1 la tinh node goc)
            }
            return height;
        }
        private int balance_factor(AVLTreeNode<T> current)//Ham tinh he so can bang->can bang cay
        {
            int l = getHeight(current.LeftChild);
            int r = getHeight(current.RightChild);
            int b_factor = l - r;//Lay he so chieu cao giua cay con trai va phai
            return b_factor;
        }
        //Cac phep quay(Can bang cay)
        private AVLTreeNode<T> RotateRR(AVLTreeNode<T> parent)
        {
            AVLTreeNode<T> pivot = parent.RightChild;
            parent.RightChild = pivot.LeftChild;
            pivot.LeftChild = parent;
            return pivot;
        }
        private AVLTreeNode<T> RotateLL(AVLTreeNode<T> parent)
        {
            AVLTreeNode<T> pivot = parent.LeftChild;
            parent.LeftChild = pivot.RightChild;
            pivot.RightChild = parent;
            return pivot;
        }
        private AVLTreeNode<T> RotateLR(AVLTreeNode<T> parent)
        {
            AVLTreeNode<T> pivot = parent.LeftChild;
            parent.LeftChild = RotateRR(pivot);
            return RotateLL(parent);
        }
        private AVLTreeNode<T> RotateRL(AVLTreeNode<T> parent)
        {
            AVLTreeNode<T> pivot = parent.RightChild;
            parent.RightChild = RotateLL(pivot);
            return RotateRR(parent);
        }
        #region Check
        public virtual bool Check(T value)
        {
            AVLTreeNode<T> node = new AVLTreeNode<T>(value);
            if (Root == null)
            {
                Root = node;
                return true;
            }

            return Check(Root, node);
        }
        private bool Check(AVLTreeNode<T> parentNode, AVLTreeNode<T> node)
        {
            if (parentNode.Value.Equals(node.Value))
                return false;

            if (parentNode > node)
            {
                if (!parentNode.CheckLeftChild)
                {
                    parentNode.LeftChild = node;
                    node.Parent = parentNode;
                    return true;
                }
                else
                    return Check(parentNode.LeftChild, node);
            }
            else
            {
                if (!parentNode.CheckRightChild)
                {
                    parentNode.RightChild = node;
                    node.Parent = parentNode;
                    return true;
                }
                else
                    return Check(parentNode.RightChild, node);
            }
        }

        #endregion

        public virtual void Add(params T[] values)
        {
            Array.ForEach(values, value => Add(value));
        }
        public virtual bool Add(T value)
        {

            AVLTreeNode<T> node = new AVLTreeNode<T>(value);

            if (Root == null) //Truong hop cay rongg\
            {
                Count++;
                Root = node;
                return true;
            }
            else
            {
                Root = RecursiveInsert(Root, node);
                Count++;
                return true;
            }

        }

        private AVLTreeNode<T> RecursiveInsert(AVLTreeNode<T> current, AVLTreeNode<T> n)
        {
            if (current == null)
            { //neu node chua co du lieu
                current = n;
                return current;//Gan not hien tai=n
            }
            else if (n < current)
            {//neu info node nhap vao be hon node hien co
                current.LeftChild = RecursiveInsert(current.LeftChild, n);//Gan node vao cay con trai
                current = balance_tree(current);
            }
            else if (n > current)
            {//neu info node nhap vao lon hon node hien co
                current.RightChild = RecursiveInsert(current.RightChild, n);//Gaan node vao cay con phai
                current = balance_tree(current);
            }
            return current;//Tra con tro ve node hien tai
        }
        public virtual void ClearChildren(AVLTreeNode<T> node)  //Xoa cac cay con
        {
            //Xoa cay con trai
            if (node.CheckLeftChild)
            {
                ClearChildren(node.LeftChild);
                node.LeftChild.Parent = null;
                node.LeftChild = null;
            }
            //Xoa cay con trai
            if (node.CheckRightChild)
            {
                ClearChildren(node.RightChild);
                node.RightChild.Parent = null;
                node.RightChild = null;
            }
        }

        public virtual void Clear() //Ham xoa
        {
            //Neu cay rong thoat khoi hamm
            if (Root == null)
                return;
            //Neu ton tai cay
            ClearChildren(Root); //Xoa node goc
            Root = null;
            Count = 0;
        }
        public virtual AVLTreeNode<T> Search(T value) //Ham tim 1 gia tri trenn cay
        {
            return Search(Root, value);
        }
        public virtual AVLTreeNode<T> Search(AVLTreeNode<T> node, T value)
        {
            //Neu ko nhap gia tri can tim
            if (node == null)
                return null;
            //Neu gia tri can tim co tren cay=>Tra ve gia tri can tim
            if (node.Value.Equals(value))
                return node;
            //Duyet truong hop
            else
            {
                //Gia tri nhap vao(nodevalue)<node goc(Ham compare to tra ve >0)=>>Tim cay con trai
                if (node.Value.CompareTo(value) > 0)
                    return Search(node.LeftChild, value);

                //Nguoc lai=>>Tim cay con trai
                else
                    return Search(node.RightChild, value);
            }
        }
        public virtual Queue<T> FindPath(T value) //Ham truy van
        {
            Queue<T> q = new Queue<T>(); //khoi tao truy van

            AVLTreeNode<T> node = this.Root;
            bool isFounded = false; //Khoi tao co tim thay bang sai

            while (node != null)//Khi chua duyet het cay
            {
                if (node.Value.Equals(value))
                {
                    isFounded = true;//Khi tim thay gia tri can tim(duoc nhap)
                    break;//Thoat vong lap
                }
                else
                {
                    if (node.Value.CompareTo(value) > 0)
                    {
                        node = node.LeftChild;
                    }
                    else
                    {
                        node = node.RightChild;
                    }
                    if (node != null) q.Enqueue(node.Value);

                }
            }
            if (!isFounded)
            {
                q.Clear();
                q = null;
            }
            return q;
        }
        #region Delete check
        public virtual bool CheckRemove(T value)
        {
            return CheckRemove(Root, value);
        }

        private bool CheckRemove(AVLTreeNode<T> node, T value)
        {
            if (node == null)
                return false;

            if (node.Value.Equals(value))
            {
                if (node.IsLeaf) // no children
                {
                    if (node.Parent.LeftChild == node)
                        node.Parent.LeftChild = null;
                    else
                        node.Parent.RightChild = null;

                    node.Parent = null;
                }
                else if (node.CheckLeftChild && node.CheckRightChild)   // 2 children
                {
                    // Tìm successor node
                    AVLTreeNode<T> replacementNode = node.RightChild;

                    while (replacementNode.CheckLeftChild)
                    {
                        replacementNode = replacementNode.LeftChild;
                    }
                    node.Value = replacementNode.Value;

                    Remove(replacementNode, replacementNode.Value);
                }
                else    // one child
                {
                    AVLTreeNode<T> subNode;

                    if (node.CheckLeftChild)
                        subNode = node.LeftChild;
                    else
                        subNode = node.RightChild;

                    if (Root == (subNode))
                        Root = subNode;

                    subNode.Parent = node.Parent;

                    if (node.Parent.LeftChild == node)
                        node.Parent.LeftChild = subNode;
                    else
                        node.Parent.RightChild = subNode;
                }

                return true;
            }
            else
            {
                if (node.Value.CompareTo(value) > 0)
                    return CheckRemove(node.LeftChild, value);
                else
                    return CheckRemove(node.RightChild, value);
            }
        }


        #endregion
        public virtual AVLTreeNode<T> Remove(T value)//Ham xoa nodee
        {
            return Remove(Root, value);
        }
        private AVLTreeNode<T> Remove(AVLTreeNode<T> node, T value)
        {
            //Neu cay rong
            if (node == null)
                return null ;

            else
            {
                AVLTreeNode<T> parent = new AVLTreeNode<T>(value);
                if (node.Value.CompareTo(value) > 0)//Truong hop gia tri can xoa nho hon node dang xet->tim tren cay con trai
                {
                    node.LeftChild = Remove(node.LeftChild, value);
                    if (balance_factor(node) == -2)//Cay lech phai
                    {
                        if (balance_factor(node.RightChild) <= 0)
                        {
                            node = RotateRR(node);
                        }
                        else
                        {
                            node = RotateRL(node);
                        }
                    }
                }
                else if (node.Value.CompareTo(value) < 0)//Truong hop gia tri can xoa lon hon node dang xet->tim tren cayy con phai
                {
                    node.RightChild = Remove(node.RightChild, value);
                    if (balance_factor(node) == 2)//Cay lech trai
                    {
                        if (balance_factor(node.LeftChild) >= 0)
                        {
                            node = RotateLL(node);
                        }
                        else
                        {
                            node = RotateLR(node);
                        }
                    }
                }
                ///Neu tim duoc nodee can xet
                else
                {
                    if (node.RightChild != null)
                    {
                        //delete its inorder successor
                        parent = node.RightChild;
                        while (parent.LeftChild != null)
                        {
                            parent = parent.LeftChild;
                        }
                        node.Value = parent.Value;//Gan lai gia tri node hien hanh
                        node.RightChild = Remove(node.RightChild, parent.Value);
                        if (balance_factor(node) == 2)//Tai can bang cay
                        {
                            if (balance_factor(node.LeftChild) >= 0)
                            {
                                node = RotateLL(node);
                            }
                            else { node = RotateLR(node); }
                        }
                    }
                    else
                    {   //if node.left != null
                        return node.LeftChild;
                    }
                }
            }
            return node;
        }
       
    
    }
}

