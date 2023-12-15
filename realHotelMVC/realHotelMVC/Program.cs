namespace realHotelMVC
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

            View bookRoom = new View();
            Model model = new Model();
            Controller controller = new Controller();

            controller.Model = model;
            controller.View = bookRoom;
            bookRoom.Controller = controller;
            model.Controller = controller;

            Application.Run(new View());
        }
    }
}