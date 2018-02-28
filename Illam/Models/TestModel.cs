using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Illam.Models
{
    public class TestModel
    {
        public string RightImage { get; set; }

        public string WrongImage { get; set; }

        public List<QuestionModel> Questions { get; set; }
    }
}