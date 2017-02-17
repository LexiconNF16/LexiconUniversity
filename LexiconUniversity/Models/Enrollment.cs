using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class Enrollment
    {
        public int Id { get; set; }        
        public Grade? Grade { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        // Navigation property
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

    public enum Grade
    {
        A, B, C, F
    }
}