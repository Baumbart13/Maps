﻿using Maps.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Maps.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}