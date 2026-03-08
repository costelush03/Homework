using WorkersApp.Workers;
using WorkersApp.Services;
using WorkersApp.Interfaces;

class Program
{
    static void Main()
    {
        IWorkable human = new HumanWorker();
        IWorkable robot = new RobotWorker();

        WorkManager manager1 = new WorkManager(human);
        WorkManager manager2 = new WorkManager(robot);

        manager1.ManageWork();
        manager2.ManageWork();
    }
}
