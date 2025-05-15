namespace ProductionSystem.Web.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Account { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string UserType { get; set; } = string.Empty;
        public string AllowApp { get; set; } = string.Empty;
        public string AllowView { get; set; } = string.Empty;
    }
}