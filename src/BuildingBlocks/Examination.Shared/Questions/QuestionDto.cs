﻿using Examination.Dtos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Shared.Questions
{
    public class QuestionDto
    {
        public string Content { get; set; }
        public QuestionType QuestionType { get; set; }
        public Level Level { set; get; }
        public string CategoryId { get; set; }
        public IList<AnswerDto> Answers { set; get; }
        public string Explain { get; set; }
        public DateTime DateCreated { get; set; }
        public string OwnerUserId { get; set; }
    }
}
