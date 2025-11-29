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
        /// <summary>
        /// LinkedList ni data strukturasi
        /// </summary>
        public class LinkedList
        {
            public int Value { get; set; }
            public LinkedList? Next { get; set; }

            public LinkedList(int value = 0, LinkedList? next = null)
            {
                Value = value;
                Next = next;
            }
        }

        /// <summary>
        /// Qutilarni bo'shi
        /// </summary>
        private LinkedList? Head { get; set; }

        /// <summary>
        /// Qutilarni jami soni
        /// </summary>
        private int CurrentSize { get; set; }

        public SinglyLinkedListNode()
        {
            Head = null;
            CurrentSize = 0;
        }

        /// <summary>
        /// Bog'langan qutilarni boshiga qoshish
        /// </summary>
        /// <param name="newNode"> yangi quti </param>
        public void AddFront(LinkedList newNode)
        {
            if (!IsValid(newNode))
                return;

            newNode.Next = Head;
            Head = newNode;

            CurrentSize++;
        }

        /// <summary>
        /// Boshidan olib tashlash
        /// </summary>
        public void RemoveFront()
        {
            if (!IsValid(Head))
                return;

            Head = Head.Next;
            CurrentSize--;

            return;
        }

        /// <summary>
        /// Bog'langan qutilarni ohiriga qoshish
        /// </summary>
        /// <param name="newNode"> yangi quti </param>
        public void AddBack(LinkedList newNode)
        {
            if (!IsValid(newNode))
                return;

            if (!IsValid(Head))
            {
                Head = newNode;
                CurrentSize++;
            }

            LinkedList curr = Head!;
            do
            {
                curr = curr.Next!;
            }
            while (curr.Next != null);

            curr.Next = newNode;
            CurrentSize++;

            return;
        }

        /// <summary>
        /// Ohiridan olib tashlash
        /// </summary>
        public void RemoveBack()
        {
            if (!IsValid(Head))
                return;

            LinkedList curr = Head;
            LinkedList prev = null;

            while (curr.Next != null)
            {
                prev = curr;
                curr = curr.Next;
            }

            prev.Next = null;
            CurrentSize--;

            return;
        }

        /// <summary>
        /// Tartib raqam boyicha bog'langan qutilarga yangi quti qo'shish
        /// </summary>
        /// <param name="newNode"> yangi quti </param>
        /// <param name="index"> tartib raqam </param>
        public void AddMiddle(LinkedList newNode, int index)
        {
            if (!IsValid(newNode) || index > CurrentSize)
                return;

            if (index == 0 || Head is null)
            {
                AddFront(newNode);
                return;
            }
            else if (index == CurrentSize - 1)
            {
                AddBack(newNode);
                return;
            }

            LinkedList curr = Head;
            int i = 0;
            while (index - 1 != i && curr != null)
            {
                curr = curr.Next!;
                i++;
            }

            if (!IsValid(curr))
                return;

            LinkedList next = curr.Next!;
            curr.Next = newNode;
            newNode.Next = next;
            CurrentSize++;

            return;
        }

        /// <summary>
        /// Tartib raqam boyicha bog'langan qutilardan bittasini olib tashlash
        /// </summary>
        /// <param name="node"></param>
        /// <param name="index"></param>
        public void RemoveMiddle(LinkedList node, int index)
        {
            if (!IsValid(node) || index < 0 || index > CurrentSize)
                return;

            LinkedList prev = null;
            LinkedList curr = Head;
            int i = 0;

            if (i == index)
            {
                RemoveFront();
            }

            while (i < index)
            {
                prev = curr;
                curr = curr.Next;
                i++;
            }

            if (!IsValid(curr) || curr.Next == null)
            {
                RemoveBack();
            }

            prev.Next = curr.Next;
            CurrentSize--;

            return;
        }

        /// <summary>
        /// int[] toplamni Linked List ga ogirib beradi
        /// </summary>
        /// <param name="array"></param>
        /// <returns> quti </returns>
        public static LinkedList ConvertArrayToLinkedList(int[] array)
        {
            if (array.Length == 0)
                return new LinkedList();

            LinkedList head = new LinkedList(array[0]);
            LinkedList curr = head;

            for (int i = 1; i < array.Length; i++)
            {
                curr.Next = new LinkedList(array[i]);
                curr = curr.Next;
            }

            return head;
        }

        /// <summary>
        /// TEKSHIRUV: Quti bosh yoki Value 0 dan kichik bo'lish mumkin emas
        /// </summary>
        /// <param name="node"> oddiy quti </param>
        public static bool IsValid(LinkedList? node)
        {
            if (node is null || node.Value < 0)
                return false;

            return true;
        }
    }
}