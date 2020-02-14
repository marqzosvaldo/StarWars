using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using StarWars.Models;
using StarWars.Services;
using Xamarin.Forms;

namespace StarWars.ViewModels {
    public class CharactersViewModel : ViewModelBase {


        public CharactersViewModel(Page page) : base(page) {
            Title = "Characters";
            page.Appearing += Page_Appearing;
        }

        private void Page_Appearing(object sender, EventArgs e) {
            GetCharactersCollection();
        }
        Character _selectedCharacter;
        public Character SelectedCharacter {
            get => _selectedCharacter;
            set {
                _selectedCharacter = value;
                OnPropertyChanged("SelectedCharacter");
            }
        }

        ObservableCollection<Character> _charactersCollection;

        public ObservableCollection<Character> CharactersCollection {
            get => _charactersCollection;
            set {
                _charactersCollection = value;
                OnPropertyChanged("CharactersCollection");
            }
        }
        private ICommand _characterSelectedCommand;

        public ICommand CharacterSelectedCommand => _characterSelectedCommand ?? (_characterSelectedCommand = new Command(async () => {

            Debug.WriteLine($"Selected {_selectedCharacter.Name} ");

        }));



        async void GetCharactersCollection() {
            StarWarsService starWarsService = new StarWarsService();

            try {
                var response = await starWarsService.GetCharactersAsync();
                if(response != null) {
                    CharactersCollection = response;
                }
            } catch (Exception ex) {
                Debug.WriteLine($"Exception GetCharactersCollection() {ex.Message}");
            }
        }

        
    }
}
