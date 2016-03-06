using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class Pole
    {
        public int obecna;
        public int nastepna;
        public Pole()
        {
            obecna = 1;
        }
    }

    public class Wektor
    {
        public List<Pole> list = new List<Pole>();

        public Wektor(int ile)
        {
            for (int i = 0; i < ile; i++)
            {
                Pole pole = new Pole();
                list.Add(pole);
            }
        }
    }

    public class Kolumny
    {
        public List<Wektor> kol = new List<Wektor>();
        public Kolumny(int ile)
        {
            for (int i = 0; i < ile; i++)
            {
                Wektor wek = new Wektor(ile);
                kol.Add(wek);
            }
        }
    }


    class Program
    {




        static void Main(string[] args)
        {

            Random rnd = new Random();
            int ile = 10;
            Kolumny tab = new Kolumny(ile);

            for (int i = 0; i < ile; i++)
            {
                for (int j = 0; j < ile; j++)
                {
                    tab.kol[i].list[j].obecna = rnd.Next(0, 2);
                    //Console.Write(tab.kol[i].list[j].obecna);
                }
                //Console.WriteLine();
            }

            bool elo = true;
            while (elo == true)
            {
                for (int i = 0; i < ile; i++)
                {
                    for (int j = 0; j < ile; j++)
                    {
                        if (i > 0 && i < ile - 1 && j > 0 && j < ile - 1)
                        {
                            int wynik = 0;
                            if (tab.kol[i - 1].list[j - 1].obecna == 1)
                                wynik++;
                            if (tab.kol[i].list[j - 1].obecna == 1)
                                wynik++;
                            if (tab.kol[i + 1].list[j - 1].obecna == 1)
                                wynik++;
                            if (tab.kol[i - 1].list[j + 1].obecna == 1)
                                wynik++;
                            if (tab.kol[i - 1].list[j].obecna == 1)
                                wynik++;
                            if (tab.kol[i + 1].list[j + 1].obecna == 1)
                                wynik++;
                            if (tab.kol[i].list[j + 1].obecna == 1)
                                wynik++;
                            if (tab.kol[i + 1].list[j].obecna == 1)
                                wynik++;
                            //   Console.Write(wynik + "dla jednostki " + i + " " + j);
                            //   Console.WriteLine()
                            if ((wynik == 2 || wynik == 3) && tab.kol[i].list[j].obecna == 1)
                                tab.kol[i].list[j].nastepna = 1;
                            else
                                tab.kol[i].list[j].nastepna = 0;
                            if (wynik == 3 && tab.kol[i].list[j].obecna == 0)
                                tab.kol[i].list[j].nastepna = 1;
                        }

                        if (i == 0 && j == 0)
                        {
                            int wynik = 0;
                            if (tab.kol[i + 1].list[0].obecna == 1)
                                wynik++;
                            if (tab.kol[0].list[j + 1].obecna == 1)
                                wynik++;
                            if (tab.kol[i + 1].list[j + 1].obecna == 1)
                                wynik++;
                            if (wynik < 2 || wynik > 3)
                                tab.kol[i].list[j].nastepna = 0;
                            else
                                tab.kol[i].list[j].nastepna = 1;
                            if (tab.kol[i].list[j].obecna == 0 && wynik == 2)
                                tab.kol[i].list[j].nastepna = 0;
                        }
                        if (i == ile - 1 && j == ile - 1)
                        {
                            int wynik = 0;
                            if (tab.kol[ile - 2].list[0].obecna == 1)
                                wynik++;
                            if (tab.kol[ile - 2].list[ile - 2].obecna == 1)
                                wynik++;
                            if (tab.kol[0].list[ile - 2].obecna == 1)
                                wynik++;
                            if (wynik < 2 || wynik > 3)
                                tab.kol[i].list[j].nastepna = 0;
                            else
                                tab.kol[i].list[j].nastepna = 1;
                            if (tab.kol[i].list[j].obecna == 0 && wynik == 2)
                                tab.kol[i].list[j].nastepna = 0;
                        }
                        if (i == 0 && j == ile - 1)
                        {
                            int wynik = 0;
                            if (tab.kol[0].list[ile - 2].obecna == 1)
                                wynik++;
                            if (tab.kol[1].list[ile - 2].obecna == 1)
                                wynik++;
                            if (tab.kol[0].list[ile - 1].obecna == 1)
                                wynik++;
                            if (wynik < 2 || wynik > 3)
                                tab.kol[i].list[j].nastepna = 0;
                            else
                                tab.kol[i].list[j].nastepna = 1;
                            if(tab.kol[i].list[j].obecna == 0 && wynik == 2)
                                tab.kol[i].list[j].nastepna = 0;
                        }
                        if (i == ile-1 && j == 0)
                        {
                            int wynik = 0;
                            if (tab.kol[ile - 2].list[0].obecna == 1)
                                wynik++;
                            if (tab.kol[ile - 2].list[1].obecna == 1)
                                wynik++;
                            if (tab.kol[ile - 1].list[1].obecna == 1)
                                wynik++;
                            if (wynik < 2 || wynik > 3)
                                tab.kol[i].list[j].nastepna = 0;
                            else
                                tab.kol[i].list[j].nastepna = 1;
                            if (tab.kol[i].list[j].obecna == 0 && wynik == 2)
                                tab.kol[i].list[j].nastepna = 0;
                        }

                        //teraz krawędzie

                        //lewa
                        if (i == 0 && j != 0 && j != ile - 1)
                        {
                            int wynik = 0;
                            if (tab.kol[1].list[j-1].obecna == 1)
                                wynik++;
                            if (tab.kol[1].list[j].obecna == 1)
                                wynik++;
                            if (tab.kol[1].list[j+1].obecna == 1)
                                wynik++;
                            if (tab.kol[0].list[j + 1].obecna == 1)
                                wynik++;
                            if (tab.kol[0].list[j - 1].obecna == 1)
                                wynik++;
                            if (wynik < 2 || wynik > 3)
                                tab.kol[i].list[j].nastepna = 0;
                            else
                                tab.kol[i].list[j].nastepna = 1;
                            if (tab.kol[i].list[j].obecna == 0 && wynik == 2)
                                tab.kol[i].list[j].nastepna = 0;
                        }
                        //prawa
                        if (i == ile - 1 && j != 0 && j != ile - 1)
                        {
                            int wynik = 0;
                            if (tab.kol[ile - 2].list[j - 1].obecna == 1)
                                wynik++;
                            if (tab.kol[ile - 2].list[j].obecna == 1)
                                wynik++;
                            if (tab.kol[ile - 2].list[j + 1].obecna == 1)
                                wynik++;
                            if (tab.kol[ile - 1].list[j + 1].obecna == 1)
                                wynik++;
                            if (tab.kol[ile - 1].list[j - 1].obecna == 1)
                                wynik++;
                            if (wynik < 2 || wynik > 3)
                                tab.kol[i].list[j].nastepna = 0;
                            else
                                tab.kol[i].list[j].nastepna = 1;
                            if (tab.kol[i].list[j].obecna == 0 && wynik == 2)
                                tab.kol[i].list[j].nastepna = 0;
                        }
                        //gora
                        if (i != 0 && i != ile -1 && j == 0)
                        {
                            int wynik = 0;
                            if (tab.kol[i - 1].list[1].obecna == 1)
                                wynik++;
                            if (tab.kol[i].list[1].obecna == 1)
                                wynik++;
                            if (tab.kol[i + 1].list[1].obecna == 1)
                                wynik++;
                            if (tab.kol[i + 1].list[0].obecna == 1)
                                wynik++;
                            if (tab.kol[i - 1].list[0].obecna == 1)
                                wynik++;
                            if (wynik < 2 || wynik > 3)
                                tab.kol[i].list[j].nastepna = 0;
                            else
                                tab.kol[i].list[j].nastepna = 1;
                            if (tab.kol[i].list[j].obecna == 0 && wynik == 2)
                                tab.kol[i].list[j].nastepna = 0;
                        }
                        //dol
                        if (i != 0 && i != ile - 1 && j == ile - 1)
                        {
                            int wynik = 0;
                            if (tab.kol[i - 1].list[ile - 2].obecna == 1)
                                wynik++;
                            if (tab.kol[i].list[ile - 2].obecna == 1)
                                wynik++;
                            if (tab.kol[i + 1].list[ile - 2].obecna == 1)
                                wynik++;
                            if (tab.kol[i + 1].list[ile - 1].obecna == 1)
                                wynik++;
                            if (tab.kol[i - 1].list[ile - 1].obecna == 1)
                                wynik++;

                            if (wynik < 2 || wynik > 3)
                                tab.kol[i].list[j].nastepna = 0;
                            else
                                tab.kol[i].list[j].nastepna = 1;
                            if (tab.kol[i].list[j].obecna == 0 && wynik == 2)
                                tab.kol[i].list[j].nastepna = 0;
                        }

                    }


                    Console.WriteLine();
                }



                for (int i = 0; i < ile; i++)
                {
                    for (int j = 0; j < ile; j++)
                    {
                        tab.kol[i].list[j].obecna = tab.kol[i].list[j].nastepna;
                    }

                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


                for (int i = 0; i < ile; i++)
                {
                    for (int j = 0; j < ile; j++)
                    {
                        Console.Write(tab.kol[i].list[j].obecna);
                    }
                    Console.WriteLine();
                }

                System.Threading.Thread.Sleep(200);
                Console.Clear();
               // Console.ReadLine();
            }
        }
    }
}
