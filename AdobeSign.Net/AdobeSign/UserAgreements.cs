using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet.AdobeSign
{
    [DataContract]
    public class UserAgreements
    {
        [DataMember]
        public List<UserAgreement> userAgreementList { get; set; }
    }

    [DataContract]
    public class UserAgreement
    {
        [DataMember(EmitDefaultValue = false)]
        public string agreementId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string displayDate { get; set; }

        [DataMember]
        public List<DisplayUserSetInfo> displayUserSetInfos { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool esign { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string latestVersionId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string status { get; set; }

    }

    [DataContract]
    public class DisplayUserSetInfo
    {
        [DataMember]
        public List<DisplayUserInfo> displayUserSetMemberInfos { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string displayUserSetName { get; set; }
    }

    [DataContract]
    public class DisplayUserInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string company { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string fullName { get; set; }
    }
}
