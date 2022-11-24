class Program
{
    
   
    static void Main()
    {
        //crequeuete queue
        Queue<int> queue = new Queue<int>();
        
        //Input Here!!!
        Console.WriteLine();
        string fruitinput = Console.ReadLine();
        
        
        
        if(fruitinput == "L" || fruitinput == "M" || fruitinput == "S")
        {

            if(fruitinput == "L")
            {
                
                queue.Push(1);
                int value = queue.Pop();
            

                queue.Push(22);
                int value2 = queue.Pop();
                
                
                queue.Push(333);
                int value3 = queue.Pop();

                Console.Write(value);
                Console.Write(value2);
                Console.Write(value3);

                

                Main();

            }
            if(fruitinput == "M"){

                queue.Push(22);
                int value4 = queue.Pop();
                Console.WriteLine(value4);
                Main();

            }
            if(fruitinput == "S")
            {
                 queue.Push(333);
                 int value5 = queue.Pop();
                 Console.WriteLine(value5);
                 Main();
            }

                
            
            
           
        
        }
      

    
    }
   

    
    
}