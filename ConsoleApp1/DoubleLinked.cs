

namespace ConsoleApp1
{
    public class DoubleLinked
    {
        
        /* DoubleLinked*/
       
        public DoubleLinked Next { get; set; }
        public DoubleLinked Previous { get; set; }

        public void AddAfter(DoubleLinked node)
        {

            if (this.Next != null)
            {
                node.Next = this.Next;
                //  node.Previous = this;
                this.Next.Previous = node;
                //  this.Next = node;
            }

            node.Previous = this;
            this.Next = node;


        }

        public void InsertBefor(DoubleLinked node)
        {
            if (this.Previous != null)
            {
                node.Previous = this.Previous;
                this.Previous.Next = node;

            }
            node.Next = this;
            this.Previous = node;
        }
    }
}
