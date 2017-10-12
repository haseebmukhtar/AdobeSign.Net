using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet.AdobeSign
{
    class Agreement
    {
    }

    [DataContract]
    public class AgreementInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string agreementId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<DocumentHistoryEvent> events { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string latestVersionId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string locale { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool modifiable { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<NextParticipantSetInfo> nextParticipantSetInfos { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<ParticipantSetInfo> participantSetInfos { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool vaultingEnabled { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string expiration { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string message { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> securityOptions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string signatureType { get; set; }


    }

    [DataContract]
    public class AgreementCreationInfo
    {

        [DataMember(EmitDefaultValue = false)]
        public DocumentCreationInfo documentCreationInfo { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Options options { get; set; }


        public AgreementCreationInfo()
        {
            //documentCreationInfo = new AdobeSign.DocumentCreationInfo();
            //options = new AdobeSign.Options();
        }

    }


    [DataContract]
    public class PhoneInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string phone { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string countryCode { get; set; }
    }

    [DataContract]
    public class SecurityOption
    {
        [DataMember(EmitDefaultValue = false)]
        public string authenticationMethod { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<PhoneInfo> phoneInfos { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string password { get; set; }
    }



    [DataContract]
    public class ExternalId
    {
        [DataMember(EmitDefaultValue = false)]
        public string group { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string @namespace { get; set; }
    }



    [DataContract]
    public class FormFieldLayerTemplate
    {
        [DataMember(EmitDefaultValue = false)]
        public DocumentURL documentURL { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string libraryDocumentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string libraryDocumentName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string transientDocumentId { get; set; }
    }

    [DataContract]
    public class Location
    {
        [DataMember(EmitDefaultValue = false)]
        public int height { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int left { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string pageNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int top { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int width { get; set; }
    }

    [DataContract]
    public class Condition
    {
        [DataMember(EmitDefaultValue = false)]
        public string value { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string whenFieldLocationIndex { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string whenFieldName { get; set; }
    }

    [DataContract]
    public class FormField
    {
        [DataMember(EmitDefaultValue = false)]
        public List<Location> locations { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string alignment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string anyOrAll { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string backgroundColor { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string borderColor { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string borderStyle { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string borderWidth { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string calculatedExpression { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Condition> conditions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string contentType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string defaultValue { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string displayFormat { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string displayFormatType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string displayLabel { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string fontColor { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string fontName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string fontSize { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string format { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string formatData { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool hidden { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> hiddenOptions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string inputType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool masked { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string maskingText { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int maxLength { get; set; }
        public int maxNumberValue { get; set; }
        public int minLength { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int minNumberValue { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string radioCheckType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool readOnly { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int recipientIndex { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string regularExpression { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool required { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string showOrHide { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string specialErrMsg { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string specialFormula { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string tooltip { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> visibleOptions { get; set; }
    }

    [DataContract]
    public class MergeFieldInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public string defaultValue { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string fieldName { get; set; }
    }

    [DataContract]
    public class PostSignOptions
    {
        [DataMember(EmitDefaultValue = false)]
        public string redirectUrl { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int redirectDelay { get; set; }
    }

    [DataContract]
    public class SecurityOptions
    {
        [DataMember(EmitDefaultValue = false)]
        public string externalPassword { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string internalPassword { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string kbaProtection { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string openPassword { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string passwordProtection { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool protectOpen { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string webIdentityProtection { get; set; }
    }

    [DataContract]
    public class VaultingInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public bool enabled { get; set; }
    }

    [DataContract]
    public class FileUploadOptions
    {
        [DataMember(EmitDefaultValue = false)]
        public bool libraryDocument { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool localFile { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool webConnectors { get; set; }
    }

    [DataContract]
    public class SendThroughWebOptions
    {
        [DataMember(EmitDefaultValue = false)]
        public FileUploadOptions fileUploadOptions { get; set; }
    }

    [DataContract]
    public class Options
    {
        [DataMember(EmitDefaultValue = false)]
        public bool authoringRequested { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool autoLoginUser { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string locale { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool noChrome { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool sendThroughWeb { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public SendThroughWebOptions sendThroughWebOptions { get; set; }
    }

    [DataContract]
    public class AgreementCreationResponse
    {
        [DataMember(EmitDefaultValue = false)]
        public string agreementId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string embeddedCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string expiration { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string url { get; set; }

    }

  

}
