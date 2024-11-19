using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CreateMenuDto
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string DayWeek { get; set; }
        public int BreadId { get; set; }
        public int SaladId { get; set; }
        public int FirstDishesId { get; set; }
        public int GarnishId { get; set; }
        public int MeatDishesId { get; set; }
        public int DrinkcId { get; set; }
        public bool Archived { get; set; }






    }
}
