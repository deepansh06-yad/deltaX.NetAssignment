using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationRepository.Parameters
{
    public class ProducerDetailParameters
    {
        public long ProducerId { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string ProductionHouse { get; set; }
    }
}
