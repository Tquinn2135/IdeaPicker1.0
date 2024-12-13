using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPicker.Models;

namespace IdeaPicker.Views;

public partial class AddIdeaPage : ContentPage
{
    private readonly Repository _repository;
    
    public AddIdeaPage()
    {
        InitializeComponent();
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "ideas.db");
        _repository = new Repository(dbPath);
    }

    private void AddIdea_OnClicked(object sender, EventArgs e)
    {
        string firstName = txtFName.Text;
        string ideaName = txtIdeaName.Text;

        if (!string.IsNullOrWhiteSpace(ideaName))
        {
            var idea = new Idea
            {
                FName = firstName,
                IdeaName = ideaName
            };
            _repository.AddIdea(idea);
            txtFName.Text = "";
            txtIdeaName.Text = "";
        }
    }

    private void BtnClear_OnClicked(object sender, EventArgs e)
    {
        txtFName.Text = "";
        txtIdeaName.Text = "";
    }
}