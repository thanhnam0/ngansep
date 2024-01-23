using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal class Program
    {
        public class Stack
        {
            private int[] data;
            private int top;

            public Stack()
            {
                data = new int[100];
                top = -1;
            }

            public Stack(int size)
            {
                data = new int[size];
                top = -1;
            }

            public bool isEmpty()
            {
                bool kq = false;
                if (top == -1)
                    kq = true;
                return kq;
            }

            public bool isFull()
            {
                bool kq = false;
                if (top == data.Length-1)
                    kq = true;
                return kq;
            }

            public void Push(int x)
            {
                if (isFull())
                {
                    Console.WriteLine("Ngăn xếp đầy");
                }
                else
                {
                    data[++top] = x;
                }
            }

            public int Pop()
            {
                int kq = 0;
                if (isEmpty())
                {
                    Console.WriteLine("Ngăn xếp rỗng");
                }
                else
                {
                    kq = data[top--];
                }
                return kq;
            }
        }


        static void Main(string[] args)
        {
            int n;
            Console.Write("moi nhap co so : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("moi nhap co so can doi: ");
            int x = int.Parse(Console.ReadLine());
            Stack s = new Stack();
            while (n > 0)
            {
                s.Push(n % x);
                n = n / x;
            }

            int value;
            Console.WriteLine($"Bieu dien he so {x} : ");
            while (!s.isEmpty())
            {
                if (x == 16)
                {
                    value = s.Pop();
                    switch (value)
                    {
                        case 10:
                            Console.WriteLine("A");
                            break;
                        case 11:
                            Console.WriteLine("B");
                            break;
                        case 12:
                            Console.WriteLine("C");
                            break;
                        case 13:
                            Console.WriteLine("D");
                            break;
                        case 14:
                            Console.WriteLine("E");
                            break;
                        case 15:
                            Console.WriteLine("F");
                            break;
                        default:
                            Console.WriteLine(value);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("value");
                }
            }
            Console.ReadKey();

        }
    }
}
