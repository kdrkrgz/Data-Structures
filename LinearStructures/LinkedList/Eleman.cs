namespace LinearStructures.LinkedList
{
    public class Eleman
    {
        public int icerik;
        public Eleman ileri;

        public Eleman(int icerik)
        {
            this.icerik = icerik;
            ileri = null;
        }
    }
}