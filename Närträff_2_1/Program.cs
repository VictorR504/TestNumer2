using Närträff_2_1;
using System;
using System.Reflection;
using static System.Console;

namespace Program
{
    class prog
    {

        /*För att listan bara ska kunna ta classen
        public Person<Person>[];*/

        static void StartLogo()
        {
            WriteLine("==========================");
            WriteLine("WELCOME TO YOUR PHONEBOOK");
            WriteLine("==========================");
        }
        static void OptionMenu()
        {
            WriteLine("[1] ADD CONTACT");
            WriteLine("[5] ADD DYNAMIK");
            WriteLine("[2] DISPLAY CONTACT");
            WriteLine("[6] DISPLAY DYNAMIK");
            WriteLine("[3] REMOVE CONTACT");
            WriteLine("[7] EXIT");

        }
     
        static void AddPerson(Person[] persons)
        {
            DisplayList(persons);

            WriteLine("DEDICATE ADRESS TO A NUMBER");
            Write("OPTION [1] TO [10]: ");
            try
            {
                int index = Convert.ToInt32(ReadLine());
                persons[index] = new Person(null,null,null);
                Write("ENTER A NAME: ");
                persons[index].Adress = ReadLine();

                Write("ENTER A ADRESS: ");
                persons[index].Adress = ReadLine();

                Write("ENTER A PHONENUMBER: ");
                persons[index].Tele = ReadLine();

            }
            catch
            {
                WriteLine("ENTER A NUMBER");
                WriteLine("PRESS ENTER TO CONTINUE");
                ReadKey();
            }
          }
        
        static void DisplayList(Person[] persons)
        {
            int x = 0;
            foreach (Person var in persons)
            {
                Write(x + " ");
                WriteLine(var);
                x++;
            }
        }

        static void RemovePerson(Person[] persons)
        {

            Write("ENTER NUMBER OF ADRESS TO REMOVE: ");
            try
            {
                int input = Convert.ToInt32(ReadLine());
                persons[input] = new Person(null,null,null);
            }
            catch
            {
                WriteLine("ENTER A NUMBER");
                ReadKey();
            }
        }

        static void Run()
        {

            Person[] persons = new Person[10];
            Person person = new Person();
            string input;
            StartLogo();
            OptionMenu();
            do
            {
                Write("CHOSE A OPTION: ");
                input = ReadLine();
                if (input == "1")
                {
                    Clear();
                    AddPerson(persons);
                }
                else if (input == "2")
                {
                    Clear();
                    DisplayList(persons);
                    Write("PRESS ENTER");
                    ReadKey();
                    Clear();
                }
                else if (input == "3")
                {
                    DisplayList(persons);
                    RemovePerson(persons);
                    Clear();
                }
                else if (input == "5")
                {
                    
                    person.AddDynamiskPerson();
                }
                else if (input == "6")
                {
                    
                    person.PrintListDynamik();
                }
                else
                {
                    WriteLine("BYE BYE");
                }
                StartLogo();
                OptionMenu();
            }
            while (input != "7");
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}