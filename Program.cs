using System;

namespace workshop3._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe newComptable = new Comptable();
            newComptable.Present();
        }
    }

    class Employe
    {
        public virtual void Present()
        {
            Console.WriteLine("Je suis un employe !");
        }
    }

    class Comptable : Employe 
    {
        public override void Present()
        {
            Console.WriteLine("Je suis un comptable !");
        }
    }
}
