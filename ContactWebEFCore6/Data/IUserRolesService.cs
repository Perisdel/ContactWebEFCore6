namespace ContactWebEFCore6.Data
{
    public interface IUserRolesService
    {
        Task EnsureAdminUserRole();
    }
}