using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5._3
{
    class Article
    {
        public Article() { }

        public Article(string articleName, string articleStore, double articlePrice)
        {
            ArticleName = articleName;
            ArticleStore = articleStore;
            ArticlePrice = articlePrice;
        }

        public string ArticleName { get; set; }
        public string ArticleStore { get; set; }
        public double ArticlePrice { get; set; }

        public override string ToString()
        {
            return string.Format("Article: {1}{0}Store: {2}{0}Price: {3:N}$", Environment.NewLine, ArticleName, ArticleStore, ArticlePrice);
        }

    }
}
