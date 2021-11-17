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
            Data data = new Data();
            view.Text = Console.ReadLine();
            controller.String = view.Text;
            data.String = controller.String;
            data.StringUpper = model.Convert(data.String);
            controller.StringUpper = data.StringUpper;
            view.StringToShow = controller.StringUpper;
        }
    }
}
