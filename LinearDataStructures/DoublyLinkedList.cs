namespace LinearDataStructures
{
    public class DoublyLinkedList<T>
    {


        public DoublyLinkedList()
        {
            First = null;
            Last = null;
            Size = 0;
        }

        internal DoublyLinkedListNode<T> First { get; set; }
        internal DoublyLinkedListNode<T> Last { get; set; }

        public int Size { get; private set; }

        // Add one element at the beginning
        public void PushFront(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);

            // If list is empty
            if (First == null)
            {
                First = newNode;
                Last = newNode;
                Size++;
                return;
            }

            newNode.Next = First;
            First.Prev = newNode;
            First = newNode;

            Size++;
        }

        // Add one element at the end
        public void PushBack(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);

            if (Last == null)
            {
                Last = newNode;
                First = newNode;
                Size++;

                return;
            }

            newNode.Prev = Last;
            Last.Next = newNode;
            Last = newNode;

            Size++;
        }

        // Reusing InsertAfter method to add element at the end of the list.
        public void PushBackRefactored(T value)
        {
            if (Last == null)
            {
                Size++;
                Last = First = new DoublyLinkedListNode<T>(value);
                return;
            }
            InsertAfter(Last, value);
        }

        public void InsertAfter(DoublyLinkedListNode<T> node, T value)
        {
            Size++;
            var newNode = new DoublyLinkedListNode<T>(value);

            newNode.Prev = node;
            newNode.Next = node.Next;

            newNode.Prev.Next = newNode;
            if (newNode.Next != null)
            {

                newNode.Next.Prev = newNode;
            }
            else
            {
                Last = newNode;
            }
        }

        public void InsertBefore(DoublyLinkedListNode<T> node, T value)
        {
            Size++;
            var newNode = new DoublyLinkedListNode<T>(value);

            newNode.Next = node;
            newNode.Prev = node.Prev;

            newNode.Next.Prev = newNode;
            if (newNode.Prev != null)
            {

                newNode.Prev.Next = newNode;
            }
            else
            {
                First = newNode;
            }
        }

        // Remove one element from the front
        public void PopFront()
        {
            Remove(First);
        }

        // Remove one element at the end
        public void PopBack()
        {
            Remove(Last);
        }


        // Remove selected node
        public void Remove(DoublyLinkedListNode<T> node)
        {
            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }
            else
            {
                First = node.Next;
            }

            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }
            else
            {
                Last = node.Prev;
            }

            Size--;
        }
    }
}
