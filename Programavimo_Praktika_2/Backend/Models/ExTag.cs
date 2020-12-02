using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programavimo_Praktika_2.Backend.Models
{
    public class ExTag
    {
        public Dictionary<string, object> TagDictionary { get; set; }

        public ExTag()//Cunstractor
        {
            this.TagDictionary = new Dictionary<string, object>();
        }

        public void Add(string key, object value)
        {
            this.TagDictionary.Add(key, value);
        }

        public object Get(string key)
        {
            return this.TagDictionary[key];
        }
    }
}
