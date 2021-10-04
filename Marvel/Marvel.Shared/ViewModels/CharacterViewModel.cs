using Marvel.Commands;
using Marvel.Controller;
using Marvel.Entities;
using Marvel.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace Marvel.VM
{
    public class CharacterViewModel : ViewModelBase
    {
        private Hero _hero;
        public Hero Hero
        {
            get { return _hero; }
            set
            {
                if (_hero != value)
                {
                    _hero = value;
                    OnPropertyChanged("Hero");
                }
            }
        }
        
        private string _characterId;
        public string CharacterId
        {
            get { return _characterId; }
            set
            {
                if (_characterId != value)
                {
                    _characterId = value;
                    OnPropertyChanged("CharacterId");
                } 
            }
        }

        public ICommand ExecuteSearch { get; set; }
        public CharacterViewModel()
        {
            IsBusy = false;
            ExecuteSearch = new RelayCommand(searchAsync);
        }

        private async void searchAsync()
        {
            IsBusy = true;
            Hero = await CharacterController.GetCharacterById(int.Parse(CharacterId));
            IsBusy = false;
        }
    }
}
