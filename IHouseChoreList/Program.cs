using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IHouseChoreList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> members = new List<People>();
            List<People> weekChores = new List<People>();
            People people = new People("");

            Random rand = new Random();
            int x;

            #region All Member Creation
            People _john = new People("John");
            People _gabe = new People("Gabe");
            People _aaron = new People("Aaron");
            People _ian = new People("Ian");
            People _simran = new People("Simran");
            People _ketaki = new People("Ketaki");
            People _jenna = new People("Jenna");
            People _sabrina = new People("Sabrina");
            People _emmaJ = new People("Emma J");
            People _xy = new People("Xy");
            People _rose = new People("Rose");
            People _rachel = new People("Rachel");
            People _casey = new People("Casey");
            People _daniel = new People("Daniel");
            People _lea = new People("Lea");
            People _austin = new People("Austin");
            People _dane = new People("Dane");
            People _dante = new People("Dante");
            People _emmaC = new People("Emma C");
            People _guada = new People("Guada");
            People _paulina = new People("Paulina");
            People _jacob = new People("Jacob");
            People _janelle = new People("Janelle");
            People _konce = new People("Konce");
            People _kristine = new People("Kristine");
            People _ruben = new People("Ruben");
            People _sierra = new People("Sierra");
            People _thomas = new People("Thomas");
            People _tobin = new People("Tobin");
            People _evan = new People("Evan");
            People _van = new People("Van");
            People _vishvam = new People("Vishvam");
            People _riley = new People("Riley");
            #endregion

            #region All Members
            members.Add(_john);
            members.Add(_ian);
            members.Add(_gabe);
            members.Add(_simran);
            members.Add(_ketaki);
            members.Add(_riley);
            members.Add(_rachel);
            members.Add(_sabrina);
            members.Add(_aaron);
            members.Add(_austin);
            members.Add(_casey);
            members.Add(_dane);
            members.Add(_daniel);
            members.Add(_dante);
            members.Add(_emmaC);
            members.Add(_emmaJ);
            members.Add(_evan);
            members.Add(_guada);
            members.Add(_jacob);
            members.Add(_janelle);
            members.Add(_jenna);
            members.Add(_konce);
            members.Add(_kristine);
            members.Add(_lea);
            members.Add(_paulina);
            members.Add(_rose);
            members.Add(_ruben);
            members.Add(_sierra);
            members.Add(_thomas);
            members.Add(_tobin);
            members.Add(_van);
            members.Add(_vishvam);
            members.Add(_xy);
            #endregion

            #region Current Week's Chores
            weekChores.Add(_dante);
            weekChores.Add(_sabrina);
            weekChores.Add(_sierra);
            weekChores.Add(_austin);
            weekChores.Add(_janelle);
            weekChores.Add(_gabe);
            weekChores.Add(_xy);
            weekChores.Add(_ian);
            weekChores.Add(_van);
            weekChores.Add(_paulina);
            weekChores.Add(_kristine);
            weekChores.Add(_daniel);
            weekChores.Add(_thomas);
            weekChores.Add(_tobin);
            weekChores.Add(_emmaJ);
            weekChores.Add(_john);
            #endregion

            // Uncomment to clear all of the members chores 
            // for the new week
            //Clear(members);

            // Uncomment to show the chores that people have done before
            foreach (People element in members)
            {
                if (element.Chores != null)
                {
                    //Console.WriteLine(element.Chores);
                    //Console.WriteLine();
                }

            }

            // Assigns chore
            for (int i = 0; i < 16; i++)
            {
                x = rand.Next(0, 16);

                if((weekChores[x].Picked == false))
                {
                    weekChores[x].AssignChore(weekChores[x], i);
                    
                }

            }

            // Saves the chores for who has done what chore
            people.Save(members);

            // Clears the past chores that the members have had
            void Clear(List<People> person)
            {
                for (int i = person.Count - 1; i > 0; i--)
                {
                    person.RemoveAt(i);

                }

            }



        }
    }
}
