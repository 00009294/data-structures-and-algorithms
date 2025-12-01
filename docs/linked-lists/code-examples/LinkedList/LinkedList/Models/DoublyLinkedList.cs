namespace LinkedList.Models
{
    /// <summary>
    /// LinkedList - bu quti edi, endi buni node deb qabul qilamiz
    /// Head - doim birinchi qutiga qaragan bo'ladi
    /// DoublyLinkedListNode - bu ikki tomonlama quti, ya'ni ozidan oldingi va ozidan keyingi quti bilan aloqasi bor
    /// Tartib boyicha birinchi qutining Previous qiymati null bo'ladi sababi, ushbu qutiga hech qanday quti qaramagan bo'ladi
    /// Tartib boyicha ohirgi qutining Next qiymati null bo'ladi sababi, ushbu qutidan keyingi quti yoq
    /// </summary>
    public class DoublyLinkedList
    {
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

        public DoublyLinkedListNode? Head { get; set; }
        public DoublyLinkedListNode? Tail { get; set; }
        public int CurrentSize { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            CurrentSize = 0;
        }

        /// <summary>
        /// Boshidan bitta node qoshish
        /// </summary>
        /// <param name="node"> yangi node </param>
        public void AddFront(DoublyLinkedListNode? node)
        {
            if (!IsValid(node))
                return;

            node.Previous = null;
            node.Next = Head;

            Head.Previous = node;
            Head = node;

            CurrentSize++;

            return;
        }

        /// <summary>
        /// Ohiridan bitta nodeni olib tashlash
        /// </summary>
        public void RemoveFront()
        {
            if (!IsValid(Head))
                return;

            DoublyLinkedListNode oldNode = Head;

            Head = Head.Next;
            Head.Previous = null;

            oldNode.Next = null;
            oldNode.Previous = null;

            CurrentSize--;

            return;
        }

        /// <summary>
        /// Ohiridan bitta node qoshish
        /// </summary>
        /// <param name="node"></param>
        public void AddBack(DoublyLinkedListNode? node)
        {
            if (!IsValid(node))
                return;

            if (Head == null)
            {
                Head = node;

                CurrentSize++;
                return;
            }

            DoublyLinkedListNode curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }

            curr.Next = node;
            node.Previous = curr;

            Tail = node;
            CurrentSize++;

            return;
        }

        /// <summary>
        /// Ohiridan bitta node olib tashlash
        /// </summary>
        public void RemoveBack()
        {
            if (!IsValid(Head))
                return;

            DoublyLinkedListNode curr = Head;

            while (curr.Next != null)
            {
                curr = curr.Next;
            }

            DoublyLinkedListNode prev = curr.Previous;
            prev.Next = null;

            curr.Previous = null;
            Tail = prev;
            CurrentSize--;

            return;
        }

        /// <summary>
        /// O'rtasidan bitta node qo'shish
        /// </summary>
        /// <param name="node"></param>
        /// <param name="index"></param>
        public void AddMiddle(DoublyLinkedListNode node, int index)
        {
            if (!IsValid(node) || index < 0 || index > CurrentSize)
                return;

            if (index == 0)
            {
                AddFront(node);
                return;
            }
            else if (index == CurrentSize)
            {
                AddBack(node);
                return;
            }

            DoublyLinkedListNode curr = Head;
            int i = 0;

            while (i < index - 1)
            {
                curr = curr.Next;
                i++;
            }

            DoublyLinkedListNode nextNode = curr.Next;

            nextNode = nextNode.Next;

            curr.Next = node;
            node.Previous = curr;

            node.Next = nextNode;
            nextNode.Previous = node;

            CurrentSize++;

            return;
        }

        /// <summary>
        /// O'rtasidan bitta node olib tashlash
        /// </summary>
        /// <param name="index"></param>
        public void RemoveMiddle(int index)
        {
            if (!IsValid(Head) || index >= CurrentSize)
                return;

            if (index == CurrentSize)
            {
                RemoveFront();
                return;
            }

            DoublyLinkedListNode curr = Head;
            int i = 0;

            while (i < index - 1)
            {
                curr = curr.Next;
                i++;
            }

            DoublyLinkedListNode toRemove = curr.Next;

            if (toRemove.Next == null)
            {
                curr.Next = null;
                toRemove.Previous = null;
                CurrentSize--;
                return;
            }

            DoublyLinkedListNode nextNode = toRemove.Next;

            curr.Next = nextNode;
            nextNode.Previous = curr;

            toRemove.Next = null;
            toRemove.Previous = null;

            CurrentSize--;

            return;
        }

        /// <summary>
        /// Node ni tekshirish
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private static bool IsValid(DoublyLinkedListNode? node)
        {
            if (node is null || node.Value < 0)
                return false;

            return true;
        }
    }
}