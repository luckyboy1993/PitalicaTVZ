﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DALPitalicaTVZ.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public int Row { get; set; }
        public string Definition { get; set; }
        public Boolean Visibility { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
