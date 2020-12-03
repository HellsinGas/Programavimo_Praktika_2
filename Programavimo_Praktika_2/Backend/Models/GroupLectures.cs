using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programavimo_Praktika_2.Backend.Models
{
    class GroupLectures
    {
        public int Id { get; private set; }
        public int LectureID { get; private set; }
        public int GroupID { get; private set; }

        public GroupLectures(int id, int lectureid, int groupid)
        {
            Id = id;
            LectureID = lectureid;
            GroupID = groupid;
        }
    }
}
