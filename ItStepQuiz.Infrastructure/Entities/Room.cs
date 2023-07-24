using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStepQuiz.Infrastructure.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Game Game { get; set; } = null!;
    }
}
