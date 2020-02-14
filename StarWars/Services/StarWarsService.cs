using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using StarWars.Helpers;
using StarWars.Models;

namespace StarWars.Services {
    public class StarWarsService {

        public async Task<ObservableCollection<Character>> GetCharactersAsync() {
            try {
                var response = await RequestsHelper<ObservableCollection<Character>>.
                    Requests("api/characters", RequestsHelper<ObservableCollection<Character>>.MethodsRequest.GET);

                return response;
            } catch (Exception ex) {
                Debug.WriteLine($"Exception => GetCharactersAsync() {ex.Message}");
            }

            return null;
        }
    }
}
