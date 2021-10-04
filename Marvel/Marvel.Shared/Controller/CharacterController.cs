using Marvel.ApiClient.Models;
using Marvel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Controller
{
    public class CharacterController
    {
        public static async Task<Hero> GetCharacterById(int id)
        {
            try
            {
                var response = await App.Api.GetCharacterById(id);

                if(response?.Data?.Results?.FirstOrDefault() is Character character)
                {
                    var hero = new Hero();
                    hero.ConvertHeroeFromCharacter(character);
                    return hero;
                }

                return null;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
