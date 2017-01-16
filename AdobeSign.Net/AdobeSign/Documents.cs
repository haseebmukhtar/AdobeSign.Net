using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet.AdobeSign
{
    [DataContract]
    public class DocumentHistoryEvent
    {
        [DataMember(EmitDefaultValue = false)]
        public string actingUserEmail { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string actingUserIpAddress { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string participantEmail { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string versionId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string comment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DeviceLocation deviceLocation { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string synchronizationId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string vaultEventId { get; set; }

    }


    [DataContract]
    public class DocumentCreationInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public List<FileInfo> fileInfos { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<RecipientSetInfo> recipientSetInfos { get; set; }

        public SignatureTypeEnum signatureType { get; set; }

        [DataMember(Name = "signatureType")]
        public string signatureTypeString
        {
            get { return signatureType.ToString(); }
            set
            {
                SignatureTypeEnum g;
                this.signatureType = Enum.TryParse(value, true, out g) ? g : SignatureTypeEnum.ESIGN;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string callbackInfo { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> ccs { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int daysUntilSigningDeadline { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ExternalId externalId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<FormFieldLayerTemplate> formFieldLayerTemplates { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<FormField> formFields { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string locale { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<MergeFieldInfo> mergeFieldInfo { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string message { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PostSignOptions postSignOptions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string reminderFrequency { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public SecurityOptions securityOptions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string signatureFlow { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public VaultingInfo vaultingInfo { get; set; }

        public DocumentCreationInfo()
        {
            //fileInfos = new List<AdobeSign.FileInfo>();
            //recipientSetInfos = new List<RecipientSetInfo>();
            //ccs = new List<string>();
            //externalId = new ExternalId();
            //formFieldLayerTemplates = new List<FormFieldLayerTemplate>();
            //formFields = new List<FormField>();
            //mergeFieldInfo = new List<MergeFieldInfo>();
            //postSignOptions = new PostSignOptions();
            //securityOptions = new SecurityOptions();
            //vaultingInfo = new VaultingInfo();
        }
    }



    [DataContract]
    public class DocumentURL
    {
        [DataMember(EmitDefaultValue = false)]
        public string mimeType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string url { get; set; }
    }

    [DataContract]
    public class DeviceLocation
    {
        [DataMember(EmitDefaultValue = false)]
        public float latitude { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public float longitude { get; set; }

    }


   

    [DataContract]
    public class FileInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public DocumentURL documentURL { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string libraryDocumentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string libraryDocumentName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string transientDocumentId { get; set; }

        public FileInfo(string _transientDocumentId = "")
        {
            transientDocumentId = _transientDocumentId;
        }
    }




    [DataContract]
    public enum SignatureTypeEnum
    {
        [EnumMemberAttribute(Value = "ESIGN")]
        ESIGN,

        [EnumMemberAttribute(Value = "WRITTEN")]
        WRITTEN,
    }


}
