using System;
using System.Collections.Generic;
using StarWars.ViewModels;
using Xamarin.Forms;

namespace StarWars.Views {
    public partial class CharactersPage : ContentPage {

        CharactersViewModel _vm;

        public CharactersViewModel VM { get => _vm = new CharactersViewModel(this); }

        public CharactersPage() {
            InitializeComponent();

            BindingContext = VM;
        }
    }
}
