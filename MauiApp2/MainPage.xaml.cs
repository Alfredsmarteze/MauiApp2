using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MauiApp2
{
	public partial class MainPage : ContentPage
	{
		int count = 0;
		//bool result=false;	
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnCounterClicked(object sender, EventArgs e)
		{
			count++;
			CounterLabel.Text = $"Count increase: {count}";
			SemanticScreenReader.Announce(CounterLabel.Text);
			await DisplayAlert($"Counter, today's date is {DateTime.Now.ToString("M") +" "+ DateTime.Now.Year} ", $"Count increase by {count}","Ok", "Cancel", Microsoft.Maui.FlowDirection.MatchParent);
			var dc= await DisplayPromptAsync("OK","Cancel");
			if(dc=="Ok")
			await	DisplayAlert("Info", "Copied", "Cancel");
            
			
			
		}
		private async void OnCounterDecreaseClicked(object sender, EventArgs e)
		{
			if (count < 1)
			{
				count = 1;
				CounterLabel.Text = $"Cannot count below 0:{count}";
			}
			
			count--;
			CounterLabel.Text=$"Count decrease:{count}";
			SemanticScreenReader.Announce(CounterLabel.Text);
			await DisplayActionSheet("Testing", "Cancel", "Ok", Microsoft.Maui.FlowDirection.MatchParent);
		}
	}
}
