using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationRepository.Parameters
{
    public class ActorsDetailParameters
    {
        public long ActorId { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
