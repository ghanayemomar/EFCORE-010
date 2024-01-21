using EFCORE_10.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_010.Entites
{
    public abstract class Quiz
    {
        public int id { get; set; }
        public object? Id { get; internal set; }
        public string Title { get; set; }
        public Course Course { get; set; }
    }
    public class MultipleChoiceQuiz : Quiz
    {
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public char CorrectAnswer { get; set; }
    }
    public class TrueAndFalseQuiz : Quiz
    {
        public bool CorrectAnswer { get; set; }
    }
}
