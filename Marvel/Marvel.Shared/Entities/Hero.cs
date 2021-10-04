using Marvel.ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Comics { get; set; }

        public void ConvertHeroeFromCharacter(Character character)
        {
           Name = character.Name;
           Description = character.Description;
           Image = character.Image?.Path;
           Comics = character.Comics.Available;
        }
    }
}
