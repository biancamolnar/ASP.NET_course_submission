namespace Bmerketo.ViewModels.Admin
{
    public class AdminEditUserViewModel
    {
        public string Id { get; set; }
        public IList<string> Roles { get; set; }
        public IList<string> AllRoles { get; set; }
        public string SelectedRole { get; set; }
    }
}
