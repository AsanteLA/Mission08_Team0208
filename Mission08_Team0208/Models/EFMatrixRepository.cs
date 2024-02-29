
namespace Mission08_Team0208.Models
{
    public class EFMatrixRepository : IMatrixRepository
    {
        private TimeManagementMatrixContext _context;

        public EFMatrixRepository(TimeManagementMatrixContext temp) 
        { 
            _context = temp;
        }

        public List<TaskInfo> Tasks => _context.Tasks.ToList();
        public List<Category> Categories => _context.Categories.ToList();

        public List<Quadrant> Quadrants => _context.Quadrants.ToList();


        public void AddTask(TaskInfo task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
    }
}
