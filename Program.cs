using System;

namespace workshop3._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmploye newComptable = new Comptable();
            newComptable.AfficherMission();
        }
    }

    interface IEmploye
    {
        public void AfficherMission();
    }

    class Comptable : IEmploye 
    {
        void IEmploye.AfficherMission()
        {
            Console.WriteLine("Je suis un comptable !");
        }
    }

    class Ingenieur : IEmploye
    {
        void IEmploye.AfficherMission()
        {
            Console.WriteLine("Je suis un ingénieur !");
        }
    }

    class Directeur : IEmploye
    {
        void IEmploye.AfficherMission()
        {
            Console.WriteLine("Je suis un directeur !");
        }
    }
}
