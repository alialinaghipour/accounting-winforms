namespace DataLayer.Models
{
    public class MyProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public string Mobile { get; set; } = default!;
        public string? Instagram { get; set; }
        public string? Email { get; set; }
        public string? ImageName { get; set; }
        public string? Description { get; set; }
    }
}
