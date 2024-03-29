﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStepQuiz.Infrastructure.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsAgree { get; set; }
        public Room Room { get; set; } = null!;
    }
}
