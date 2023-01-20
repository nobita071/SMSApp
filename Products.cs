using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp
{
    internal class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public object this[int index]
        {
            set
            {
                if (index == 0)
                    this.Id = Convert.ToInt32(value);
                else if (index == 1)
                    this.Title = Convert.ToString(value);
                else if (index == 2)
                    this.Price = Convert.ToDecimal(value);
                else if (index == 3)
                    this.Image = Convert.ToString(value);
                else
                    throw new Exception("Invalid index position");
            }
            get
            {
                if (index == 0)
                  return  this.Id;
                else if (index == 1)
                   return this.Title;
                else if (index == 2)
                  return  this.Price;
                else if (index == 3)
                   return this.Image ;
                else
                    throw new Exception("Invalid index position");
            }
        }

        public object this[string key]
        {
            set
            {
                if (key.ToLower() == "id")
                    this.Id = Convert.ToInt32(value);
                else if (key.ToLower() == "title")
                    this.Title = Convert.ToString(value);
                else if (key.ToLower() == "price")
                    this.Price = Convert.ToDecimal(value);
                else if (key.ToLower() == "image")
                    this.Image = Convert.ToString(value);
                else
                    throw new Exception("Invalid index position");
            }
            get
            {
                if (key.ToLower() == "id")
                    return this.Id;
                else if (key.ToLower() == "title")
                    return this.Title;
                else if (key.ToLower() == "price")
                    return this.Price;
                else if (key.ToLower() == "image")
                    return this.Image;
                else
                    throw new Exception("Invalid index position");
            }
        }
    }
}
