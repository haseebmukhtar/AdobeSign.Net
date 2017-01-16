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
    
Version History 
