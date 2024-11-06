using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {

        class Stack
        {
            private List<StackFrame> _theStack = new List<StackFrame>();

            public void Push(StackFrame stackFrame)
            {
                _theStack.Add(stackFrame);
                Console.WriteLine("StackFrame {0} loaded!", _theStack[_theStack.Count - 1].Id);
            } 

            public void Pop()
            {

                if (_theStack.Count > 0)
                {
                    int id = _theStack[_theStack.Count - 1].Id;
                    _theStack.RemoveAt(_theStack.Count - 1);
                    Console.WriteLine("StackFrame {0} is popped!", id);
                }else {
                    Console.WriteLine("Stack is empty");
                }
            }
        }

        class StackFrame {

            public int Id;
            public StackFrame(int id) { Id = id; }
        }
        static void Main(string[] args) { 
            Stack stack = new Stack();
            StackFrame[] stackFrameArr= { new StackFrame(1), new StackFrame(2), new StackFrame(3) };
            foreach(StackFrame stackFrame in stackFrameArr)
            {
                stack.Push(stackFrame);
            }
            foreach (StackFrame stackFrame in stackFrameArr)
            {
                stack.Pop();
            }
            Console.Read();
        }
    }
}
