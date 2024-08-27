using Menu.BD;
using Menu.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.ViewModels
{
    internal class MenuViewModel : ViewModelBase
    {
        private readonly Bd bd;
        private ObservableCollection<MenuModel> _menus;
        private MenuModel _menu;

        public MenuViewModel() 
        { 
            bd = new Bd();
            _menu = new MenuModel();
            _menus = bd.Get();
        }

        public MenuModel Menu
        {
            get => _menu;
            set 
            {
                if(_menu != value)
                {
                    _menu = value;
                    OnPropertyChanged(nameof(Menu));
                }
            }
        }

        public ObservableCollection<MenuModel> Menus
        {
            get => _menus;
            set
            {
                if(_menus != value)
                {
                    _menus = value;
                    OnPropertyChanged(nameof(Menus));
                }
            }
        }
    }
}
