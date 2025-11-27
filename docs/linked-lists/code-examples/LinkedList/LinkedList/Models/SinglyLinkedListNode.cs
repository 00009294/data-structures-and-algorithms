namespace LinkedList.Models
{
    public class SinglyLinkedListNode<T>(T data)
    {
        public T Data { get; set; } = data;
        public SinglyLinkedListNode<T>? Next { get; set; }
    }
}
