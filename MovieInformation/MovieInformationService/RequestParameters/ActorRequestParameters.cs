using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationService.RequestParameters
{
    public class ActorRequestParameters
    {
        public long ActorId { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
