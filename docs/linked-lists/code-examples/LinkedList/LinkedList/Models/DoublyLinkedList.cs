using System.ComponentModel;

namespace LinkedList.Models
{
    /// <summary>
    /// LinkedList - bu quti
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
        public int CurrentSize { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            CurrentSize = 0;
        }

        public void AddFront(DoublyLinkedListNode? node)
        {
            if (!IsValid(node))
                return;

            node.Next = Head;
            node.Previous = null;
            Head = node;
            CurrentSize++;

            return;
        }

        public void RemoveFront()
        {
            if (!IsValid(Head))
                return;

            Head = Head.Next;
            Head.Previous = null;
            CurrentSize--;

            return;
        }

        public void AddBack(DoublyLinkedListNode? node)
        {
            if(!IsValid(node))
                return;

            if(Head == null)
            {
                Head = node;
                CurrentSize++;
                return;
            }

            DoublyLinkedListNode curr = Head;
            while(curr.Next != null)
            {
                curr = curr.Next;
            }

            curr.Next = node;
            node.Next = null;
            CurrentSize++;

            return;
        }

        public void RemoveBack()
        {
            if(!IsValid(Head))
                return;

            DoublyLinkedListNode curr = Head;

            while(curr.Next != null)
            {
                curr = curr.Next;
            }

            curr = curr.Previous;

            curr.Next = null;
            CurrentSize--;

            return;
        }

        public void AddMiddle(DoublyLinkedListNode node, int index)
        {
            if(!IsValid(node) || index > CurrentSize)
                return;

            if(index == 0)
            {
                AddFront(node);
                return;
            }else if(index == CurrentSize)
            {
                AddBack(node);
                return;
            }

            DoublyLinkedListNode curr = Head;
            int i = 0;

            while(i < index)
            {
                curr = curr.Next;
            }

            DoublyLinkedListNode temp = curr;
            temp = temp.Next;
            curr.Next = node;
            node.Next = temp;
            node.Previous = curr;
            CurrentSize++;

            return;
        }

        public void RemoveMiddle(int index)
        {
            if(!IsValid(Head) || index > CurrentSize)
                return;

            DoublyLinkedListNode curr = Head;
            int i = 0;
            while (i < index)
            {
                curr = curr.Next;
            }

            DoublyLinkedListNode tmp = curr;
            tmp = tmp.Next;
            curr.Next = tmp;
            tmp.Previous = curr;
            CurrentSize--;

            return;
        }

        public static bool IsValid(DoublyLinkedListNode? node)
        {
            if (node is null || node.Value < 0)
                return false;

            return true;
        }
    }
}