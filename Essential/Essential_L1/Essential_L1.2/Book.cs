using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._2
{
    class Book
    {
        Title _title = new Title();
        Author _author = new Author();
        Content _content = new Content();

        public void ShowBook()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }

    }
}
