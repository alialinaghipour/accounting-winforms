namespace DataLayer.ViewModels
{
    public class GetAllContactViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public string? Instageram { get; set; }
        public string Mobile { get; set; } = default!;
    }

    public class GetAllNameContactViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
    }

    public class GetNameContactViewModel
    {
        public string FullName { get; set; } = default!;
    }
}
