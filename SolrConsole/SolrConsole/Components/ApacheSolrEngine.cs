using System;
using System.Collections.Generic;
using EngineConfiguration;
using Microsoft.Practices.ServiceLocation;
using SolrConsole.Interface;
using SolrConsole.Models;
using SolrNet;

namespace SolrConsole.Components
{
    public class ApacheSolrEngine<T> : ISearchEngine<T>
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void InitEngine(string connectionUrl)
        {
            Startup.Init<Person>($"{connectionUrl}/f16e4a2b-73f0-4720-93b1-2516942a333f_Persons");
        }

        public List<T> SearchData(string criteria)
        {
            var results = new List<T>();
            ISolrOperations<T> solr = ServiceLocator.Current.GetInstance<ISolrOperations<T>>();
            SolrQueryResults<T> queryResults = solr.Query(new SolrQuery(criteria));
            foreach (T queryResult in queryResults)
            {
                results.Add(queryResult);
            }

            return results;
        }
    }
}
