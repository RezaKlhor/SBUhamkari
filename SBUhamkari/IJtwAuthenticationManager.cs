namespace SBUhamkari
{
    public interface IJtwAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
