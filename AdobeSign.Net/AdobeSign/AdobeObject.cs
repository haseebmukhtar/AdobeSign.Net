using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet
{
    public class AdobeObject
    {
        private RestAPI API;
        public AdobeObject(RestAPI api)
        {
            API = api;
        }

        public async Task<AdobeSign.BaseUriInfo> GetBaseURI()
        {
            string json = await API.GetRestJson("/base_uris");
            return API.DeserializeJSon<AdobeSign.BaseUriInfo>(json);
        }


        #region Agreements
        public async Task<AdobeSign.UserAgreements> GetAgreements()
        {
            string json = await API.GetRestJson("/agreements");            
            return API.DeserializeJSon<AdobeSign.UserAgreements>(json);
        }

        public async Task<AdobeSign.AgreementInfo> GetAgreement(string agreementID)
        {
            var endpoint = string.Format("/agreements/{0}", agreementID);
            string json = await API.GetRestJson(endpoint);
            return API.DeserializeJSon<AdobeSign.AgreementInfo>(json);
        }

        public async Task<byte[]> GetAgreementCombinedDocument(string agreementID)
        {
            var endpoint = string.Format("/agreements/{0}/combinedDocument", agreementID);
            return await API.GetRestBytes(endpoint);
        }


        public async Task<AdobeSign.AgreementCreationResponse> CreateAgreement(AdobeSign.AgreementCreationInfo agreementCreationInfo)
        {
            var jsonContent = API.SerializeJSon<AdobeSign.AgreementCreationInfo>(agreementCreationInfo);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            
            string json = await API.PostRest("/agreements", byteContent);
            return API.DeserializeJSon<AdobeSign.AgreementCreationResponse>(json);
            
        }

        public async Task<AdobeSign.TransientDocumentResponse> AddDocument(string fileName, byte[] fileData)
        {
            var content = new MultipartFormDataContent();
            HttpContent fileContent = new ByteArrayContent(fileData);            
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "File",
                FileName = fileName
            };

            content.Add(fileContent);

            string json = await API.PostRest("/transientDocuments", content);            
            return API.DeserializeJSon<AdobeSign.TransientDocumentResponse>(json);
                        
        }
        

        #endregion Agreements


        #region STATIC METHODS


        public static async Task<AdobeSign.AccessToken> GetAccessToken(string apiURL, string authorization_code, string clientid, string client_secret, string redirectURL, string grant_type = "authorization_code")
        {
            RestAPI API = new RestAPI(apiURL, "");

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("code", authorization_code);
            parameters.Add("client_id", clientid);
            parameters.Add("client_secret", client_secret);
            parameters.Add("redirect_uri", redirectURL);
            parameters.Add("grant_type", grant_type);

            FormUrlEncodedContent encodedContent = new FormUrlEncodedContent(parameters);           

            string json = await API.PostRest("/oauth/token", encodedContent, "application/x-www-form-urlencoded");
            return API.DeserializeJSon<AdobeSign.AccessToken>(json);
        }


        #endregion STATIC METHODS




    }
}
