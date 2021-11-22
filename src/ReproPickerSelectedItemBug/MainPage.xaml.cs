using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReproPickerSelectedItemBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ThePicker.ItemsSource = Enumerable.Range(10, 20).ToList();
        }

        void ChangeItem_Clicked(object sender, EventArgs e)
            => ThePicker.SelectedItem = ThePicker.ItemsSource[new Random().Next(ThePicker.ItemsSource.Count)];
        
        void ChangeIndex_Clicked(object sender, EventArgs e)
            => ThePicker.SelectedIndex = new Random().Next(ThePicker.ItemsSource.Count);

        private void Check_Clicked(object sender, EventArgs e)
        {
            Result.Text = $"SelectedItem: {ThePicker.SelectedItem}, SelectedIndex:{ThePicker.SelectedIndex}";
        }
    }
}
