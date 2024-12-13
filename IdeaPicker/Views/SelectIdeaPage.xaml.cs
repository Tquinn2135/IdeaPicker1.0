using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPicker.Models;

namespace IdeaPicker.Views;

public partial class SelectIdeaPage : ContentPage
{
    
    
    public SelectIdeaPage()
    {
        InitializeComponent();
    }

    private void BtnSelectIdea_OnClicked(object sender, EventArgs e)
    {
        var randomIdea = App.IdeaList.GetRandomIdea();
        
        if (randomIdea != null)
        {
            lblFName.Text = "Winner: " + randomIdea.FName;
            lblActivity.Text = "Activity Selected: " + randomIdea.IdeaName;
        }
        else
        {
            lblActivity.Text = "No Ideas Found.";
        }
    }
}