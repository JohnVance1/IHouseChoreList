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

            #region Fields
            List<People> members = new List<People>();
            List<People> weekChores = new List<People>();
            StreamWriter write = null;

            Random rand = new Random();
            int x;
            int y = 0;
            int k = 0;
            List<int> chosen = new List<int>();
            #endregion


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
            People _chris = new People("Chris");
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
            weekChores.Add(_gabe);
            weekChores.Add(_jenna);
            weekChores.Add(_aaron);
            weekChores.Add(_vishvam);
            weekChores.Add(_riley);
            weekChores.Add(_simran);
            weekChores.Add(_rose);
            weekChores.Add(_guada);
            weekChores.Add(_rachel);
            weekChores.Add(_dane);
            weekChores.Add(_lea);
            weekChores.Add(_jacob);
            weekChores.Add(_emmaC);
            weekChores.Add(_casey);
            weekChores.Add(_konce);
            weekChores.Add(_evan);
            #endregion


            #region Uncommented Code
            // Uncomment to clear all of the members chores 
            // for the new week
            //Clear(members);

            // Uncomment to show the chores that people have done before
            //foreach (People element in members)
            //{
            //    if (element.Chores != null)
            //    {
            //        Console.WriteLine(element.Chores);
            //        Console.WriteLine();
            //    }

            //}
            #endregion


            #region Method Instantiation
            //Assigns a random chore to everyone
            RandomChore();

            // Saves the chores for who has done what chore
            Save(members);
            #endregion


            #region Main Methods
            // Assigns a random chore
            void RandomChore()
            {
                while (y != 16)
                {                    
                    x = rand.Next(0, 16);
                    weekChores[x].ChoresDone(weekChores[x]);

                    if ((weekChores[x].Picked == false) && (chosen.Contains(x) == false) && (weekChores[x].Chores.Contains(x) == false))
                    {
                        weekChores[x].AssignChore(weekChores[x], k);
                        y++;
                        chosen.Add(x);
                        weekChores[x].Picked = true;
                        k++;


                    }
                    
                }
            }

            // Clears the past chores that the members have had
            void Clear(List<People> person)
            {
                for (int i = person.Count - 1; i > 0; i--)
                {
                    person.RemoveAt(i);

                }

            }

            void Save(List<People> people)
            {                
                try
                {
                    write = new StreamWriter("ChoresDone.txt");
                    foreach (People element in people)
                    {
                        write.WriteLine(element.Name);

                        for (int i = 0; i < element.Chores.Count; i++)
                        {
                            element.WeeksChore += element.Chores[i] + ",";

                        }

                        write.WriteLine(element.WeeksChore);
                    }

                }

                catch (Exception e)
                {
                    Console.WriteLine("Error writing to file: " + e.Message);

                }

                finally
                {
                    if (write != null)
                    {
                        write.Close();

                    }

                }


            }
            #endregion




        }
    }
}
