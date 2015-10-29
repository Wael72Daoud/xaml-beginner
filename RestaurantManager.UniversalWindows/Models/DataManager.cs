using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.UniversalWindows.Models
{
    class DataManager
    {

        public ObservableCollection<string> OrderItems { set; get; }
        public List<string> MenueItems { set; get; }
        public List<string> CurrentlySelectedMenuItems { set; get; }

        public DataManager()
        {

            this.OrderItems = new ObservableCollection<string>(
                new List<string>
                {
                    "Steak, Chicken, Peas",
                    "Rice, Chicken",
                    "Hummus, Pita"
                }
                );

            this.MenueItems = new List<string>(
                new List<string>
                {
                    "Steak",
                    "Chicken",
                    "Peas",
                    "Rice",
                    "Humus",
                    "Pita"
                   
                }
                );

            this.CurrentlySelectedMenuItems = new List<string>(
                new List<string>
                {
                    "Rice",
                    "Pita"


                });
        }
    }
}
