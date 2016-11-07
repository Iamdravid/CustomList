using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomGenericList<string> CustomGenericList = new CustomGenericList<string>();

            //added digimon
            CustomGenericList.Add("Agumon");
            CustomGenericList.Add("Gabumon");
            CustomGenericList.Add("WarGreymon");
            CustomGenericList.Add("Angelmon");
            CustomGenericList.Add("Leomon");
            CustomGenericList.Add("Palamon");
            CustomGenericList.Print();
            Console.ReadLine();

            //removed 1 
            Console.WriteLine("Removed Leomon from arrayList");
            CustomGenericList.RemoveAt("Leomon");
            CustomGenericList.Print();
            Console.ReadLine();

            string GenericString = CustomGenericList.GenericString();
            Console.WriteLine(GenericString);
            Console.ReadLine();

            //count 
            Console.WriteLine("There are {0} digimon in my arrayList now.", CustomGenericList.Count());
            CustomGenericList.Print();
            Console.ReadLine();


            Console.WriteLine("\nOverload + Operator to add two instances of my custom class.");
            CustomGenericList<string> TempList = new CustomGenericList<string>();

            TempList.Add("4");
            TempList.Add("7");
            TempList.Add("1");

            CustomGenericList<string> CombineList = new CustomGenericList<string>();
            CombineList = CustomGenericList + TempList;
            CombineList.Print();
            Console.ReadLine();

            Console.WriteLine("\nOverload - Operator to remove one custom list from another.");
            CustomGenericList<string> RemoveFromList = new CustomGenericList<string>();
            RemoveFromList = CustomGenericList - TempList;
            RemoveFromList.Print();
            Console.ReadLine();

            //Zipper
            Console.WriteLine("\nZipper two Custom Lists");
            CustomGenericList<string> ZipList = new CustomGenericList<string>();
            ZipList.Zipper(CustomGenericList, TempList);
            ZipList.Print();
            Console.ReadLine();

        }
    }
}
