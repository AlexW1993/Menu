using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Models
{
    public class MenuModel
    {
        private string _id;
        private string _name;
        private bool _isBreakfast;
        private bool _isLunch;
        private bool _isDinner;
        private bool _isSnack;
        private bool _isOther;

        public string Id
        {
            get => _id;

            set => _id = value;
        }

        public string Name
        {
            get => _name;

            set => _name = value;
        }

        public bool IsBreakfast
        {
            get => _isBreakfast;

            set => _isBreakfast = value;
        }

        public bool IsLunch
        {
            get => _isLunch;

            set => _isLunch = value;
        }

        public bool IsDinner
        {
            get => _isDinner;

            set => _isDinner = value;
        }

        public bool IsSnack
        {
            get => _isSnack;

            set => _isSnack = value;
        }

        public bool IsOther
        {
            get => _isOther;

            set => _isOther = value;
        }

    }
}
