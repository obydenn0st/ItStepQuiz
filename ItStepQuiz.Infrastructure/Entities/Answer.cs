using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStepQuiz.Infrastructure.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsValid { get; set; }
        public Guid GameId { get; set; }
    }
}
