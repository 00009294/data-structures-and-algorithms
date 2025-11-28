namespace LinkedList.Models
{
    /// <summary>
    /// LinkedList - bu quti
    /// Head - doim birinchi qutiga qaragan bo'ladi
    /// DoublyCircularLinkedListNode - bu ikki tomonlama + aylana quti, ya'ni ozidan oldingi va ozidan keyingi quti bilan aloqasi bor 
    /// va ohirgi quti birinchi qutiga qaragan bo'ladi
    /// Previous va Next qiymati hech qachon null bolmaydi
    /// </summary>
    public class DoublyCircularLinkedListNode
    {
        public int Value { get; set; }
        public DoublyCircularLinkedListNode Previous { get; set; }
        public DoublyCircularLinkedListNode Next { get; set; }
        public DoublyCircularLinkedListNode(DoublyCircularLinkedListNode previous, DoublyCircularLinkedListNode next, int value = 0)
        {
            Value = value;
            Previous = previous;
            Next = next;
        }
    }
}