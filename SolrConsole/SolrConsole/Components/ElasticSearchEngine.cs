using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using SolrConsole.Interface;

namespace SolrConsole.Components
{
    public class ElasticSearchEngine<T> : ISearchEngine<T>
    {
        private static ElasticClient client;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void InitEngine(string connectionUrl)
        {
            var node = new Uri(connectionUrl);
            var settings = new ConnectionSettings(node);
            settings.DefaultIndex("stackoverflow");
            client = new ElasticClient(settings);
        }

        public List<T> SearchData(string criteria)
        {
            throw new NotImplementedException();
        }

        public static ElasticClient Client => client;
    }
}
