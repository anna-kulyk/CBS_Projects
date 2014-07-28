using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L7
{
    struct Notebook
    {
        private string _model, _producer;
        private double _price;

        public Notebook(string model, string producer, double price)
        {
            _model = model;
            _producer = producer;
            _price = Math.Abs(price);
        }

        public string Model { get { return _model; } }
        public string Producer { get { return _producer; } }
        public double Price { get { return _price; } }

        public void ShowNotebook()
        {
            Console.WriteLine("Model: {1}{0}Producer: {2}{0}Price: {3:N} $", Environment.NewLine, Model, Producer, Price);
        }
    }
}
