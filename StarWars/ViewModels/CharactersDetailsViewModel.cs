using System;
using StarWars.Models;
using Xamarin.Forms;

namespace StarWars.ViewModels {
    public class CharactersDetailsViewModel : ViewModelBase {
        private Character _selectedCharacter;

       

        public CharactersDetailsViewModel(Page page, Character selectedCharacter) : base(page) {
            Title = "Details";
            _selectedCharacter = selectedCharacter;
        }
    }
}
