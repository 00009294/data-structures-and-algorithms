namespace LinkedList.Models
{
    /// <summary>
    /// LinkedList - bu quti
    /// Head - doim birinchi qutiga qaragan bo'ladi
    /// CircularLinkedListNode - bu bir tomonlama aylana quti, ya'ni ohirgi quti aylanib birinchi qutiga qaragan bo'ladi
    /// Next - hech qachon null bolmaydi 
    /// </summary>
    public class CircularLinkedListNode
    {
        public int Value { get; set; }
        public CircularLinkedListNode Next { get; set; }
        public CircularLinkedListNode(CircularLinkedListNode next, int value = 0)
        {
            Value = value;
            Next = next;
        }
    }
}