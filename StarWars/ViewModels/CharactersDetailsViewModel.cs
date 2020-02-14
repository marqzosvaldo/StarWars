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

        public string Image { get => _selectedCharacter.Image; }
        public string Name { get => _selectedCharacter.Name; }
        public string Description { get => _selectedCharacter.Description; }
        public string Planet { get => _selectedCharacter.Planet; }
        public string Height { get => _selectedCharacter.Height; }
        public string Species { get => _selectedCharacter.Species; }
        public string Gender { get => _selectedCharacter.Gender; }
        public string Birth { get => _selectedCharacter.Birth; }
    }
}
