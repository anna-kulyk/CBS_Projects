using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._2
{
    class Book
    {
        private Title _title = new Title();
        private Author _author = new Author();
        private Content _content = new Content();

        public string BookTitle
        {
           set 
            {
                _title.Text = value;
            }
        }

        public string BookAuthor
        {
            set
            {
                _author.Text = value;
            }
        }

        public string BookContent
        {
            set
            {
                _content.Text = value;
            }
        }

        public void ShowBook()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }

    }
}
