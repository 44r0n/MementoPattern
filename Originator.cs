namespace MementoPattern
{
    public class Originator
    {
        public string State
        {
            get;
            set;
        }

        public Memento CreateMemento() => new Memento(this.State);

        public void SetMemento(Memento memento) => State = memento.State;
        
    }
}