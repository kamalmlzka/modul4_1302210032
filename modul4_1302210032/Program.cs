using System;
using System.Collections.Generic;

class KodeBuah
{
    private Dictionary<string, string> tableKodeBuah = new Dictionary<string, string>()
    {
        {"Apel    ", "A00"},
        {"Aprikot ", "B00"},
        {"Alpukat ", "C00"},
        {"Pisang  ", "D00"},
        {"Paprika ", "E00"},
        {"Kurma   ", "F00"},
        {"Durian  ", "H00"},
        {"Anggur  ", "I00"},
        {"Melon   ", "J00"},
        {"Semangka", "O00"}
    };

    public string getKodeBuah(string kodebuah)
    {
        if (tableKodeBuah.ContainsKey(kodebuah))
        {
            return tableKodeBuah[kodebuah];
        }
        else
        {
            return "";
        }
    }

    public void showAllKodeBuah()
    {
        foreach (KeyValuePair<string, string> keyval in tableKodeBuah)
        {
            Console.WriteLine("| " + keyval.Key + "\t |    " + keyval.Value + "    |");
        }
    }
}

class PosisiKarakterGame
{
    private enum PosisiState
    {
        Berdiri, Jongkok, Tengkurap, Terbang
    }

    private PosisiState state;

    public PosisiKarakterGame()
    {
        state = PosisiState.Berdiri;
        Console.WriteLine("Berdiri");
    }

    public void Jongkok()
    {
        if (state == PosisiState.Terbang)
        {
            state = PosisiState.Jongkok;
            Console.WriteLine("Jongkok");
            Console.WriteLine("\nposisi landing\n");
        } else
        {
            state= PosisiState.Jongkok;
            Console.WriteLine("Jongkok");
        }
    }

    public void Tengkurap()
    {
        state = PosisiState.Tengkurap;
        Console.WriteLine("Tengkurap");
    }

    public void Terbang()
    {
        if (state == PosisiState.Berdiri)
        {
            state = PosisiState.Terbang;
            Console.WriteLine("Terbang");
            Console.WriteLine("\nposisi take off\n");

        } else
        {
            state = PosisiState.Terbang;
            Console.WriteLine("Terbang");
        }
    }

    public void Berdiri()
    {
        state = PosisiState.Berdiri;
        Console.WriteLine("Berdiri");
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodebuah = new KodeBuah();
        Console.WriteLine("|   Nama Buah    | Kode Buah |");
        Console.WriteLine("");
        kodebuah.showAllKodeBuah();

        Console.WriteLine("\n\n");
        PosisiKarakterGame posisi = new PosisiKarakterGame();
        posisi.Terbang();
        posisi.Jongkok();
        posisi.Berdiri();
        posisi.Terbang();
    }
}

    
