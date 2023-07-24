using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStepQuiz.Infrastructure.Entities
{
    public class Questions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Game Game { get; set; } = null!;
    }
}
