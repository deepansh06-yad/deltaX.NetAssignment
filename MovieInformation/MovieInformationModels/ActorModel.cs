using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationModels
{
    public class ActorModel
    {
        public long ActorId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
