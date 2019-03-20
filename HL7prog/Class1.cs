using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7prog
{
    class MSH
    {
        public string sendingApplication { get; set; }
        public string sendingFacility { get; set; }
        public string receivingFacility { get; set; }
        public DateTime dateTime { get; set; }
        public string messageType { get; set; }
        public string messageID { get; set; }
        public string processingID { get; set; }
        public string encodingCharacters { get; set; }

        public override string ToString()
        {
            return $"{encodingCharacters},{sendingFacility},{receivingFacility},{dateTime},{messageType},{messageID},{processingID},{sendingApplication}";
        }
    }
}
