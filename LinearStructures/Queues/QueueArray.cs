using System;

namespace LinearStructures.Queues
{
    public class QueueArray
    {
        int n;          // Kuyruk kapasitesi
        int c;          // Kuyruktaki eleman sayısı
        int front;      // Kuyruk başını işaret eden işaretçi
        int rear;      // Kuyruk sonunu işaret eden işaretçi
        string[] list;  //Kuyruk

        public QueueArray(int n)
        {
            this.n = n;
            front = 0;
            rear = 0;
            c = 0;
            list = new string[n];
        }

        // * Kuyruk dolu mu?
        public bool isFull() => (c ==n) ? true : false;

        // * Kuyruk boş mu?
        public bool isEmpty() => (c ==0) ? true : false;

        public void Enqueue(string data)
        {
            if (isFull())
                Console.WriteLine("Kuyruk dolu!");
            else
            {                                            // ! [ ,2,3,4,5,6] => n=5, c=5, rear=5, front=1  => Enqueue() işlemi
                rear = rear % n;                         // ! 5 % 5 = 0
                list[rear] = data;                       // ! list[0] = data
                rear++;                                  // ! rear+1=6
                c++;                                     // ! c+1=6
                Console.WriteLine($"{data}, Kuyruğa eklendi.");
            }
        }

        public string Dequeue()
        {
            if(isEmpty())
            {
                Console.WriteLine("Kuyruk boş!");
                return null;
            }
            else
            {
                string r;                                                   // ! [1,2,3,4,5,6] => n=6, c=6, front=1, rear=6, => Dequeue() işlemi
                Console.WriteLine(list[front] + " Kuyruktan çıkarıldı.");
                r = list[front];                                            // ! r = 1                                            
                list[front] = null;                                         // ! [ ,2,3,4,5,6]
                front = (front +1 ) % n;                                    // ! (1+1) % 6 = 2
                c--;                                                        // ! c-1 = 5
                return r;                                                   //! r
            }
        }

        public string Peek() => list[front];
    }
}