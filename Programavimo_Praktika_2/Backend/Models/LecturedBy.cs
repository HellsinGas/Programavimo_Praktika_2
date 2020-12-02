using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programavimo_Praktika_2.Backend.Models
{
    public class LecturedBy
    {

        public int Id { get; set; }
        public int LectureId{ get; set; }
        public int UserId { get; set; }

       
        public LecturedBy(int id, int lectureid , int userId)
        {
            Id = id;
            LectureId = lectureid;
            UserId = userId;
        }
    }
}
