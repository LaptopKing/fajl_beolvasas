using System;
using System.IO;
using System.Collections.Generic;
using System.Linq; 
using System.Text;

public class Adatok
{
	public int adat1;
	public string adat2;
	public int adat3;
	public char adat4;
	public Adatok(int adat1, string adat2, int adat3, char adat4) // konstruktor, minden ami ebben van lefut ha meghívod a futó programban
	{
		this.adat1 = adat1;
		this.adat2 = adat2;
		this.adat3 = adat3;
		this.adat4 = adat4;
	}
}

public class Program
{
	public static void Main()
	{
		StreamReader reader = new StreamReader("filenev.txt");
		List<Adatok> adatok = Beolvas(reader);
		
		Console.WriteLine("adat1 : {0}\nadat2 : {1}\nadat3 : {2}\nadat4 : {3}", adatok[0].adat1, adatok[0].adat2, adatok[0].adat3, adatok[0].adat4);
	}
	
	public static List<Adatok> Beolvas(StreamReader reader)
	{
		List<Adatok> adatok = new List<Adatok>();
		
		string line = "";
		while ((line = reader.ReadLine()) != null)
		{
			string[] temp = line.Split(';'); // ez persze akkor releváns, ha ; az elválasztó a fájlban
			Adatok adat = new Adatok(int.Parse(temp[0]), temp[1], int.Parse(temp[2]), char.Parse(temp[3]));
			adatok.Add(adat);			
		}
		
		return adatok;
	}
}
