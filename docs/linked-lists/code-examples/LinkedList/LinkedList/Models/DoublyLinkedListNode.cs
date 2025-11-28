namespace LinkedList.Models
{
    /// <summary>
    /// LinkedList - bu quti
    /// Head - doim birinchi qutiga qaragan bo'ladi
    /// DoublyLinkedListNode - bu ikki tomonlama quti, ya'ni ozidan oldingi va ozidan keyingi quti bilan aloqasi bor
    /// Tartib boyicha birinchi qutining Previous qiymati null bo'ladi sababi, ushbu qutiga hech qanday quti qaramagan bo'ladi
    /// Tartib boyicha ohirgi qutining Next qiymati null bo'ladi sababi, ushbu qutidan keyingi quti yoq
    /// </summary>
    public class DoublyLinkedListNode
    {
        public int Value { get; set; }
        public DoublyLinkedListNode? Previous { get; set; }
        public DoublyLinkedListNode? Next { get; set; }
        public DoublyLinkedListNode(int value = 0, DoublyLinkedListNode? previous = null, DoublyLinkedListNode? next = null)
        {
            Value = value;
            Previous = previous;
            Next = next;
        }
    }
}