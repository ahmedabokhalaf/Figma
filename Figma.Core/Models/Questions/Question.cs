using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figma.Core.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string QuestionFormula { get; set; } = string.Empty;
    }
}
