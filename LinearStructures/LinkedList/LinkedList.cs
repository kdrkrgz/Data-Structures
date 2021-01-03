namespace LinearStructures.LinkedList
{
    public class LinkedList
    {
        public Eleman bas;
        public Eleman son; 
        public LinkedList()
        {
            bas = null;
            son = null;
        }

        public void listeBasinaElemanEkle(Eleman yeni)
        {
            if (son == null)
            {
                son = yeni;
            }
            yeni.ileri = bas;
            bas = yeni;
        }
        public void listeyeEkle(Eleman yeni)
        {
            if (bas == null)
                bas = yeni;
            else
                son.ileri = yeni;
            son = yeni;
        }
        public void listeArasınaElemanEkle(Eleman yeni, Eleman once)
        {
            yeni.ileri = once.ileri;
            once.ileri = yeni;
        }

        // * Bağlı listede elemanı arar bulursa elemanı, bulamazsa null döner
        public Eleman listedeAra(int deger)
        {
            Eleman gecici;
            gecici = bas;
            while (gecici != null)      // ! sondaki elemanın ileri değeri null olacağından gecici null olmadığı sürece aramaya devam edecektir.
            {
                if (gecici.icerik == deger)
                {
                    return gecici;
                }
                gecici = gecici.ileri;
            }
            return null;
        }

        public Eleman ElemanGetir(int index)
        {
            Eleman gecici = bas;
            int i = 0;
            while (gecici != null && i < index)
            {
                i++;
                gecici = gecici.ileri;
            }
            return gecici;
        }
        
        public Eleman ListeBasindanSil()
        {

            bas = bas.ileri;
            if (bas == null)
                son = null;
            return bas;
        }

        public Eleman ListeSonundanSil()
        {
            Eleman gecici, once;
            gecici = bas;
            once = null;
            while (gecici != son)
            {
                once = gecici;
                gecici = gecici.ileri;
            }
            if (once == null)
                bas = null;
            else
                once.ileri = null;
                
            son = once;
            return son;
        }

        public Eleman ListedenSil(Eleman eleman)
        {
            Eleman gecici, onceki;
            gecici = bas;
            onceki = null;
            while (gecici != eleman)
            {
                onceki = gecici;
                gecici = gecici.ileri;
            }
            onceki.ileri = eleman.ileri;

            return onceki.ileri;
        }

        public int Count()
        {
            int count = 0;
            Eleman gecici = bas;
            while(gecici != null)
            {
                gecici = gecici.ileri;
                count++;
            } 
            return count;
        }
    }
}