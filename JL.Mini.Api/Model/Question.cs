using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JL.Mini.Api.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int Time { get; set; }
        public int Points { get; set; }
        public string Stage { get; set; }
        public string Section { get; set; }

    }
}
