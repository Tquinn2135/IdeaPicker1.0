using IdeaPicker.Models;

namespace IdeaPicker;

public partial class App : Application
{
    public static List<Idea> IdeaList;
    public App()
    {
        InitializeComponent();
        IdeaList = new List<Idea>();
        MainPage = new AppShell();
    }
}