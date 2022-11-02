using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortik
{ //в данном классе передаю индекс, описание, цену и метод
    internal class ElementsofMenu
    {
        
        public ElementsofMenu(int el, string discription, int price, Action action)
        {
            this.EL = el;
            this.Discription = discription;
            this.Price = price;
            this.Action = action;
            
        }
        
        public int EL { get; set; }
        public string Discription { get; set; }
        public int Price { get; set; }
        public Action Action { get; set; }


    }
}
