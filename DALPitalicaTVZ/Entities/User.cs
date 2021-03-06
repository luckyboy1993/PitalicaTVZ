﻿using PitalicaTVZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DALPitalicaTVZ.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Exam> ExamsCreated { get; set; }
        public virtual ICollection<UserExamTaken> ExamsTaken { get; set; }
    }
}
