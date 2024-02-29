namespace Mission08_Team0208.Models
{
    public interface IMatrixRepository
    {
        List<Category> Categories { get; }

        List<Quadrant> Quadrants { get; }
    }
}
