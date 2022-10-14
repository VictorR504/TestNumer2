using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Program;
   

namespace Närträff_2_1
{
    internal class Person
    {
        private string namn, adress, tele;
        public int NumbPer = 0;
        public Person[] list = new Person[2];

        public Person(string namn, string adress, string tele)
        {
            this.namn = namn;
            this.adress = adress;
            this.tele = tele;
        }
        public Person()
        {

        }
        public string Name
        {
            get { return namn; }
            set { namn = value; }
        }

        public string Tele
        {
            get { return tele; }
            set { tele = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public void runClassAdd()
        {
            AddDynamiskPerson();
            PrintListDynamik();
        }
        public void AddDynamiskPerson()
        {
            PrintListDynamik();
            WriteLine("ADD PERSON TO PHONEBOOK");
            Write("NAME: ");
            Name = ReadLine();
            Write("ENTER A ADRESS: ");
            Adress = ReadLine();
            Write("ENTER A PHONENUMBER: ");
            Tele = ReadLine();
            list[NumbPer] = new Person(Name,Adress,Tele);
            NumbPer++;
        }
        public void PrintListDynamik()
        {
            foreach (Person person in list)
            {
                WriteLine(person);
            }
        }
        public override string ToString()
        {
            return String.Format($"Namn: {namn} Adress: {adress} Telefonnummer: {tele}");
        }
    }
}
