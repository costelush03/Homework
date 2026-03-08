using WorkersApp.Interfaces;

namespace WorkersApp.Services
{
    public class WorkManager
    {
        private readonly IWorkable _worker;

        public WorkManager(IWorkable worker)
        {
            _worker = worker;
        }

        public void ManageWork()
        {
            _worker.Work();
        }
    }
}
