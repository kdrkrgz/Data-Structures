using System.Collections;
using LinearStructures.Stacks;

namespace LinearStructures.Stacks
{
    public class StacksArrayList
    {
        private int top;
        private ArrayList list;
        private int Count {get;}
        public StacksArrayList()
        {
            list = new ArrayList();
            top = -1;
        }

        public void Push(Oge item)
        {
            list.Add(item);
            top ++;
        }
        public Oge Pop()
        {
            Oge oge = (Oge)list[top];
            list.RemoveAt(top);
            top--;
            return oge;
        }
        public void Clear(){
            list.Clear();
            top = -1;
        }

        public Oge Top() => (Oge)list[top];

        public bool StackEmpty() => list.Count == 0 ? true : false;
    }
}