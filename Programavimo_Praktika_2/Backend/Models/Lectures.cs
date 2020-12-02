using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programavimo_Praktika_2.Backend.Models
{
   public class Lectures
    {

        public int Id { get;  set; }
        public string LectureName { get;  set; }
        public string Description { get;  set; }

        public Lectures()
        {

        }
        public Lectures(int id, string lecturename, string description)
        {
            Id = id;
            LectureName = lecturename;
            Description = description;
        }
    }
}
