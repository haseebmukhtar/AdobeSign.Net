# AdobeSign.Net
AdobeSign.Net is a .NET library for calling AdobeSign REST API v5 in Windows 10 APP, Windows Phone APP, Windows Desktop APP and ASP.NET Web application.

Visit REST API website https://secure.na1.echosign.com/public/docs/restapi/v5

C# library to call Adobe Sign (Echo Sign) REST API

Usage

    var ApiURL = "https://api.eu1.echosign.com/api/rest/v5/";
    var accessToken = "";

    AdobeSignNet.RestAPI api = new AdobeSignNet.RestAPI(ApiURL, accessToken);
    AdobeSignNet.AdobeObject obj = new AdobeSignNet.AdobeObject(api);
    var agreements = await obj.GetAgreements();
    
Usage to send document for signing

    public async Task<AdobeSignNet.AdobeSign.AgreementCreationResponse> SendDocument(string APIURL, string Access_Token, string fullFilePath, string agreementName, string recipientEmail)
    {
                try
                {
                    //APIURL - FUll URL address, including "api/rest/v5/". e.g. https://api.eu1.echosign.com/api/rest/v5/                

                    AdobeSignNet.RestAPI api = new AdobeSignNet.RestAPI(APIURL, Access_Token);
                    AdobeSignNet.AdobeObject obj = new AdobeSignNet.AdobeObject(api);


                    //Create trasient document
                    var fileData = System.IO.File.ReadAllBytes(fullFilePath);
                    var transientDocumentResponse = await obj.AddDocument("MyFileName", fileData);


                    AdobeSignNet.AdobeSign.AgreementCreationInfo creationInfo = new AdobeSignNet.AdobeSign.AgreementCreationInfo();
                    creationInfo.documentCreationInfo = new AdobeSignNet.AdobeSign.DocumentCreationInfo();

                    //Document Creation Info
                    var documentCreationInfo = creationInfo.documentCreationInfo;
                    documentCreationInfo.name = agreementName;
                    documentCreationInfo.signatureType = AdobeSignNet.AdobeSign.SignatureTypeEnum.ESIGN;
                    documentCreationInfo.signatureFlow = "";

                    //FileInfo
                    documentCreationInfo.fileInfos = new List<AdobeSignNet.AdobeSign.FileInfo>();
                    var fileInfos = documentCreationInfo.fileInfos;
                    AdobeSignNet.AdobeSign.FileInfo fileInfo = new AdobeSignNet.AdobeSign.FileInfo(transientDocumentResponse.transientDocumentId);
                    fileInfos.Add(fileInfo);

                    //RecipientSetInfo
                    documentCreationInfo.recipientSetInfos = new List<AdobeSignNet.AdobeSign.RecipientSetInfo>();
                    var recipientSetInfos = documentCreationInfo.recipientSetInfos;

                    AdobeSignNet.AdobeSign.RecipientSetInfo recipientSetInfo = new AdobeSignNet.AdobeSign.RecipientSetInfo();
                    recipientSetInfo.recipientSetRole = AdobeSignNet.AdobeSign.RecipientRoleEnum.SIGNER;
                    recipientSetInfo.signingOrder = 1;

                    //RecipientSetMemberInfohttps://www.adobe.io/apis/documentcloud/sign/docs/step-by-step-guide/get-the-access-token.html
                    AdobeSignNet.AdobeSign.RecipientSetMemberInfo setMemberInfo = new AdobeSignNet.AdobeSign.RecipientSetMemberInfo();
                    setMemberInfo.email = recipientEmail;

                    recipientSetInfo.recipientSetMemberInfos.Add(setMemberInfo);

                    recipientSetInfos.Add(recipientSetInfo);


                    var agreementCreationResponse = await obj.CreateAgreement(creationInfo);

                    return agreementCreationResponse;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    
Version History 

How to get the access token.
https://www.adobe.io/apis/documentcloud/sign/docs/step-by-step-guide/get-the-access-token.html

