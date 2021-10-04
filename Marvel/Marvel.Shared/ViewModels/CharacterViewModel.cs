using Marvel.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace Marvel.VM
{
    public class CharacterViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                } 
            }
        }   
        
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                } 
            }
        }  
        
        private int _comicNumber;
        public int ComicNumber
        {
            get { return _comicNumber; }
            set
            {
                if (_comicNumber != value)
                {
                    _comicNumber = value;
                    OnPropertyChanged("ComicNumber");
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
            ExecuteSearch = new RelayCommand(search);
        }

        private void search()
        {
            IsBusy = true;
            //Thread.Sleep(5000);
            for (int i = 0; i < 1000000; i++)
            {

            }
            Name = "Hulk";
            IsBusy = false;
        }
    }
}
