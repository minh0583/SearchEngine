using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolrConsole.Interface
{
    public interface ISearchEngine<T> : IDisposable
    {
        void InitEngine(string connectionUrl);

        List<T> SearchData(string criteria);
    }
}
