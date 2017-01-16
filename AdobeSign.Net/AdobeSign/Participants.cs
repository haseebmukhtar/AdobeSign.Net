using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet.AdobeSign
{
    [DataContract]
    public class NextParticipantSetInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public List<NextParticipantInfo> nextParticipantSetMemberInfos { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string nextParticipantSetName { get; set; }
    }

    [DataContract]
    public class NextParticipantInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string waitingSince { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }




    }

        

    [DataContract]
    public class ParticipantSetInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string participantSetId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<ParticipantInfo> participantSetMemberInfos { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> roles { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string participantSetName { get; set; }


        [DataMember(EmitDefaultValue = false)]
        public string privateMessage { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> securityOptions { get; set; }
        

        [DataMember(EmitDefaultValue = false)]
        public int signingOrder { get; set; }

       
    }


    [DataContract]
    public class ParticipantInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string participantId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<ParticipantSetInfo> alternateParticipants { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string company { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> securityOptions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string title { get; set; }
    }


}
