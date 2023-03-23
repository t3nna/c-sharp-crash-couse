namespace cSharpCourse.Collections;

public  static class Queue
{
    public static void doQueue()
    {
        Queue<string> patients = new Queue<string>();
        
        patients.Enqueue("Ivan");
        patients.Enqueue("Stas");
        patients.Enqueue("Karina");
        patients.Enqueue("Igor");

        Console.WriteLine("Patient is entering " + patients.Dequeue()); // представление, удаление 
        Console.WriteLine("Next patient in queue " + patients.Peek()); // представление след елемента в очереди 

        foreach (var patient in patients)
        {
            Console.WriteLine(patient); 
        }

    }
    
}