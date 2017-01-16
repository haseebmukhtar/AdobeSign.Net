using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet.AdobeSign
{
    class Recipients
    {
    }

    [DataContract]
    public class RecipientSetInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public List<RecipientSetMemberInfo> recipientSetMemberInfos { get; set; }

        
        public RecipientRoleEnum recipientSetRole { get; set; }

        [DataMember(Name = "recipientSetRole")]
        public string recipientSetRoleString
        {
            get { return recipientSetRole.ToString(); }
            set
            {
                RecipientRoleEnum g;
                this.recipientSetRole = Enum.TryParse(value, true, out g) ? g : RecipientRoleEnum.SIGNER;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string privateMessage { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string recipientSetName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<SecurityOption> securityOptions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int signingOrder { get; set; }

        public RecipientSetInfo()
        {
            recipientSetMemberInfos = new List<RecipientSetMemberInfo>();            
        }
    }

    [DataContract]
    public class RecipientSetMemberInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string fax { get; set; }
        public List<SecurityOption> securityOptions { get; set; }
    }



    public enum RecipientRoleEnum
    {

        /// <remarks/>
        SIGNER,

        /// <remarks/>
        APPROVER,
    }


}
