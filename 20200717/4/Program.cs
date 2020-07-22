using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class IndexerTest
{ 
    private Hashtable myFavorite = new Hashtable();
    public string this[string kind]
    {
        get { return (string)myFavorite[kind]; }
        set { myFavorite[kind] = value; }
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        IndexerTest it = new IndexerTest();
        it["fruit"] = "apple";
        it["color"] = "blue";
        Console.WriteLine(it["fruit"]);
        Console.WriteLine(it["color"]);
    }
}