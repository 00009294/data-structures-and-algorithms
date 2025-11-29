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
        /// Bog'langan qutilarni ohiriga qoshish
        /// </summary>
        /// <param name="newNode"> yangi quti </param>
        public void AddBack(LinkedList newNode)
        {
            if(!IsValid(newNode))
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
        }

        /// <summary>
        /// Tartib raqam boyicha bog'langan qutilarga yangi quti qo'shish
        /// </summary>
        /// <param name="newNode"> yangi quti </param>
        /// <param name="index"> tartib raqam </param>
        public void AddMiddle(LinkedList newNode, int index)
        {
            if(!IsValid(newNode) || index > CurrentSize) 
                return;

            if(index == 0 || Head is null)
            {
                AddFront(newNode);
                return;
            }
            else if(index == CurrentSize-1)
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