using System.Collections;

namespace LinearStructures.Queues
{
    public class QueueArrayList
    {
        private ArrayList list;
        public QueueArrayList()
        {
            list = new ArrayList();
        }

        public void Enqueue(object item) => list.Add(item);

        public object DeQueue()
        {
            if (list.Count > 1)
            {
            var s = list[0];
            list.RemoveAt(0);
            return s;
            }
            else
                return null;
        }

        public object Peek() => list[0];

        public void Clear() => list.Clear();

        public int Count() => list.Count;
    }
}