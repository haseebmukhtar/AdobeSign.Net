using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet.AdobeSign
{
    [DataContract]
    public class BaseUriInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string api_access_point { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string web_access_point { get; set; }
    }
}
