using Marvel.ApiClient.Models;
using Marvel.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Controller
{
    public class CharacterController
    {
        public static async Task<Hero> GetCharacterById(int id, ObservableCollection<string> error)
        {
            try
            {
                var response = await App.Api.GetCharacterById(id, error);

                if(response?.Data?.Results?.FirstOrDefault() is Character character)
                {
                    var hero = new Hero();
                    hero.ConvertHeroeFromCharacter(character);
                    return hero;
                }

            }
            catch (System.Exception ex)
            {
                error.Add(ex.Message);
            }

            return null;
        }
    }
}
