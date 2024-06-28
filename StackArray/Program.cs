class Stack
{
    private int[] stack;
    private int top;
    
    private int max;
    public Stack(int size)
    {
        max = size;
        top = -1;
        stack = new int[size];
    }

    public void push(int item)
    {
        if (top == max - 1)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {
            stack[++top] = item;
        }
    }

    public void pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Empty Stack");
            return;
        }
        else
        {
            int item = stack[top];
            popDisplay();
            top--;

        }
    }

    public void popDisplay()
    {
        Console.WriteLine($"Deleted stack element is {stack[top]}");
    }
    public void Display()
    {
        if (top == -1)
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


class StackNewApproach
{
    private int[] stack;
    private int top;
    private bool Full;
    private int max;
    public StackNewApproach(int size)
    {
        max = size;
        top = 0;
        stack = new int[size];
        Full = false;
    }

    public void push(int item)
    {
        stack[top] = item;
        top = increment(top);
        if (top == 0) Full = true;
    }

    public int pop()
    {
        if (top == 0 && !Full) throw new Exception("stack empty");
        
        if(Full) Full = false;
        top = increment(top);
        return stack[top]; 
    }

    private int increment(int topValue)
    {
        return (++topValue % max);
    }

    


         
    
}

class StackArray
{
    public static void Main()
    {
        //Console.WriteLine("Enter your stack size");
        //int size = Convert.ToInt32(Console.ReadLine());
        int item = 0;
        StackNewApproach stack = new StackNewApproach(2);
        stack.push(1);
        //stack.push(15);
        //stack.push(07);
        //stack.push(34);
        item = stack.pop();
        stack.pop();
        //stack.pop();
        stack.push(35);
        stack.pop();
        stack.pop();
        stack.push(36);
        stack.push(37);
        
    }
}