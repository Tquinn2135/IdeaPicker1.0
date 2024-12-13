using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPicker.Models;

namespace IdeaPicker.Views;

public partial class AddIdeaPage : ContentPage
{
    
    public AddIdeaPage()
    {
        InitializeComponent();
        
        Title = "Add Ideas";
    }

    private void AddIdea_OnClicked(object sender, EventArgs e)
    {
        var newIdea = new Idea();
        if(!string.IsNullOrWhiteSpace(txtIdeaName.Text))
        {
           newIdea.FName = txtFName.Text;
           newIdea.IdeaName = txtIdeaName.Text; 
           
           App.IdeaList.AddIdea(newIdea);
        }
        txtFName.Text = "";
        txtIdeaName.Text = "";
    }

    private void BtnClear_OnClicked(object sender, EventArgs e)
    {
        txtFName.Text = "";
        txtIdeaName.Text = "";
    }
}