namespace Hexagonal.Algorithms.Interfaces.JobSequencing
{
    public interface IJob
    {
        string JobId { get; set; }
        decimal DeadLine { get; set; }

        decimal Profit { get; set; }
    }
}
