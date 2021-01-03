using System;
using System.Collections;
using System.Collections.Generic;
using LinearStructures.LinkedList;
using LinearStructures.Queues;
using LinearStructures.Stacks;

namespace LinearStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Struct
            List<Personel> personelListesi = new List<Personel>{
                new Personel("Hale", "Dağlı", true, 5000),
                new Personel("Aka", "Akurima", false, 4000),
                new Personel("john", "Doe", true, 7500)
            };
            
            personelListesi.ForEach(p => Console.WriteLine(p.ToString()));
            Console.WriteLine();
            personelListesi.ForEach(p => Console.WriteLine(p.BasHarfler()));

            #endregion

            #region Array
            var personelListesiArray = new Personel[] {
                new Personel("Kadir", "Karagöz"),
                new Personel("John", "Doe", true, 8000),
                new Personel("Can","Temel", true, 9000),
                new Personel("Gül", "Çiçek", false, 7000)
            };

            foreach (var p in personelListesiArray){
                Console.WriteLine(p.ToString());
            }
                
            Console.ReadKey();
            #endregion
            
            #region ArrayList
            var personelListesiArrayList = new ArrayList {
                new Personel("Kadir", "Karagöz"),
                new Personel("John", "Doe", true, 8000)
            };
            personelListesiArrayList.Add(new Personel("Gül", "Çiçek", false, 7000));
            personelListesiArrayList.Remove(0);

            foreach (var p in personelListesiArray)
                Console.WriteLine(p.ToString());
                
            Console.ReadKey();
            #endregion

            #region StacksArray
            
            LinearStructures.Stacks.StacksArray gorevListesi = new LinearStructures.Stacks.StacksArray(10); // 10 kapasiteli bir yığın oluştur.
            gorevListesi.Add(new Oge("Kitap Oku."));                         // Kitap okuma görevi
            gorevListesi.Add(new Oge("Soru Çöz."));
            gorevListesi.Add(new Oge("Kod Yaz."));
            gorevListesi.Add(new Oge("Kod İncele."));

            Oge s = gorevListesi.Remove();                  // son eklenen elemanı kaldır. (Kod İncele.)
            Console.WriteLine($"{s.Tanim} tamamlandı."); 

            s = gorevListesi.Remove();                      // son eklenen elemanı kaldır (Kod Yaz.)
            Console.WriteLine($"{s.Tanim} tamamlandı.");


            Console.WriteLine($"{gorevListesi.Top().Tanim} şimdi yapılacak.");          // son eklenen elemanı yazdır.

            s = gorevListesi.Remove();                      // son eklenen elemanı kaldır (Soru Çöz.)
            Console.WriteLine($"{s.Tanim} tamamlandı.");

            Console.WriteLine("Tüm görevler yapıldımı ? {0}", gorevListesi.isEmpty() ? "Evet" : "Hayır");

            s = gorevListesi.Remove();                      // son eklenen elemanı kaldır (Kitap Oku.)
            Console.WriteLine($"{s.Tanim} tamamlandı.");

            Console.WriteLine("Yapılacak bir şey kaldı mı? {0}", gorevListesi.isFull() ? "Evet" : "Hayır");

            Console.ReadKey();
            #endregion

            #region StacksArrayList
            Console.WriteLine("############### Stacks with ArrayList ################");
            StacksArrayList gorevListesi2 = new StacksArrayList();
            gorevListesi2.Push(new Oge("Kitap Oku."));
            gorevListesi2.Push(new Oge("Kod Yaz."));
            gorevListesi2.Push(new Oge("Kod Oku."));
            gorevListesi2.Push(new Oge("Veri Yapılarına Çalış."));

            Oge s2 = gorevListesi2.Pop();
            Console.WriteLine($"{s2.Tanim} tamamlandı.");

            s2 = gorevListesi2.Pop();
            Console.WriteLine($"{s2.Tanim} tamamlandı.");

            Console.WriteLine("Görevler Tamamlandı mı? {0}", gorevListesi2.StackEmpty() ? "Evet" : "Hayır");

            s2 = gorevListesi2.Pop();
            Console.WriteLine($"{s2.Tanim} tamamlandı.");

            gorevListesi2.Clear();

            Console.WriteLine("Tüm Görevler Yapıldı mı? {0}", gorevListesi2.StackEmpty() ? "Evet" : "Hayır");

            Console.ReadKey();

            #endregion

            #region Stack_C#
            Console.WriteLine("############# C#'ta Stack Yapısı ######################");
            Stack<Oge> gorevListesi3 = new Stack<Oge>();
            gorevListesi3.Push(new Oge("Kitap Oku."));
            gorevListesi3.Push(new Oge("Kod Yaz."));
            gorevListesi3.Push(new Oge("Kod Oku."));
            gorevListesi3.Push(new Oge("Veri Yapılarına Çalış."));

            Oge s3 = gorevListesi3.Pop();
            Console.WriteLine($"{s3.Tanim} tamamlandı.");

            s3 = gorevListesi3.Pop();
            Console.WriteLine($"{s3.Tanim} Tamamlandı.");

            Console.WriteLine("Görevler Tamamlandı mı? {0}", gorevListesi3.Count == 0 ? "Evet" : "Hayır");

            Console.WriteLine("Şimdi Yapılacak Görev: {0}", gorevListesi3.Peek().Tanim);

            s3 = gorevListesi3.Pop();
            Console.WriteLine($"{s3.Tanim} tamamlandı.");

            gorevListesi3.Clear();

            Console.WriteLine("Tüm Görevler Yapıldı mı? {0}", gorevListesi3.Count == 0 ? "Evet" : "Hayır");

            Console.ReadKey();

            #endregion

            #region Queue
            Console.WriteLine("############# Array ile Queue Kullanımı ######################");
            QueueArray yap = new QueueArray(3);
            yap.Enqueue("A");
            yap.Enqueue("B");
            yap.Enqueue("C");
            yap.Enqueue("D");
            yap.Enqueue("E");
            yap.Enqueue("F");

            yap.Dequeue();
            yap.Dequeue();
            yap.Dequeue();

            yap.Enqueue("X");
            yap.Enqueue("Y");

            yap.Dequeue();

            yap.Enqueue("Z");

            for (int i = 0; i < 5; i++)
                yap.Enqueue(i.ToString());

            for(int i = 0; i < 5; i++)
                yap.Dequeue();

            Console.ReadKey();
            #endregion
            
            #region QueueArrayList
            Console.WriteLine("############# ArrayList ile Queue Kullanımı ######################");
            QueueArrayList yap2 = new QueueArrayList();
            yap2.Enqueue("A");
            yap2.Enqueue("B");
            yap2.Enqueue("C");
            yap2.Enqueue("D");
            

            Console.WriteLine(yap2.DeQueue());
            Console.WriteLine(yap2.DeQueue());
            Console.WriteLine(yap2.DeQueue());

            yap2.Enqueue("X");
            yap2.Enqueue("Y");

            Console.WriteLine(yap2.DeQueue());
            Console.WriteLine(yap2.DeQueue());
            Console.WriteLine(yap2.DeQueue());
            Console.WriteLine(yap2.DeQueue());
            Console.WriteLine(yap2.DeQueue());

            Console.ReadKey();
           
            #endregion
            
            #region Queue_C#
            Console.WriteLine("############# C#'ta Queue Yapısı ######################");

            Queue<int> kuyruk = new Queue<int>();
            kuyruk.Enqueue(1);
            kuyruk.Enqueue(2);
            kuyruk.Enqueue(3);
            kuyruk.Enqueue(4);

            Console.WriteLine(kuyruk.Dequeue());
            Console.WriteLine(kuyruk.Dequeue());
            Console.WriteLine(kuyruk.Dequeue());
            Console.WriteLine(kuyruk.Peek());
            Console.WriteLine(kuyruk.Count);
            Console.WriteLine(kuyruk.GetType());
            #endregion
        
            #region LinkedList
            Console.WriteLine("############# Linked List ######################\n\n");

            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();

            linkedList.listeBasinaElemanEkle(new Eleman(25));
            linkedList.listeyeEkle(new Eleman(55));
            linkedList.listeyeEkle(new Eleman(28));
            

            Console.WriteLine("Liste Başı: " + linkedList.bas.icerik);
            Console.WriteLine("Liste Başı İleri : " + linkedList.bas.ileri.icerik);

            linkedList.listeBasinaElemanEkle(new LinearStructures.LinkedList.Eleman(36));             // ! [[36,25], [25,55], [55,28], [28,null]]

            Console.WriteLine("Liste Başı: " + linkedList.bas.icerik);
            Console.WriteLine("Liste Başı İleri : " + linkedList.bas.ileri.icerik);

            Eleman arananEleman = linkedList.listedeAra(55);        
            if (arananEleman != null)
                Console.WriteLine($"Bulundu : {arananEleman.icerik}");
            else
                Console.WriteLine("Bulunamadı!");

            Eleman ilk = linkedList.ElemanGetir(0);
            Eleman uc = linkedList.ElemanGetir(3);
            Console.WriteLine("İlk eleman : " + ilk.icerik);
            Console.WriteLine("Üçüncü eleman : " + uc.icerik);

            Console.WriteLine("Liste Başı : " + linkedList.bas.icerik);
            Console.WriteLine("Liste Sonu : " + linkedList.son.icerik);
            Console.WriteLine("Liste başına gelen eleman : " + linkedList.ListeBasindanSil().icerik);
            Console.WriteLine("Liste sonuna gelen eleman : " + linkedList.ListeSonundanSil().icerik);

            linkedList.listeBasinaElemanEkle(new LinearStructures.LinkedList.Eleman(34));           // ! 2
            linkedList.listeBasinaElemanEkle(new LinearStructures.LinkedList.Eleman(74));           // ! 1
            linkedList.listeBasinaElemanEkle(new LinearStructures.LinkedList.Eleman(35));           // ! 0
            Console.WriteLine("1. Elemanın yerine gelen :" + linkedList.ListedenSil(linkedList.ElemanGetir(1)).icerik);
            Console.WriteLine("Listedeki eleman sayısı : " + linkedList.Count());
            Console.ReadLine();


            #endregion

            #region Trees

            #endregion;
        }


    public struct Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public decimal Maas { get; set; }

        public Personel(string ad, string soyad, bool cinsiyet = true, decimal maas = 5000)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Cinsiyet = cinsiyet;
            this.Maas = maas;
        }


        public override string ToString() => string.Format("{0,10} {1,10} {2,10} {3,10}", Ad, Soyad, Cinsiyet == true ? "Erkek": "Kadın", Maas);
        
        public string BasHarfler()=>  $"{Ad.Substring(0,1)}.{Soyad.Substring(0,1)}.";
    }
    
    }
}
