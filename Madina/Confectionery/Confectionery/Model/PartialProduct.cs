using System;

namespace Confectionery.Model
{
    public partial class Product
    {
        public string GetPucture
        {
            get
            {
                return Environment.CurrentDirectory + @"\" + photo;
            }
            set
            {
                photo = value;
            }
        }

        public string GetProduct
        {
            get
            {
                return $"Наименование - {title}, Цена - {price} руб., Вес - {weight} г.";
            }
        }
    }
}
