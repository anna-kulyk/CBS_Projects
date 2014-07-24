using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5._3
{
    class Store
    {
        private Article[] walmart = new Article[3]
        {
            new Article("Blueberry", "Walmart", 3.48),
            new Article("Strawberry", "Walmart", 2.50),
            new Article("Cherry", "Walmart", 2.99)
        };

        public string this[int index]
        {
            get
            {
                if (index >= walmart.Length)
                {
                    return "Index is out of range";
                }
                return walmart[index].ToString();
            }
        }

        public string this[string name]
        {
            get
            {
                foreach (var item in walmart)
                {
                    if (item.ArticleName == name)
                    {
                        return item.ToString();
                    }
                }
                return string.Format("There is no {0} in the store", name);
            }
        }
    }
}
