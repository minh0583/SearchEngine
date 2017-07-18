using System;
using EngineConfiguration;
using SolrConsole.Components;
using SolrConsole.Interface;
using SolrConsole.Models;

namespace SolrConsole
{
    public static class Program
    {
        private static readonly SearchEngineSetting Settings = SearchEngineSetting.Settings;

        private static ISearchEngine<Person> engine;

        private static void Main()
        {
            if (Settings.IsEnabled)
            {
                if (Settings.EngineType == EngineType.ApacheSolr)
                {
                    SearchSolrPerson();
                }
                else if (Settings.EngineType == EngineType.ElasticSearch)
                {
                    SearchElasticPerson();
                }
            }
            else
            {
                Console.WriteLine("Need to enable search engine. changed from minhnguyen branches.");
                Console.ReadLine();
            }
        }

        private static void SearchElasticPerson()
        {
            engine = new ElasticSearchEngine<Person>();
            engine.InitEngine(Settings.ConnectionUrl);

            var personResults = engine.SearchData("*:*");

            foreach (var personResult in personResults)
            {
                Console.WriteLine(personResult.Name);
            }

            Console.Read();
        }

        private static void SearchSolrPerson()
        {
            engine = new ApacheSolrEngine<Person>();
            engine.InitEngine(Settings.ConnectionUrl);

            var personResults = engine.SearchData("*:*");

            foreach (var personResult in personResults)
            {
                Console.WriteLine(personResult.Name);
            }

            Console.Read();
        }
    }
}
