using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet.AdobeSign
{
    [DataContract]
    public class AccessToken
    {
        [DataMember(EmitDefaultValue = false)]
        public string token_type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string access_token { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string refresh_token { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string expires_in { get; set; }


    }
}
