
namespace Mission08_Team0208.Models
{
    public class EFMatrixRepository : IMatrixRepository
    {
        private TimeManagementMatrixContext _context;

        public EFMatrixRepository(TimeManagementMatrixContext temp) 
        { 
            _context = temp;
        }

        public List<Category> Categories => _context.Categories.ToList();

        public List<Quadrant> Quadrants => _context.Quadrants.ToList();

        public void AddTask(TaskInfo task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }
    }
}
