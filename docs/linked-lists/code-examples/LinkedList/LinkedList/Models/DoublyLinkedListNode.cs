namespace LinkedList.Models
{
    public class DoublyLinkedListNode<T>(T data)
    {
        public T Data { get; set; }
        public CircularLinkedListNode<T>? Next { get; set; }
        public CircularLinkedListNode<T>? Previous { get; set; }

    }
}
