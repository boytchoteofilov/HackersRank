namespace LinearDataStructures
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T value)
        {
            Value = value;
            Prev = null;
            Next = null;
        }

        public T Value { get; set; }
        public DoublyLinkedListNode<T> Prev { get; internal set; }
        public DoublyLinkedListNode<T> Next { get; internal set; }
    }
}
