using SQLite;
namespace IdeaPicker.Models;

public class Repository
{
    private readonly SQLiteConnection _database;

    public Repository(string dbPath)
    {
        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<Idea>();
    }

    public void AddIdea(Idea idea)
    {
        _database.Insert(idea);
    }

    public Idea GetRandomIdea()
    {
        var ideaCount = _database.Table<Idea>().Count();
        if (ideaCount == 0) return null;

        var random = new Random();
        int randomID = random.Next(1, ideaCount + 1);
        return _database.Table<Idea>().FirstOrDefault(i => i.IdeaID == randomID);
    }

}