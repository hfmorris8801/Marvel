using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Marvel.Utils
{
    public static class Validator
    {
        public static bool IsInt(string value, out int number, ObservableCollection<string> error)
        {
            if(int.TryParse(value, out number))
            {
                return true;
            }
            else
            {
                error.Add("This integer is not a valid number.");
                return false;
            }
        }
    }
}
