using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "World";
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "Hello";
            Console.WriteLine(originator.State);
            originator.SetMemento(caretaker.Memento);
            Console.WriteLine(originator.State);
        }
    }
}
