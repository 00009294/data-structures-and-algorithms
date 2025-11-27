namespace LinkedList.Models
{
    public class CircularLinkedListNode<T>(T data)
    {
        public T Data { get; set; }
        public CircularLinkedListNode<T>? Next { get; set; }
    }
}
