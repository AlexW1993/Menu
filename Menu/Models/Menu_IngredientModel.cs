using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Models
{
    public class Menu_IngredientModel
    {
        private int _idMenu;
        private int _idIngredient;

        public int IdMenu
        {
            get => _idMenu;
            set => _idMenu = value;
        }

        public int IdIngredient
        {
            get => _idIngredient;
            set => _idIngredient = value;
        }
    }
}
