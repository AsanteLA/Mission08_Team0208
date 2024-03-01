using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0208.Models
{
    public interface IMatrixRepository
    {
        List<Category> Categories { get; }

        List<Quadrant> Quadrants { get; }

        List<TaskInfo> Tasks { get; }

        public void AddTask(TaskInfo task);

        public void Edit(TaskInfo UpdatedInfo);

        public void Delete(TaskInfo Delete);

    }
}
