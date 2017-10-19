using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    static class StaticBinaryTree
    {
        static private int[] treeArray = new int[4];
        static private int arraySize = 4;
        /// <summary>
        /// Initialize tree nodes with array values
        /// </summary>
        /// <param name="node">Tree node</param>
        /// <param name="valueArr">The array of int to intialize the tree strucuture, -1 indicates null node.</param>
        /// <param name="i">The array index to get value</param>
        public static void InitTree(ref TreeNode node, int[] valueArr, ref int i)
        {
            if (i >= valueArr.Length)
                return;

            // head node
            if (node == null)
            {
                node = new TreeNode(valueArr[i++]);
                if (i >= valueArr.Length)
                    return;
            }
            if (valueArr[i] != -1)
            {
                TreeNode newNodeL = new TreeNode(valueArr[i++]);
                node.left = newNodeL;
            }
            else
                i++;

            if (i >= valueArr.Length)
                return;

            if (valueArr[i] != -1)
            {
                TreeNode newNodeR = new TreeNode(valueArr[i++]);
                node.right = newNodeR;
            }
            else
            {
                i++;
            }

            if (i >= valueArr.Length)
                return;

            InitTree(ref node.left, valueArr, ref i);
            InitTree(ref node.right, valueArr, ref i);
        }

        public static void PrintTree(TreeNode node, bool isHead)
        {
            if (node == null)
            {
                return;
            }
            if (isHead)
                Console.Write(node.val + ", ");
            Console.Write(node.left == null ? "-1, " : (node.left.val.ToString() + ", "));
            Console.Write(node.right == null ? "-1, " : (node.right.val.ToString() + ", "));
            PrintTree(node.left, false);
            PrintTree(node.right, false);
        }

        public static int[] ConvertTreeToArray(TreeNode node)
        {
            int index = 0;
            RecursivelyPeekTree(node, ref index);
            if (index < treeArray.Length - 1)
                Array.Resize(ref treeArray, index);
            return treeArray;
        }

        /// <summary>
        /// Convert a tree to an array, and make sure the order is same.
        /// </summary>
        public static void RecursivelyPeekTree(TreeNode node, ref int index)
        {
            if (node.left != null)
                RecursivelyPeekTree(node.left, ref index);
            treeArray[index++] = node.val;
            if (index == arraySize)
                Array.Resize(ref treeArray, arraySize * 2);
            if (node.right != null)
                RecursivelyPeekTree(node.right, ref index);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }

    /// <summary>
    /// Basic data structure definition
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    /// <summary>
    /// Reverse an integer value by digits, any value in range of int type should be handled
    /// E.g. 123456 -> 654321, -123 -> -321    /// </summary>
    class ReverseInteger : ITest
    {
        public void Execute()
        {
            do
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "x")
                    return;
                int val;
                if (int.TryParse(input, out val))
                    Console.WriteLine(ReverseInt(val));
                else
                    Console.WriteLine("Invlid input!");
            } while (true);
        }


        /// <summary>
        /// </summary>
        /// <param name="val">Input value to be reversed.</param>
        /// <returns></returns>
        public long ReverseInt(int val)
        {
            long result = 0;
            int val1 = Math.Abs(val);
            int sign = val / val1;
            while (val1 > 0)
            {
                int temp = val1 % 10;
                result = result * 10 + temp;
                val1 /= 10;
            }

            return result * sign;
        }
    }

    /// <summary>
    /// 输入一个整数，输出该数二进制表示中1的个数。其中负数用补码表示。
    /// </summary>
    class NumberOfOne
    {
        public void Execute()
        {
            int n = -2147483648;
            n = -1;
            Console.WriteLine("Number of 1 for {0} is: {1}", n, NumberOf1InBinary(n));
        }

        /// <summary>
        /// 负数按补码计算
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumberOf1InBinary(int n)
        {
            int count = 0;
            if (n < 0)
            {
                count++;
                n = n & int.MaxValue;
            }
            while (n != 0)
            {
                if (n % 2  == 1)
                    count++;
                n = n / 2 ;
            }
            
            return count;
        }

        public int NumberOf1InBinary2(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n & (n - 1);
            }
            return count;
        }
    }

    /// <summary>
    /// 输入一个整数数组，实现一个函数来调整该数组中数字的顺序，
    /// 使得所有的奇数位于数组的前半部分，所有的偶数位于位于数组的后半部分，
    /// 并保证奇数和奇数，偶数和偶数之间的相对位置不变。
    /// </summary>
    class SortArray
    {
        public void Execute()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 18, 19};
            arr = new int[] { 2 };
            Console.Write("Before: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            arr = reOrderArray(arr);
            Console.Write("\r\n\r\nAfter: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] reOrderArray(int[] array)
        {
            if (array.Length  <= 1)
                return array;

            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] % 2 == 0 && array[i+1] % 2 == 1)
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            return array;
        }
    }

    /// <summary>
    /// 输入一个链表，反转链表后，输出链表的所有元素。
    /// </summary>
    class ReverseLinkedList
    {
        public void Execute()
        {
            int[] valueArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 18, 1 };
            ListNode pHead = null, curNode = null;
            foreach (var i in valueArray)
            {
                if (curNode == null)
                {
                    pHead = new ListNode(i);
                    curNode = pHead;
                }
                else
                {
                    ListNode n = new ListNode(i);
                    curNode.next = n;
                    curNode = n;
                }
            }
            ListNode reverseHead = ReverseList(pHead);
            while (reverseHead != null)
            {
                Console.Write(reverseHead.val + " ");
                reverseHead = reverseHead.next;
            }
        }

        public ListNode ReverseList(ListNode pHead)
        {
            ListNode last = null, next = null;
            if (pHead == null || pHead.next == null)
                return pHead;

            next = pHead.next;
            while (next != null)
            {
                pHead.next = last;
                last = pHead;
                pHead = next;
                next = next.next;
            }
            pHead.next = last;
            return pHead;
        }
    }

    /// <summary>
    /// 输入两棵二叉树A，B，判断B是不是A的子结构。（ps：约定空树不是任意一个树的子结构）
    /// </summary>
    class BinaryTreeSolution
    {
        int[] arr = null;
        int[] arr2 = null;
        public void Execute()
        {
            // -1 indicates null leave
            arr = new int[] { 8, 8, 7, 9, 2, -1, -1, -1, -1, 4, 7};
            arr2 = new int[] { 8, 9, 2 };
            arr2 = new int[] { 7, 4, 7 };
            TreeNode pRoot1 = null, pRoot2 = null;
            int i = 0;
            StaticBinaryTree.InitTree(ref pRoot1, arr, ref i);
            i = 0;
            StaticBinaryTree.InitTree(ref pRoot2, arr2, ref i);
            //bool result = HasSubtree(pRoot1, pRoot2);
            //Console.WriteLine(result);

            var result = PrintFromTopToBottom(pRoot1);
            foreach (int val in result)
            {
                Console.Write(val + " ");
            }
        }

        public bool HasSubtree(TreeNode pRoot1, TreeNode pRoot2)
        {
            if (pRoot1 == null)
            {
                if (pRoot2 == null)
                    return true;
                return false;
            }
            else
            {
                if (pRoot2 == null)
                    return false;
                else
                {
                    if (pRoot1.val == pRoot2.val && 
                        (IsEqualTree(pRoot1.left, pRoot2.left) && IsEqualTree(pRoot1.right, pRoot2.right)))
                    {
                        return true;
                    }
                    else
                    {
                        return HasSubtree(pRoot1.left, pRoot2) ||
                        HasSubtree(pRoot1.right, pRoot2);
                    }
                }
            }
        }

        /// <summary>
        /// 从上往下打印出二叉树的每个节点，同层节点从左至右打印。
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<int> PrintFromTopToBottom(TreeNode root)
        {
            List<int> resultList = new List<int>();
            List<TreeNode> allNodes = new List<TreeNode>();
            if (root != null)
                allNodes.Add(root);
            int i = 0;
            while (i < allNodes.Count)
            {
                TreeNode curNode = allNodes[i];
                resultList.Add(curNode.val);
                if (curNode.left != null)
                    allNodes.Add(curNode.left);
                if (curNode.right != null)
                    allNodes.Add(curNode.right);
                i++;
            }
            return resultList;
        }

        public bool IsEqualTree(TreeNode pRoot1, TreeNode pRoot2)
        {
            if (pRoot1 == null)
            {
                if (pRoot2 == null)
                    return true;
                return false;
            }
            else
            {
                if (pRoot2 == null)
                    return false;
                else
                {
                    if (pRoot1.val != pRoot2.val)
                        return false;
                    return IsEqualTree(pRoot1.left, pRoot2.left) &&
                        IsEqualTree(pRoot1.right, pRoot2.right);
                }
            }
        }

    }

    /// <summary>
    /// 输入一个矩阵，按照从外向里以顺时针的顺序依次打印出每一个数字。
    /// 例如，如果输入如下矩阵： 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 则依次打印出数字1,2,3,4,8,12,16,15,14,13,9,5,6,7,11,10.
    /// 测试用例: 5x5, 能正确输入中心的数，1x5, 5x1等等
    /// PrintMatrix.png
    /// </summary>
    class PrintMatrix
    {
        public void Execute()
        {
            int[][] matrix = new int[5][] {new int[5] { 1, 2, 3, 4, 5}, 
                                           new int[5] { 6, 7, 8, 9, 10}, 
                                           new int[5] { 11, 12, 13, 14, 15}, 
                                           new int[5] { 16, 17, 18, 19, 20},
                                           new int[5] { 21, 22, 23, 24, 25 }};
            //matrix = new int[5][] { new int[1] { 1 }, new int[1] { 2 }, new int[1] { 3 }, new int[1] { 4 }, new int[1] { 5 } };
            List<int> result = PrintMatrixInAntiClockOrder(matrix);
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }
        public List<int> PrintMatrixInAntiClockOrder(int[][] matrix)
        {
            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;

            List<int> resultList = new List<int>();
            int i = top, j = left;

            do
            {
                for (int x = top, y = left; y <= right; y++)
                {
                    resultList.Add(matrix[x][y]);
                }
                top++;
                for (int x = top, y = right; x <= bottom; x++)
                {
                    resultList.Add(matrix[x][y]);
                }
                right--;
                if (right < left)
                    break;
                for (int x = bottom, y = right; y >= left; y--)
                {
                    resultList.Add(matrix[x][y]);
                }
                bottom--;
                if (bottom < top)
                    break;
                for (int x = bottom, y = left; x >= top; x--)
                {
                    resultList.Add(matrix[x][y]);
                }
                left++;
            } while (left < right || top < bottom);

            return resultList;
        }
    }

    /// <summary>
    /// 定义栈的数据结构，请在该类型中实现一个能够得到栈最小元素的min函数。
    /// </summary>
    class CustStack
    {
        int[] _array;
        int _capacity = 0;
        int _position = -1;

        public void Execute()
        {
            CustStack cs = new CustStack();
            int[] valueArray = new int[] { 10, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 18, -1, 20, 21, 22, 23, -8, -9, 0, 0 };
            foreach (int i in valueArray)
            {
                cs.push(i);
            }
            cs.pop();
            cs.pop();
            Console.WriteLine(cs.min());
        }
        public CustStack()
        {
            _array = new int[4];
            _capacity = 4;
            _position = 0;
        }

        public CustStack(int size)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException();
            Array.Resize(ref _array, size);
            _capacity = size;
        }
        
        public void push(int node)
        {
            if (_position == _capacity)
            {
                Array.Resize(ref _array, _capacity == 0 ? 4 : _capacity * 2);
                _capacity = _array.Length;
            }
            _array[_position++] = node;
        }
        public void pop()
        {
            if (_position < 0 || _capacity == 0)
                throw new InvalidOperationException();
            _position--;
        }
        public int top()
        {
            if (_position < 0 || _capacity == 0)
                throw new InvalidOperationException();
            return _array[_position];
        }
        public int min()
        {
            if (_position < 0 || _capacity == 0)
                throw new InvalidOperationException();
            int result = int.MaxValue;
            for (int i = 0; i < _position; i++)
            {
                if (result > _array[i])
                    result = _array[i];
            }
            return result;
        }
    }

    /// <summary>
    /// 输入两个整数序列，第一个序列表示栈的压入顺序，请判断第二个序列是否为该栈的弹出顺序。
    /// 假设压入栈的所有数字均不相等。例如序列1,2,3,4,5是某栈的压入顺序，
    /// 序列4,5,3,2,1是该压栈序列对应的一个弹出序列，但4,3,5,1,2就不可能是该压栈序列的弹出序列。
    /// （注意：这两个序列的长度是相等的）
    /// </summary>
    class CheckPopOrder : ITest
    {
        public void Execute()
        {
            int[] pushArray = new int[] { 1, 2, 3, 4, 5};//, 6, 7, 8, 
            int[] popArray = new int[] { 4, 5, 3, 2, 2};
            foreach (int i in pushArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in popArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(IsPopOrder(pushArray, popArray));
        }
        public bool IsPopOrder(int[] pushV, int[] popV)
        {
            if (popV.Length == 0)
                return false;

            Stack<int> pushStack = new Stack<int>();
            int j = 0;
            for (int i = 0; i < pushV.Length; i++)
            {
                pushStack.Push(pushV[i]);
                while (j < popV.Length && pushStack.Peek() == popV[j])
                {
                    pushStack.Pop();
                    j++;
                }
            }
            return pushStack.Count == 0;
        }

    }

    /// <summary>
    /// 数组中有一个数字出现的次数超过数组长度的一半，请找出这个数字。
    /// 例如输入一个长度为9的数组{1,2,3,2,2,2,5,4,2}, 
    /// 由于数字2在数组中出现了5次，超过数组长度的一半，因此输出2。如果不存在则输出0。
    /// </summary>
    class MoreThanHalfNum : ITest
    {

        public void Execute()
        {
            int[] arr = new int[] { 8, 8, 7, 9, 2, -1, -1, -1, -1, -1, 7, -1, -1, -7, -1 };
            //arr = new int[] { 1, 2, 3, 2, 2, 2, 5, 4, 2 };
            Console.WriteLine(MoreThanHalfNum_Solution2(arr));
        }
        public int MoreThanHalfNum_Solution1(int[] numbers)
        {
            System.Collections.Generic.Dictionary<int, int> stat = new System.Collections.Generic.Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (stat.ContainsKey(numbers[i]))
                {
                    stat[numbers[i]]++;
                }
                else
                {
                    stat.Add(numbers[i], 1);
                }
            }
            foreach (var k in stat.Keys)
            {
                if (stat[k] > numbers.Length / 2)
                    return k;
            }
            return 0;
        }

        /// <summary>
        /// 采用阵地攻守的思想： 第一个数字作为第一个士兵，守阵地；count = 1； 
        /// 遇到相同元素，count++; 遇到不相同元素，即为敌人，同归于尽,count--；
        /// 当遇到count为0的情况，又以新的[i]值作为守阵地的士兵，继续下去，到最后还留在阵地上的士兵，有可能是主元素。
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int MoreThanHalfNum_Solution2(int[] numbers)
        {
            int battle = 0; // array contains no zero
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (battle == numbers[i])
                    count++;
                else
                {
                    if (battle == 0)
                    {
                        battle = numbers[i];
                        count = 1;
                    }
                    else
                    {
                        if (--count <= 0)
                        {
                            battle = 0;
                            count = 0;
                        }
                    }
                }
            }
            if (count > 0)
            {
                count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == battle)
                        count++;
                }
            }
            if (count * 2 > numbers.Length)
                return battle;
            return 0;
        }
    }

    /// <summary>
    /// 1. 输入n个整数，找出其中最小的K个数。
    /// 例如输入4,5,1,6,2,7,3,8这8个数字，则最小的4个数字是1,2,3,4。
    /// 2. 计算连续子向量的最大和
    /// </summary>
    class GetLeastNumbers : ITest
    {
        public void Execute()
        {
            int[] arr = new int[] { 8, 8, 7, 9, 2, 16, 11, 6, 21, 11, 5, 7, 13, 17, 7, 61 };
            //var result = GetLeastNumbers_Solution(arr, 4);
            //foreach (int i in result)
            //{
            //    Console.Write(i + " ");
            //}

            // test Partition()
            //Console.Write(Partition(arr, 0, arr.Length - 1));

            //FindGreatestSumOfSubArray
            arr = new int[] { -6, -3, -2, -7, 15, 1, -2, 3 };
            Console.Write(FindGreatestSumOfSubArray(arr));
        }
        public List<int> GetLeastNumbers_Solution(int[] input, int k)
        {
            if (k < 1)
                throw new ArgumentOutOfRangeException();

            if (input.Length <= k)
                return input.ToList();

            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = int.MaxValue;
            }

            for (int j = 0; j < input.Length; j++)
            {
                int newInt = input[j];
                for (int m = 0; m < k; m++)
                {
                    if (newInt < result[m])
                    {
                        if (m < k - 1)
                        {
                            int temp = result[m];
                            result[m] = newInt; 
                            newInt = temp;
                        }
                        else
                            result[m] = newInt;
                    }
                }
            }
            return result.ToList();
        }
        public int FindGreatestSumOfSubArray(int[] array)
        {
            int max = int.MinValue;
            int tempSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    if (tempSum <= 0)
                        tempSum = array[i];
                    else
                        tempSum += array[i];
                }
                else // might be all negative values
                {
                    if (array[i] > tempSum)
                        tempSum = array[i];
                    else
                        tempSum += array[i];
                }

                if (tempSum > max)
                    max = tempSum;
            }
            return max;
        }
        /// <summary>
        /// 快速排序的变形
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int Partition(int[] input, int begin, int end)
        {
            int low = begin, high = end;
            int pivot = input[low];
            while (low < high)
            {
                while (low < high && pivot <= input[high])
                    high--;

                input[low] = input[high];
                while (low < high && pivot >= input[low])
                    low++;
                input[high] = input[low];
            }
            input[low] = pivot;
            return low;
        }
    }

    /// <summary>
    /// 对于一个给定的字符序列S，请你把其循环左移K位后的序列输出。
    /// 例如，字符序列S="abcXYZdef",要求输出循环左移3位后的结果，即"XYZdefabc"。
    /// </summary>
    class RotateString : ITest
    {
        public void Execute()
        {
            Console.WriteLine(LeftRotateString("abcdefg", 4));
        }
        public string LeftRotateString(string str, int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            if (string.IsNullOrEmpty(str))
                return str;
            if (n == 0 || n == str.Length)
                return str;
            int len = str.Length;
            if (n > len)
                n = n % len;
            str += str;
            return str.Substring(n, len);
        }
    }


    /// <summary>
    /// Re-write Generic.LinkedList class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkList<T> : IList<T>
    {
        public Node<T> Head { get; set; }

        public LinkList(T[] valueArray)
        {
            if (valueArray.Length == 0)
                return;

            Node<T> lastNode = null, newNode = null;
            for (int i = valueArray.Length - 1; i >= 0; i--)
            {
                newNode = new Node<T>(valueArray[i], lastNode);
                lastNode = newNode;
            }
            Head = lastNode;
        }

        public void Execute()
        {
            LinkList<int> intLinkTable = new LinkList<int>(new int[5] { 1, 2, 3, 4, 5 });
            intLinkTable.Remove(3);
            intLinkTable.Insert(3, 4);
            foreach (var item in intLinkTable)
            {
                Console.WriteLine(item);
            }
        }

        public void Clear()
        {
            Head = null;
        }

        public int IndexOf(T item)
        {
            int index = -1;

            Node<T> current = Head;
            while (current != null)
            {
                index++;
                if (current.Data.Equals(item))
                    return index;
                else
                    current = current.Next;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            int i = 0;
            Node<T> current = Head;
            while (current != null && i < index)
            {
                current = current.Next;
                i++;
            }
            if (i == index)
            {
                Node<T> oldNode = current.Clone();
                current.Data = item;
                current.Next = oldNode;
            }
            else
                throw new IndexOutOfRangeException();

        }

        public void RemoveAt(int index)
        {
            int i = 0;
            Node<T> current = Head;
            while (current != null && i < index)
            {
                current = current.Next;
                i++;
            }
            if (i == index)
            {
                Node<T> nextNode = current.Next;
                current.Data = nextNode.Data;
                current.Next = nextNode.Next;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public T this[int index]
        {
            get
            {
                int i = 0;
                Node<T> current = Head;
                while (current != null && i < index)
                {
                    current = current.Next;
                    i++;
                }
                if (i == index)
                    return current.Data;
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                int i = 0;
                Node<T> current = Head;
                while (current != null && i < index)
                {
                    current = current.Next;
                    i++;
                }
                if (i == index)
                    current.Data = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public void Add(T item)
        {
            Node<T> current = Head;
            while (current != null)
            {
                current = current.Next;
            }
            Node<T> newNode = new Node<T>(item, null);
            current.Next = newNode;
        }

        public bool Contains(T item)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                int count = 0;
                Node<T> current = Head;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    Node<T> nextNode = current.Next.Clone();
                    current.Data = nextNode.Data;
                    current.Next = nextNode.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class Node<T>
    {
        private T data; //数据域 存储数据的对象 
        private Node<T> next; //引用域 指向下一个对象 

        //构造器 
        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }

        //构造器 
        public Node(Node<T> n)
        {
            next = n;
        }

        //构造器 
        public Node(T val)
        {
            data = val;
            next = null;
        }

        //构造器 
        public Node()
        {
            data = default(T);
            next = null;
        }

        //数据域属性 
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        //引用域属性 
        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public Node<T> Clone()
        {
            return new Node<T>(data, next);
        }
    }
    interface ITest
    {
        /// <summary>
        /// Call this method to test the algorithm body
        /// </summary>
        void Execute();
    }
}


