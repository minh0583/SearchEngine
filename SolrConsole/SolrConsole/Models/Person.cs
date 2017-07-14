using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolrConsole.Models
{
    using SolrNet.Attributes;

    public class Person
    {
        [SolrUniqueKey("id")]
        public Guid ID { get; set; }

        [SolrField("Name_s")]
        public string Name { get; set; }

        [SolrField("FirstName_s")]
        public string FirstName { get; set; }
    }
}
