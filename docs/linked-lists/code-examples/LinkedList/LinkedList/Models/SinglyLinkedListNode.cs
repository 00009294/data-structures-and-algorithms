namespace LinkedList.Models
{
    /// <summary>
    /// LinkedList - bu quti
    /// Head - doim birinchi qutiga qaragan bo'ladi
    /// SinglyLinkedList - bu bir tomonlama quti, ya'ni faqat ozidan keyingi quti bilan aloqasi bor(reference orqali)
    /// Ohirgi qutini keyingi quti bilan aloqasi bo'lmaydi, sababi keyingi qutini ozi yoq, shuning uchun keyingi quti null bo'ladi
    /// </summary>
    public class SinglyLinkedListNode
    {
        public int Value { get; set; }
        public SinglyLinkedListNode? Next { get; set; }

        public SinglyLinkedListNode(int value = 0, SinglyLinkedListNode? next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
