using System;

namespace workshop3._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            Controller controller = new Controller();
            Model model = new Model();
            view.Controller = controller;
            controller.Model = model;
            controller.View = view;
            view.GetUserInputs();
        }
    }
}
