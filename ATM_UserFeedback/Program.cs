namespace ATM_UserFeedback
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATMController controller = new ATMController();

            controller.DisplayLoginScreen();
        }
    }
}
