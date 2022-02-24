namespace Contemplation;

public static class Global
{
    public static Pages CurrentPage { get; set; } = Pages.Home;
    
    public enum Pages
    {
        Home,
        Portfolio,
        About,
        Contact
    }
}