using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPicker.Models;

namespace IdeaPicker.Views;

public partial class SelectIdeaPage : ContentPage
{
    private readonly Repository _repository;
    
    public SelectIdeaPage()
    {
        InitializeComponent();
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "ideas.db");
        _repository = new Repository(dbPath);
    }

    private void BtnSelectIdea_OnClicked(object sender, EventArgs e)
    {
        var randomIdea = _repository.GetRandomIdea();
        if (randomIdea != null)
        {
            lblFName.Text = $"Winner:  {randomIdea.FName}";        //used these instead of a list since
            lblActivity.Text = $"Activity:  {randomIdea.IdeaName}"; //I only need one result from the DB

        }
        else
        {
            lblActivity.Text = "No Ideas Found";
        }
    }
}