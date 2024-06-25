 class Stack
{
    private int[] stack;
    private int top;
    //privte int bottom;
    private int max;
    public Stack(int size)
    {
        max = size;
        top = -1;
        stack = new int[size];
    }

    public void push(int item)
    {
        if(top == max- 1)
        {
            Console.WriteLine("Stack is full");
        }else
        {
            stack[++top] = item;
        }
    }

    public int? pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Empty");
            return null;
        }
        else
        {
            int item = stack[top];
            popDisplay();
            top--;
            return item;
        }
    }

    public void popDisplay()
    {
        
        if (top == -1)
        {
            return;
        }
        Console.WriteLine($"Deleted stack element is {stack[top]}");
    }
    public void Display()
    {
        if(top == -1)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Your stack is : ");
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
        
        
    }
}

class StackArray
{
    public static void Main()
    {
        Console.WriteLine("Enter your stack size");
        int size = Convert.ToInt32(Console.ReadLine());
        Stack stack = new Stack(size);
        stack.push(1);
        stack.push(15);
        stack.push(07);
        stack.push(34);
        stack.push(54);
        stack.push(17);
        stack.Display();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.Display();
    }
}