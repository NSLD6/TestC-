using System;
using System.Collections.Generic;
using System.Numerics;

namespace Applitest
{
    class Program
    {
    /*  static void Main(string[] args)
          {
              //Console.WriteLine("Hello World!");
              //Console.WriteLine(System.DateTime.Now);
              //Console.WriteLine(System.Environment.UserName);

              Complex c = Complex.One;
              Console.WriteLine(c);
              Console.WriteLine("Partie réelle : " + c.Real);
              Console.WriteLine("Partie imaginaire : " + c.Imaginary);

              Console.WriteLine(Complex.Conjugate(Complex.FromPolarCoordinates(1.0, 45 * Math.PI / 180)));

          } */

        static void Main(string[] args)
        {
            /* Console.WriteLine(CalculSommeEntiers(1, 10));
             Console.WriteLine(CalculSommeEntiers(1, 100));

             List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
             Console.WriteLine(CalculMoyenne(liste));

             DateTime dateCourante = DateTime.Now;

              if (dateCourante.DayOfWeek == DayOfWeek.Saturday ||
                  dateCourante.DayOfWeek == DayOfWeek.Sunday ||
                  (dateCourante.DayOfWeek == DayOfWeek.Monday && dateCourante.Hour < 9) ||
                  (dateCourante.DayOfWeek == DayOfWeek.Friday && dateCourante.Hour >= 18))
              {
                  // nous sommes le week-end
                  AfficherBonWeekEnd();
              }
              else
              {
                  // nous sommes en semaine
                  if (dateCourante.Hour >= 9 && dateCourante.Hour < 18)
                  {
                      // nous sommes dans la journée
                      AfficherBonjour();
                  }
                  else
                  {
                      AfficherBonsoir();
                  }
              }
          }

          static void AfficherBonWeekEnd()
          {
              Console.WriteLine("Bon week-end " + Environment.UserName);
          }

          static void AfficherBonjour()
          {
              Console.WriteLine("Bonjour " + Environment.UserName);
          }

          static void AfficherBonsoir()
          {
              Console.WriteLine("Bonsoir " + Environment.UserName);
          }

      }*/

            /*  static int CalculSommeEntiers(int borneMin, int borneMax)
              {
                  int resulat = 0;
                  for (int i = borneMin; i <= borneMax; i++)
                  {
                      resulat += i;
                  }
                  return resulat;
              }

              static double CalculMoyenne(List<double> liste)
              {
                  double somme = 0;
                  foreach (double valeur in liste)
                  {
                      somme += valeur;
                  }
                  return somme / liste.Count;
              }

              static int CalculSommeIntersection()
              {
                  List<int> multiplesDe3 = new List<int>();
                  List<int> multiplesDe5 = new List<int>();

                  for (int i = 3; i <= 100; i += 3)
                  {
                      multiplesDe3.Add(i);
                  }
                  for (int i = 5; i <= 100; i += 5)
                  {
                      multiplesDe5.Add(i);
                  }

                  int somme = 0;
                  foreach (int m3 in multiplesDe3)
                  {
                      foreach (int m5 in multiplesDe5)
                      {
                          if (m3 == m5)
                              somme += m3;
                      }
                  }
                  return somme;
              }*/

                int valeurATrouver = new Random().Next(0, 100);
                int nombreDeCoups = 0;
                Console.WriteLine("Veuillez saisir un nombre compris entre 0 et 100 (exclu)");
                while (true)
                {
                    string saisie = Console.ReadLine();
                    int valeurSaisie;
                    if (!int.TryParse(saisie, out valeurSaisie))
                    {
                        Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
                        continue;
                    }
                    if (valeurSaisie < 0 || valeurSaisie >= 100)
                    {
                        Console.WriteLine("Vous devez saisir un nombre entre 0 et 100 exclu ...");
                        continue;
                    }
                    nombreDeCoups++;
                    if (valeurSaisie == valeurATrouver)
                        break;
                    if (valeurSaisie < valeurATrouver)
                        Console.WriteLine("Trop petit ...");
                    else
                        Console.WriteLine("Trop grand ...");
                }
                if (nombreDeCoups == 1)
                    Console.WriteLine("Vous avez trouvé en " + nombreDeCoups + " coup");
                else
                    Console.WriteLine("Vous avez trouvé en " + nombreDeCoups + " coups");
            
        }
    }
}