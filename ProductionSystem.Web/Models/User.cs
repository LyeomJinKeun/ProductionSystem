namespace ProductionSystem.Web.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string AllowApp { get; set; }
        public string AllowView { get; set; }
    }
}