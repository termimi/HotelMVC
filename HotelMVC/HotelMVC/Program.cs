namespace HotelMVC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Model model = new Model();
            Controller controller = new Controller();
            View bookRoom = new View();

            model.Controller = controller;
            bookRoom.Controller = controller;
            controller.Model = model;
            controller.View = bookRoom;
            Application.Run(new Form1());
        }
    }
}