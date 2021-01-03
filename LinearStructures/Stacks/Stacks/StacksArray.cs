namespace LinearStructures.Stacks
{
    public class Oge
    {
        private string tanim;
        public string Tanim {get => tanim ;set => tanim = value;}
        public Oge(string tanim)
        {
            this.tanim = tanim;
        }
    }

    public class StacksArray
    {
        Oge[] list;
        int top;
        int N;
        public StacksArray(int N)
        {
            this.N = N;
            list = new Oge[N];
            top = -1;
        }

        public Oge Top() => list[top];

        public bool isFull() => top == N-1 ? true: false;
        // {
        //     if (top == N-1)
        //         return true;
        //     else
        //         return false;
        // }

        public bool isEmpty() => top == -1 ? true : false;
        // {
        //     if (top == -1)
        //         return true;
        //     else
        //         return false;
        // }

        public void Add(Oge yeni)
        {
            if (!isFull())
            {
                top++;
                list[top] = yeni;
            }
        }

        public Oge Remove()
        {
            if (!isEmpty())
            {
                top--;
                return list[top+1];
            }
            return null;
        }
    }
}