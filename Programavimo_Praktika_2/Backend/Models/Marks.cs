using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programavimo_Praktika_2.Backend.Models
{
    class Marks
    {
        public int Id { get; private set; }
        public int LectureID { get; private set; }
        public int UserID { get; private set; }
        public int Mark { get; private set; }

        public Marks(int id, int lectureid , int userid , int mark)
        {
            Id = id;
            LectureID = lectureid;
            UserID = userid;
            Mark = mark;
        }
    }
}
