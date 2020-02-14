using System;
using System.Collections.Generic;
using StarWars.Models;
using StarWars.ViewModels;
using Xamarin.Forms;

namespace StarWars.Views.Modals {
    public partial class CharacterDetailsPage : ContentPage {
        Character _selectedCharacter;
        CharactersDetailsViewModel _vm;

        CharactersDetailsViewModel VM { get => _vm = new CharactersDetailsViewModel(this, _selectedCharacter); }
        public CharacterDetailsPage(Character selectedCharacter) {
            InitializeComponent();

            _selectedCharacter = selectedCharacter;
            BindingContext = VM;
        }

        async void Button_Clicked_Back(System.Object sender, System.EventArgs e) {
            await Navigation.PopModalAsync();
        }
    }
}
