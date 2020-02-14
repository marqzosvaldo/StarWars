using System;
using System.Collections.Generic;
using StarWars.Models;
using StarWars.ViewModels;
using Xamarin.Forms;

namespace StarWars.Views.Modals {
    public partial class CharactersDetailsPage : ContentPage {
        Character _selectedCharacter;
        CharactersDetailsViewModel _vm;
        CharactersDetailsViewModel VM { get => _vm = new CharactersDetailsViewModel(this, _selectedCharacter); }

        public CharactersDetailsPage(Character selectedCharacter) {
            InitializeComponent();
            _selectedCharacter = selectedCharacter;
            BindingContext = VM;
        }
    }
}
