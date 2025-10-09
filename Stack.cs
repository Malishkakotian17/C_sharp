using System;

class Stack
{
    int[] stack = new int[3];
    int top = -1;

    public void push(int x)
    {
        if (top < stack.Length - 1)
            stack[++top] = x;
    }

    public int pop()
    {
        if (top >= 0)
            return stack[top--];
        return -1;
    }
}

class program
{
    static void Main()
    {
        Stack S = new Stack();
        S.push(10);
        S.push(20);
        Console.WriteLine(S.pop());
        Console.WriteLine(S.pop());
    }
}
