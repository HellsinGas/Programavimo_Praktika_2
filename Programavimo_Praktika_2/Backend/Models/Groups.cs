using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programavimo_Praktika_2.Backend.Models
{
    public class Groups
    {
        public int Id { get; private set; }
        public string GroupName { get; private set; }

        public Groups (int id , string groupname)
        {
            Id = id;
            GroupName = groupname;
        }

    }
}
