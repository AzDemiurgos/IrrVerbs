using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace IrregularVerbs.src
{
    [DataContract]
    public class IrregularVerb
    {
        [DataMember]
        public int Raiting { get; set; }
        [DataMember]
        public String V1 { get; set; }
        [DataMember]
        public String V2 { get; set; }
        [DataMember]
        public String V3 { get; set; }
        [DataMember]
        public String Tr { get; set; }
        [DataMember]
        public String Sample { get; set; }

        IrregularVerb(String a_v1,String a_v2, String a_v3, String a_tr)
        {
            Raiting = 0;
            V1 = a_v1;
            V2 = a_v2;
            V3 = a_v3;
            Tr = a_tr;
        }
    }
}
