using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationModels
{
    public class ProducerModel
    {
        public long ProducerId { get; set; }
        public string ProduceName { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string ProductionHouseName { get; set; }
    }
}
