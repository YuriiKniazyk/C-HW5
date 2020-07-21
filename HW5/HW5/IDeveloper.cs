namespace HW5
{
    public interface IDeveloper
    {
        string Tool { get; set; }
        string Create();
        string Destroy();
    }
}