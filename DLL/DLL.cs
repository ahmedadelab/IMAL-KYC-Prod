﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Net;
using System.Net.NetworkInformation;
using System.Xml;
using System.Xml.Linq;
using static IMAL_KYC.DLL;

namespace IMAL_KYC
{
    public class DLL
    {

        //CIFList String

        string ScifBranchCode = string.Empty;
        string ScifNumber = string.Empty;
        string ScifType  = string.Empty;
        string ScifTypeBank = string.Empty;
        string ScifTypeDesc = string.Empty; 
        string Scountry = string.Empty;
        string ScreatedBy = string.Empty;
        string SdateCreated =   string.Empty;
        string SdateModified = string.Empty;
        string SecoSector = string.Empty;
        string SidNumber = string.Empty;
        string SlongNameArabic = string.Empty;
        string SlongNameEnglish = string.Empty;
        string SmobileNumber = string.Empty;
        string SmodifiedBy = string.Empty;
        string Ssexe = string.Empty;
        string SCIFstatus = string.Empty;
        string SCIFstatusCode = string.Empty;



        //CIFDetails

        string SDidNumber = string.Empty;
        string SDidType = string.Empty;
        string SDidTypeDescription = string.Empty;
        string SDCIFcifCategory = string.Empty;
        string SDCIFcifIsComplete = string.Empty;
        string SDCIFbusinessRisk = string.Empty;
        string SDCIFcifLimitCapDescription = string.Empty;
        string SDCIFcifRating = string.Empty;
        string SDCIFcifRatingDescription = string.Empty;
        string SDCIFcountryDescription = string.Empty;
        string SDCIFcountryOfBirth = string.Empty;
        string SDCIFeconomicSector  =   string.Empty;
        string SDCIFeconomicSectorDescription = string.Empty;
        string SDCIFkyc = string.Empty;
        string SDCIFlegalStatus = string.Empty;
        string SDCIFlegalStatusDescription = string.Empty;
        string SDCIFoccupation = string.Empty;
        string SDCIFoccupationDescription = string.Empty;
        string SDCIFprofession = string.Empty;
        string SDCIFranking = string.Empty;
        string SDCIFrankingDescription =string.Empty;
        string SDCIFresident = string.Empty;
        string SDCIFcifBranchCode = string.Empty;
        string SDCIFcifBranchDescription = string.Empty;
        string SDCIFcifType = string.Empty; 
        string SDCIFcifTypeDescription = string .Empty; 
        string SDCIFidDeliveryDate = string.Empty;  
        string SDCIFidExpiryDate = string.Empty;    
        string SDCIFjoinType = string.Empty;
        string SDCIFjointAccounts = string .Empty;
        string SDCIFlongNameArabic = string.Empty;
        string SDCIFlongNameEnglish = string.Empty;
        string SDCIFmaritalStatus = string .Empty;
        string SDCIFmodeOfStatementDelivery = string.Empty; 
        string SDCIFnationality = string .Empty;
        string SDCIFnationalityDescription=string.Empty;
        string SDCIFstatus = string.Empty;
        string SaddressEnglish = string.Empty;
        string SaddressArabic = string.Empty;
        string SareaDescription = string.Empty;
        string ScountryDescription = string.Empty;
        string SregionDescription = string.Empty;
        string Sgender = string.Empty;
        string SemployerCifName = string.Empty;
        string thirdNameEnglish = string.Empty;
        string thirdNameArabic = string.Empty;
        string lastNameArabic = string.Empty;
        string lastNameEnglish = string.Empty;
        string firstNameArabic = string.Empty;
        string firstNameEnglish = string.Empty;
        string secondNameArabic = string.Empty;
        string secondNameEnglish = string.Empty;
        string dateOfBirth = string.Empty;
        string country = string.Empty;
        string mobile = string .Empty;
        string email = string.Empty;
        string blockArabic = string.Empty;
        string block =string.Empty;
        string TaxIDNumber = string.Empty;
        string Director1 = string.Empty;
        string Director2 = string.Empty;    
        string Director3 = string.Empty;

        string Representative1Name = string.Empty;

        string Representative1ID =  string.Empty;

         string Representative1IDExpire = string.Empty;

        string Representative1NationalIDIssueDate = string.Empty;

        string Representative1NationalIDIssuePlace = string.Empty;


        string Representative1IDType = string.Empty;

        string Representative1Nationality = string.Empty;

        string Representative1Address = string.Empty;

        string Representative1Address2 = string.Empty;

        string Representative2Address2 = string.Empty;

        string Representative1Phone = string.Empty;

        string Representative2Name = string.Empty;

        string Representative2ID = string.Empty;

        string Representative2IDExpire = string.Empty;

        string Representative2NationalIDIssue = string.Empty;

        string Representative2IDType = string.Empty;

        string Representative2Nationality = string.Empty;

        string Representative2Address = string.Empty;

      

        string Representative2Phone = string.Empty;

        string Representative2NationalIDIssuePlace = string.Empty;

        string Representative2NationalIDIssueDate = string.Empty;

     


        DAL DalCode = new DAL();
        public class ResKYClist
        {

            public string? cifBranchCode { get; set; }

            public string? cifNumber { get; set; }



            public string? cifType { get; set; }
            public string? cifTypeBank { get; set; }

            public string? cifTypeDesc { get; set; }

            public string? country { get; set; }
            public string? createdBy { get; set; }
            public string? dateCreated { get; set; }
            public string? dateModified { get; set; }
            public string? ecoSector { get; set; }
            public string? idNumber { get; set; }

            public string? longNameArabic { get; set; }

            public string? longNameEnglish { get; set; }

            public string? mobileNumber { get; set; }

            public string? modifiedBy { get; set; }

            public string? sexe { get; set; }

    

            public string? statusCode { get; set; }

            public string? statusDesc { get; set; }

            public string? CIFstatus { get; set; }

            public string? CIFstatusCode { get; set; }




        }
    
   
        public static HttpWebRequest CreateWebRequestReturnCIfList()
        {

          
            var MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var URLMiniStatment = MyConfig.GetValue<string>("AppSettings:URLCIFList");

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(URLMiniStatment);
            webRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

    
        public string ReturnCIFList(string MobileNo, string idNumber, string username, string password, string requesterTimeStamp,string ChannelName)
        {
            List<log> logrequest = new List<log>();
    
            List<ResKYClist> datum = new List<ResKYClist>();
            string SstatusCode = "";
            string SstatusDesc = "";
            string remoteIP = "";
            string RequestID = "";
            if (MobileNo != null)
            {
                RequestID = "MW-KYCList-" + MobileNo + "-" + DateTime.Now.ToString("ddMMyyyyHHmmssff");
            }
            else
            {
                RequestID = "MW-KYCList-" + idNumber + "-" + DateTime.Now.ToString("ddMMyyyyHHmmssff");
            }
            try
            {
                HttpWebRequest request = CreateWebRequestReturnCIfList();
                XmlDocument soapEnvelopeXml = new XmlDocument();
                string status = CheckChannel(ChannelName, username, remoteIP, "CIFList");
            
                logrequest.Add(new log
                {

                    mobileNo = MobileNo,
                    idNumber = idNumber,
                    username = username,
                    password = "*******",
                    ChannelName = ChannelName
                });
                string ClientRequest = JsonConvert.SerializeObject(logrequest);
                DalCode.InsertLog("CIFList", Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")), ClientRequest, "Pending", ChannelName, RequestID);
                if (status == "Enabled")
                {
                    if (MobileNo != "")
                    {
                        if (MobileNo.Length >= 11)
                        {
                           
                            soapEnvelopeXml.LoadXml(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:cif=""cifManagementWs"">
   <soapenv:Header/>
   <soapenv:Body>
      <cif:returnCifList>
         <serviceContext>
            <businessArea>Retail</businessArea>
            <businessDomain>Products</businessDomain>
            <operationName>returnCifList</operationName>
            <serviceDomain>CifManagement</serviceDomain>
            <serviceID>1913</serviceID>
            <version>1.0</version>
         </serviceContext>
        <companyCode>1</companyCode>
         <mobileNumber>" + MobileNo + @"</mobileNumber>         
         <dynamicFilter>
            <allAny>All</allAny>
            <filters>        
            </filters>
         </dynamicFilter>     
         <requestContext>
            <requestID>" + RequestID + @"</requestID>
            <coreRequestTimeStamp>" + requesterTimeStamp + @"</coreRequestTimeStamp>
         </requestContext>
         <requesterContext>
            <channelID>1</channelID>
            <hashKey>1</hashKey>
              <langId>EN</langId>
            <password>" + password + @"</password>
            <requesterTimeStamp>" + requesterTimeStamp + @"</requesterTimeStamp>
            <userID>" + username + @"</userID>
         </requesterContext>
         <vendorContext>
            <license>Copyright 2018 Path Solutions. All Rights Reserved</license>
            <providerCompanyName>Path Solutions</providerCompanyName>
            <providerID>IMAL</providerID>
         </vendorContext>
      </cif:returnCifList>
   </soapenv:Body>
</soapenv:Envelope>"
                                             );
                        }
                        else
                        {
                            SstatusCode = "-988";

                            SstatusDesc = "Error Customer Mobile No";
                        }

                    }
                    else
                    {
                        if (idNumber != "")
                        {
                            if (idNumber.Length >= 14)
                            {
                            
                                soapEnvelopeXml.LoadXml(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:cif=""cifManagementWs"">
   <soapenv:Header/>
   <soapenv:Body>
      <cif:returnCifList>
         <serviceContext>
            <businessArea>Retail</businessArea>
            <businessDomain>Products</businessDomain>
            <operationName>returnCifList</operationName>
            <serviceDomain>CifManagement</serviceDomain>
            <serviceID>1913</serviceID>
            <version>1.0</version>
         </serviceContext>
        <companyCode>1</companyCode>
         <idNumber>" + idNumber + @"</idNumber>         
         <dynamicFilter>
            <allAny>All</allAny>
            <filters>        
            </filters>
         </dynamicFilter>     
         <requestContext>
            <requestID>" + RequestID + @"</requestID>
            <coreRequestTimeStamp>" + requesterTimeStamp + @"</coreRequestTimeStamp>
         </requestContext>
         <requesterContext>
            <channelID>1</channelID>
            <hashKey>1</hashKey>
              <langId>EN</langId>
            <password>" + password + @"</password>
            <requesterTimeStamp>" + requesterTimeStamp + @"</requesterTimeStamp>
            <userID>" + username + @"</userID>
         </requesterContext>
         <vendorContext>
            <license>Copyright 2018 Path Solutions. All Rights Reserved</license>
            <providerCompanyName>Path Solutions</providerCompanyName>
            <providerID>IMAL</providerID>
         </vendorContext>
      </cif:returnCifList>
   </soapenv:Body>
</soapenv:Envelope>"
                                                 );
                            }
                            else
                            {
                                SstatusCode = "-987";

                                SstatusDesc = "Error Customer ID No";
                            }
                        }
                    }
                    if (SstatusCode == "")
                    {
                        string soapResult = "";

                        using (Stream stream = request.GetRequestStream())
                        {
                            soapEnvelopeXml.Save(stream);
                        }
                        using (WebResponse response = request.GetResponse())
                        {
                            using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                            {
                                soapResult = rd.ReadToEnd();

                                var str = XElement.Parse(soapResult);
                                XmlDocument xmlDoc = new XmlDocument();
                                xmlDoc.LoadXml(soapResult);
                                XmlNodeList elementserviceResponse = xmlDoc.GetElementsByTagName("serviceResponse");
                                foreach (XmlNode elementserviceElement in elementserviceResponse)
                                {
                                    SstatusCode = elementserviceElement["statusCode"].InnerText;

                                    SstatusDesc = elementserviceElement["statusDesc"].InnerText;
                                }


                                if (SstatusCode == "0")
                                {

                                    XmlNodeList elemlistCiflist = xmlDoc.GetElementsByTagName("cifDC");
                                    if (xmlDoc.GetElementsByTagName("cifDC").Count == 1)
                                    {
                                        // Sciflist = elemlistCiflist[0].InnerXml;
                                        foreach (XmlNode node in elemlistCiflist)
                                        {
                                            if (node["cifBranchCode"] != null)
                                            {
                                                ScifBranchCode = node["cifBranchCode"].InnerText;
                                            }

                                            if (node["cifNumber"] != null)
                                            {
                                                ScifNumber = node["cifNumber"].InnerText;
                                            }
                                            if (node["cifType"] != null)
                                            {
                                                ScifType = node["cifType"].InnerText;
                                            }
                                            if (node["cifTypeBank"] != null)
                                            {
                                                ScifTypeBank = node["cifTypeBank"].InnerText;
                                            }
                                            if (node["cifTypeDesc"] != null)
                                            {
                                                ScifTypeDesc = node["cifTypeDesc"].InnerText;
                                            }
                                            if (node["country"] != null)
                                            {
                                                Scountry = node["country"].InnerText;
                                            }
                                            if (node["createdBy"] != null)
                                            {
                                                ScreatedBy = node["createdBy"].InnerText;
                                            }
                                            if (node["dateCreated"] != null)
                                            {
                                                SdateCreated = node["dateCreated"].InnerText;
                                            }
                                            if (node["dateModified"] != null)
                                            {
                                                SdateModified = node["dateModified"].InnerText;
                                            }
                                            if (node["ecoSector"] != null)
                                            {
                                                SecoSector = node["ecoSector"].InnerText;
                                            }
                                            if (node["idNumber"] != null)
                                            {
                                                SidNumber = node["idNumber"].InnerText;
                                            }
                                            if (node["longNameArabic"] != null)
                                            {
                                                SlongNameArabic = node["longNameArabic"].InnerText;
                                            }
                                            if (node["longNameEnglish"] != null)
                                            {
                                                SlongNameEnglish = node["longNameEnglish"].InnerText;
                                            }
                                            if (node["mobileNumber"] != null)
                                            {
                                                SmobileNumber = node["mobileNumber"].InnerText;
                                            }
                                            if (node["modifiedBy"] != null)
                                            {
                                                SmodifiedBy = node["modifiedBy"].InnerText;
                                            }
                                            if (node["sexe"] != null)
                                            {
                                                Ssexe = node["sexe"].InnerText;
                                            }
                                            if (node["status"] != null)
                                            {
                                                SCIFstatus = node["status"].InnerText;
                                            }
                                            if (node["status"] != null)
                                            {
                                                SCIFstatusCode = node["statusCode"].InnerText;
                                            }

                                        }
                                        CheckFields(ChannelName, "CIFList");
                                        datum.Add(new ResKYClist
                                        {
                                            cifBranchCode = ScifBranchCode,
                                            cifNumber = ScifNumber,
                                            cifType = ScifType,
                                            cifTypeBank = ScifTypeBank,
                                            cifTypeDesc = ScifTypeDesc,
                                            country = Scountry,
                                            createdBy = ScreatedBy,
                                            dateCreated = SdateCreated,
                                            dateModified = SdateModified,
                                            ecoSector = SecoSector,
                                            idNumber = SidNumber,
                                            longNameArabic = SlongNameArabic,
                                            longNameEnglish = SlongNameEnglish,
                                            mobileNumber = SmobileNumber,
                                            modifiedBy = SmodifiedBy,
                                            sexe = Ssexe,
                                            CIFstatus = SCIFstatus,
                                            CIFstatusCode = SCIFstatusCode,
                                            statusCode = SstatusCode,
                                            statusDesc = SstatusDesc
                                        });

                                    }
                                    else
                                    {
                                        SstatusCode = "-989";

                                        SstatusDesc = "Error Customer ID or Mobile No repated on more than CIF";
                                        datum.Add(new ResKYClist
                                        {

                                            statusCode = SstatusCode,
                                            statusDesc = SstatusDesc
                                        });
                                    }




                                }
                                else
                                {

                                    datum.Add(new ResKYClist
                                    {

                                        statusCode = SstatusCode,
                                        statusDesc = SstatusDesc
                                    });
                                }


                            }


                        }

                    }
                    else
                    {

                        datum.Add(new ResKYClist
                        {

                            statusCode = SstatusCode,
                            statusDesc = SstatusDesc
                        });
                    }
                }
                else
                {
                    SstatusCode = "-985";
                    SstatusDesc = "you are not authorize";
                    datum.Add(new ResKYClist
                    {

                        statusCode = SstatusCode,
                        statusDesc = SstatusDesc
                    });
                }
                string statuslog = "";
                if (SstatusCode == "0")
                {
                    statuslog = "Success";
                }
                else
                {
                    statuslog = "Failed";
                }
                DalCode.UpdateLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), JsonConvert.SerializeObject((datum)), statuslog, ChannelName, RequestID);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return JsonConvert.SerializeObject((datum));
        }
        public class RespCIFDTS
        {
            public string? CIFidNumber { get; set; }

            public string? CIFidType { get; set; }
            public string? CIFidTypeDescription { get; set; }
            public string? CIFcifCategory { get; set; }
            public string? CIFcifIsComplete { get; set; }

            public string? CIFbusinessRisk { get; set; }
            public string? CIFcifLimitCapDescription { get; set; }
            public string? CIFcifRating { get; set; }
            public string? CIFcifRatingDescription { get; set; }
            public string? CIFcountryDescription { get; set; }
            public string? CIFcountryOfBirth { get; set; }
   
            public string? CIFeconomicSector { get; set; }

            public string? CIFeconomicSectorDescription { get; set; }
            public string? CIFkyc { get; set; }
            public string? CIFlegalStatus { get; set; }
            public string? CIFlegalStatusDescription { get; set; }

            public string? CIFoccupation { get; set; }

            public string? CIFoccupationDescription { get; set; }
            public string? CIFprofession { get; set; }
            public string? CIFranking { get; set; }
            public string? CIFrankingDescription { get; set; }
            public string? CIFresident { get; set; }

            public string? CIFcifBranchCode { get; set; }
            public string? CIFcifBranchDescription { get; set; }
            public string? CIFcifType { get; set; }

            public string? CIFcifTypeDescription { get; set; }

            public string? CIFidDeliveryDate { get; set; }
            public string? CIFidExpiryDate { get; set; }
            public string? CIFjoinType { get; set; }
            public string? CIFjointAccounts { get; set; }

            public string? CIFlongNameArabic { get; set; }

            public string? CIFlongNameEnglish { get; set; }
            public string? CIFmaritalStatus { get; set; }

            public string? CIFmodeOfStatementDelivery { get; set; }

            public string? CIFnationality { get; set; }

            public string? CIFnationalityDescription { get; set; }


            public string? CIFstatus { get; set; }

            public string? addressEnglish { get; set; }

            public string? addressArabic { get;set; }

            public string? areaDescription { get; set; }

            public string? countryDescription { get; set; }

            public string? regionDescription { get; set; }

            public string? gender { get; set; }

            public string? statusCode { get; set; }
            public string? statusDesc { get; set; }

            public string? employerCifName { get; set; }

            public string? firstNameArabic { get; set; }

            public string? firstNameEnglish { get; set; }

            public string? lastNameArabic { get; set; }

            public string? lastNameEnglish { get; set; }

            public string? secondNameArabic { get; set; }

            public string? secondNameEnglish { get; set; }

            public string? thirdNameArabic { get; set; }

            public string? thirdNameEnglish { get; set; }

            public string? dateOfBirth { get; set; }

            public string? country { get; set; }

            public string? mobile { get; set; }

            public string? email { get; set; }

            public string? blockArabic { get; set; }

            public string? block { get; set; }

            public string? TaxIDNumber { get; set; }

            public string? Director1 { get; set; }

            public string? Director2 { get; set; }

            public string? Director3 { get; set; }

            public string? Representative1Name { get; set; }

            public string? Representative1ID { get; set; }

            public string? Representative1IDExpire { get; set; }

            public string? Representative1NationalIDIssuePlace { get; set; }

            public string? Representative1NationalIDIssueDate { get; set; }

            public string? Representative1IDType { get; set; }

            public string? Representative1Nationality { get; set; }

            public string? Representative1Address { get; set; }

            public string? Representative1Address2 { get; set; }

            public string? Representative1Phone { get; set; }

            public string? Representative2Name { get; set; }

            public string? Representative2ID { get; set; }

            public string? Representative2IDExpire { get; set; }

            public string? Representative2NationalIDIssuePlace { get; set; }

            public string? Representative2NationalIDIssueDate { get; set; }

            public string? Representative2IDType { get; set; }

            public string? Representative2Nationality { get; set; }

            public string? Representative2Address { get; set; }

            public string? Representative2Address2 { get; set; }
            public string? Representative2Phone { get; set; }

          public string? CIF { get; set; }

        }



            public class log
        {
            public string? mobileNo { get; set; }
            public string? idNumber { get; set; }
            public string? username { get; set; }
            public string? password { get; set; }



            public string? ChannelName { get; set; }

        }

        public class logCIFDetils
        {
            public string? mobileNo { get; set; }
            public string? idNumber { get; set; }
            public string? CIFNo { get; set; }
            public string? username { get; set; }
            public string? password { get; set; }
            public string? ChannelName { get; set; }

        }
        public string CheckStatus(string ServiceName, string GLNo)
        {

            string statusGL = "";
            string EnableGL = "";
            DataTable dt_GL = DalCode.IMALGLStatus(GLNo, ServiceName);
            DLL[] BR_GL = new DLL[dt_GL.Rows.Count];


            if (BR_GL.Length != 0)
            {
                int ii;
                for (ii = 0; ii < dt_GL.Rows.Count; ii++)
                {

                    EnableGL = dt_GL.Rows[ii]["EnableGL"].ToString().Trim();
                }
            }
            if (EnableGL == "1")
            {
                statusGL = "Enabled";
            }
            else
            {
                statusGL = "Disabled";
            }
            return statusGL;
        }
        public void CheckFields(string ChannelName, string @ServiceName)
        {
            string FieldStatus = "";
            string FieldName = "";
            DataTable dt_CheckFields = DalCode.IMALResponseField(ServiceName, ChannelName);
            DLL[] BR_CheckFields = new DLL[dt_CheckFields.Rows.Count];


            if (BR_CheckFields.Length != 0)
            {
                int ii;
                for (ii = 0; ii < dt_CheckFields.Rows.Count; ii++)
                {

                    FieldStatus = dt_CheckFields.Rows[ii]["FieldStatus"].ToString().Trim();
                    FieldName = dt_CheckFields.Rows[ii]["FieldName"].ToString().Trim();
                    if ((FieldStatus == "0") && (FieldName == "cifBranchCode"))
                    {
                        ScifBranchCode = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifNumber"))
                    {
                        ScifNumber = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifType"))
                    {
                        ScifType = "";
              
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifTypeBank"))
                    {
                        ScifTypeBank = "";
                   
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifTypeDesc"))
                    {
                        ScifTypeDesc = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "country"))
                    {
                        Scountry = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "createdBy"))
                    {
                        ScreatedBy = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "dateCreated"))
                    {
                        SdateCreated = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "dateModified"))
                    {
                        SdateModified = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "ecoSector"))
                    {
                        SecoSector = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "idNumber"))
                    {
                        SidNumber = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "longNameArabic"))
                    {
                        SlongNameArabic = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "longNameEnglish"))
                    {
                        SlongNameEnglish = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "mobileNumber"))
                    {
                        SmobileNumber = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "modifiedBy"))
                    {
                        SmodifiedBy = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "sexe"))
                    {
                        Ssexe = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "CIFstatus"))
                    {
                        SCIFstatus = "";

                    }
                    if ((FieldStatus == "0") && (FieldName == "CIFstatusCode"))
                    {
                        SCIFstatusCode = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "idNumber"))
                    {
                        SDidNumber = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "idType"))
                    {
                        SDidType = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "idTypeDescription"))
                    {
                        SDidTypeDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifCategory"))
                    {
                        SDCIFcifCategory = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifIsComplete"))
                    {
                        SDCIFcifIsComplete = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "businessRisk"))
                    {
                        SDCIFbusinessRisk = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifLimitCapDescription"))
                    {
                        SDCIFcifLimitCapDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifRating"))
                    {
                        SDCIFcifRating = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifRatingDescription"))
                    {
                        SDCIFcifRatingDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "countryDescription"))
                    {
                        SDCIFcountryDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "countryOfBirth"))
                    {
                        SDCIFcountryOfBirth = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "economicSector"))
                    {
                        SDCIFeconomicSector = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "economicSectorDescription"))
                    {
                        SDCIFeconomicSectorDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "kyc"))
                    {
                        SDCIFkyc = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "legalStatus"))
                    {
                        SDCIFlegalStatus = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "legalStatusDescription"))
                    {
                        SDCIFlegalStatusDescription = "";
                    }
                    if ((FieldStatus == "0") && (FieldName == "occupation"))
                    {
                        SDCIFoccupation = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "occupationDescription"))
                    {
                        SDCIFoccupationDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "profession"))
                    {
                        SDCIFprofession = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "ranking"))
                    {
                        SDCIFranking = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "rankingDescription"))
                    {
                        SDCIFrankingDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "resident"))
                    {
                        SDCIFresident = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifBranchCode"))
                    {
                        SDCIFcifBranchCode = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifBranchDescription"))
                    {
                        SDCIFcifBranchDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifType"))
                    {
                        SDCIFcifType = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "cifTypeDescription"))
                    {
                        SDCIFcifTypeDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "idDeliveryDate"))
                    {
                        SDCIFidDeliveryDate = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "idExpiryDate"))
                    {
                        SDCIFidExpiryDate = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "joinType"))
                    {
                        SDCIFjoinType = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "jointAccounts"))
                    {
                        SDCIFjointAccounts = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "longNameArabic"))
                    {
                        SDCIFlongNameArabic = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "longNameEnglish"))
                    {
                        SDCIFlongNameEnglish = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "maritalStatus"))
                    {
                        SDCIFmaritalStatus = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "modeOfStatementDelivery"))
                    {
                        SDCIFmodeOfStatementDelivery = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "nationality"))
                    {
                        SDCIFnationality = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "nationalityDescription"))
                    {
                        SDCIFnationalityDescription = "";
                    }

                    if ((FieldStatus == "0") && (FieldName == "status"))
                    {
                        SDCIFstatus = "";
                    }


                }
            }
        }
        public string CheckChannel(String ChannelName, string username, string ChannelIP, string ServiceName)
        {

            string statusChannel = "";
            string EnableChannel = "";
            DataTable dt_Channel = DalCode.IMALChannelstatus(ChannelName, username, ChannelIP, ServiceName);
            DLL[] BR_Channel = new DLL[dt_Channel.Rows.Count];


            if (BR_Channel.Length != 0)
            {
                int ii;
                for (ii = 0; ii < dt_Channel.Rows.Count; ii++)
                {

                    EnableChannel = dt_Channel.Rows[ii]["EnableChannel"].ToString().Trim();
                }
            }
            if (EnableChannel == "1")
            {
                statusChannel = "Enabled";
            }
            else
            {
                statusChannel = "Disabled";
            }
            return statusChannel;
        }

        public string GetCifDetails(string MobileNo,string idNumber,string username,string password,string requesterTimeStamp,string ChannelName,string CIFNo,string AdditionalRef)
        {
  
            List<logCIFDetils> logrequest = new List<logCIFDetils>();
            List<RespCIFDTS> respnsCIFDTS = new List<RespCIFDTS>();
            try
            {
                string SstatusCode = "0";
                string SstatusDesc = "";
                string remoteIP = "";
                string RequestID = "";
                if(AdditionalRef != "")
                {
                   
                        CIFNo = AdditionalRef.Substring(10, 6).Trim();
                   
                }
                string returnCIFList = "";
                if (CIFNo == "")
                {
                    returnCIFList = ReturnCIFList(MobileNo, idNumber, username, password, requesterTimeStamp, ChannelName);
                    var json = JObject.Parse(returnCIFList.Remove(returnCIFList.Length - 1).Remove(0, 1));

                    CIFNo = (string)json["cifNumber"];
                    SstatusCode = (string)json["statusCode"];
                    SstatusDesc = (string)json["statusDesc"];
                }
                if (SstatusCode == "0")
                {
                    RequestID = "MW-KYCDts-" + CIFNo + "-" + DateTime.Now.ToString("ddMMyyyyHHmmssff");

                    HttpWebRequest request = CreateWebRequestReturnCIfList();
                    XmlDocument soapEnvelopeXml = new XmlDocument();
                    string status = CheckChannel(ChannelName, username, remoteIP, "CIFDetails");
                    logrequest.Add(new logCIFDetils
                    {

                        mobileNo = MobileNo,
                        idNumber = idNumber,
                        CIFNo = CIFNo,
                        username = username,
                        password = "*******",
                        ChannelName = ChannelName
                    });
                    string ClientRequest = JsonConvert.SerializeObject(logrequest);
                    DalCode.InsertLog("CIFDetails", Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")), ClientRequest, "Pending", ChannelName, RequestID);
                    if (status == "Enabled")
                    {
                        soapEnvelopeXml.LoadXml(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:cif=""cifManagementWs"">
   <soapenv:Header/>
   <soapenv:Body>
      <cif:returnCifDetails>
         <serviceContext>
            <businessArea>Retail</businessArea>
            <businessDomain>Products</businessDomain>
            <operationName>returnCifDetails</operationName>
            <serviceDomain>CifManagement</serviceDomain>
            <serviceID>1914</serviceID>
            <version>1.0</version>
         </serviceContext>
         <companyCode>1</companyCode>
         <branchCode>5599</branchCode>
         <cifNumber>" + CIFNo + @"</cifNumber>
          <requestContext>
            <requestID>" + RequestID + @"</requestID>
            <coreRequestTimeStamp>"+ requesterTimeStamp + @"</coreRequestTimeStamp>
         </requestContext>
         <requesterContext>
            <channelID>1</channelID>
            <hashKey>1</hashKey>
              <langId>EN</langId>
            <password>" + password + @"</password>
            <requesterTimeStamp>"+ requesterTimeStamp + @"</requesterTimeStamp>
            <userID>" + username + @"</userID>
         </requesterContext>
         <vendorContext>
            <license>Copyright 2018 Path Solutions. All Rights Reserved</license>
            <providerCompanyName>Path Solutions</providerCompanyName>
            <providerID>IMAL</providerID>
         </vendorContext>
      </cif:returnCifDetails>
   </soapenv:Body>
</soapenv:Envelope>"
    );
                        string soapResult = "";

                        using (Stream stream = request.GetRequestStream())
                        {
                            soapEnvelopeXml.Save(stream);
                        }
                        using (WebResponse response = request.GetResponse())
                        {
                            using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                            {
                                soapResult = rd.ReadToEnd();
                                // Console.WriteLine(soapResult);
                                var str = XElement.Parse(soapResult);
                                XmlDocument xmlDoc = new XmlDocument();
                                xmlDoc.LoadXml(soapResult);
                                XmlNodeList elemlistCode = xmlDoc.GetElementsByTagName("statusCode");
                                SstatusCode = elemlistCode[0].InnerXml;
                                XmlNodeList elemliststatusDesc = xmlDoc.GetElementsByTagName("statusDesc");

                                SstatusDesc = elemliststatusDesc[0].InnerXml;

                                if (SstatusCode == "0")
                                {
                                    foreach (XmlNode node in xmlDoc)
                                    {
                                        
                                        XmlNodeList XNcifAdditionalFields = xmlDoc.GetElementsByTagName("cifAdditionalFieldsDC");
                                        for (int i = 0; i < XNcifAdditionalFields.Count; i++)
                                        {

                                            var fieldColumnNumber = XNcifAdditionalFields[i].SelectSingleNode("fieldColumnNumber").InnerText;
                                            var fieldLabel = XNcifAdditionalFields[i].SelectSingleNode("fieldLabel").InnerText;
                                            var fieldValueDate = XNcifAdditionalFields[i].SelectNodes("fieldValueDate");
                                            var fieldValueVarNO = XNcifAdditionalFields[i].SelectSingleNode("fieldValueNumber");
                                            var fieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                            if (fieldValueVarNO != null)
                                            {
                                                string SfieldValueVarNo = XNcifAdditionalFields[i].SelectSingleNode("fieldValueNumber").InnerText;
                                                if (fieldLabel == "Tax ID Number")
                                                {
                                                    TaxIDNumber = SfieldValueVarNo;
                                                }
                                            }
                                            if (fieldValueVarchar !=null)
                                            {
                                                string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                if (fieldLabel == "Director #1 Name")
                                                {
                                                    Director1 = SfieldValueVarchar;
                                                }

                                                if (fieldLabel == "Director #2 Name")
                                                {
                                                    Director2 = SfieldValueVarchar;
                                                }

                                                if (fieldLabel == "Director #3 Name")
                                                {
                                                    Director3 = SfieldValueVarchar;
                                                }
                                            }
                                            if((fieldColumnNumber =="31") &&(fieldLabel == "Name") &&(fieldValueVarchar !=null))
                                            {
                                                string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                Representative1Name = SfieldValueVarchar;
                                            }

                                            if ((fieldColumnNumber == "32") && (fieldLabel == "National ID") && (fieldValueVarNO != null))
                                            {
                                                string SfieldValueVarNo = XNcifAdditionalFields[i].SelectSingleNode("fieldValueNumber").InnerText;
                                                Representative1ID = SfieldValueVarNo;
                                            }

                                            if ((fieldColumnNumber == "33") && (fieldLabel == "National ID Expiry Date") && (fieldValueDate != null))
                                            {
                                                var VfieldValueDate = XNcifAdditionalFields[i].SelectSingleNode("fieldValueDate");
                                                if (VfieldValueDate != null)
                                                {
                                                    string SfieldValueDate = XNcifAdditionalFields[i].SelectSingleNode("fieldValueDate").InnerText;
                                                    Representative1IDExpire = SfieldValueDate;
                                                }
                                            }

                                            if ((fieldColumnNumber == "34") && (fieldLabel == "National ID Issue Date") && (fieldValueDate != null))
                                            {
                                                var VfieldValueDate = XNcifAdditionalFields[i].SelectSingleNode("fieldValueDate");
                                                if (VfieldValueDate != null)
                                                {
                                                    string SfieldValueDate = XNcifAdditionalFields[i].SelectSingleNode("fieldValueDate").InnerText;
                                                    Representative1NationalIDIssueDate = SfieldValueDate;
                                                }
                                            }

                                            if ((fieldColumnNumber == "35") && (fieldLabel == "National ID Issue Place") && (fieldValueVarchar != null))
                                            {
                                                var VfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                                if (VfieldValueVarchar != null)
                                                {
                                                    string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                    Representative1NationalIDIssuePlace = SfieldValueVarchar;
                                                }
                                            }

                                            if ((fieldColumnNumber == "36") && (fieldLabel == "ID Type") && (fieldValueVarNO != null))
                                            {
                                                var VfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                                if (VfieldValueVarchar != null)
                                                {
                                                    string SfieldValueVarNo = XNcifAdditionalFields[i].SelectSingleNode("fieldValueNumber").InnerText;
                                                    Representative1IDType = SfieldValueVarNo;
                                                }
                                            }

                                            if ((fieldColumnNumber == "38") && (fieldLabel == "Nationality") && (fieldValueVarchar != null))
                                            {
                                                var VfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                                if (VfieldValueVarchar != null)
                                                {
                                                    string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                    Representative1Nationality = SfieldValueVarchar;
                                                }
                                            }

                                            if ((fieldColumnNumber == "39") && (fieldLabel == "Address 1") && (fieldValueVarchar != null))
                                            {
                                                var VfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                                if (VfieldValueVarchar != null)
                                                {
                                                    string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                    Representative1Address = SfieldValueVarchar;
                                                }
                                            }

                                            if ((fieldColumnNumber == "40") && (fieldLabel == "Address 2") && (fieldValueVarchar != null))
                                            {
                                                var VfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                                if (VfieldValueVarchar != null)
                                                {
                                                    string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                    Representative1Address2 = SfieldValueVarchar;
                                                }
                                            }

                                            if ((fieldColumnNumber == "42") && (fieldLabel == "Phone No") && (fieldValueVarchar != null))
                                            {
                                                var VfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                                if (VfieldValueVarchar != null)
                                                {
                                                    string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                    Representative1Phone = SfieldValueVarchar;
                                                }
                                            }

                                            if ((fieldColumnNumber == "45") && (fieldLabel == "Name") && (fieldValueVarchar != null))
                                            {
                                                var VfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                                if (VfieldValueVarchar != null)
                                                {
                                                    string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                    Representative2Name = SfieldValueVarchar;
                                                }
                                            }

                                            if ((fieldColumnNumber == "46") && (fieldLabel == "National ID") && (fieldValueVarNO != null))
                                            {
                                                var VfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueNumber");
                                                if (VfieldValueVarchar != null)
                                                {
                                                    string SfieldValueVarNo = XNcifAdditionalFields[i].SelectSingleNode("fieldValueNumber").InnerText;
                                                    Representative2ID = SfieldValueVarNo;
                                                }
                                            }

                                            if ((fieldColumnNumber == "47") && (fieldLabel == "National ID Expiry Date") && (fieldValueDate != null))
                                            {
                                                var VF47 = XNcifAdditionalFields[i].SelectSingleNode("fieldValueDate");
                                                if (VF47 != null)
                                                {
                                                    string SfieldValueDate = XNcifAdditionalFields[i].SelectSingleNode("fieldValueDate").InnerText;
                                                    Representative2IDExpire = SfieldValueDate;
                                                }
                                            }

                                            if ((fieldColumnNumber == "48") && (fieldLabel == "National ID Issue Date") && (fieldValueDate != null))
                                            {
                                                var VF48 = XNcifAdditionalFields[i].SelectSingleNode("fieldValueDate");
                                                if (VF48 != null)
                                                {
                                                    string SfieldValueDate = XNcifAdditionalFields[i].SelectSingleNode("fieldValueDate").InnerText;
                                                    Representative2NationalIDIssueDate = SfieldValueDate;
                                                }
                                            }

                                            if ((fieldColumnNumber == "49") && (fieldLabel == "National ID Issue Place") && (fieldValueVarchar != null))
                                            {
                                                var VF49 =  XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar");
                                                if (VF49 != null)
                                                {
                                                    string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                    Representative2NationalIDIssuePlace = SfieldValueVarchar;
                                                }
                                            }

                                            if ((fieldColumnNumber == "50") && (fieldLabel == "ID Type") && (fieldValueVarNO != null))
                                            {
                                                var VF50 = XNcifAdditionalFields[i].SelectSingleNode("fieldValueNumber");
                                                if (VF50 != null)
                                                {
                                                    string SfieldValueVarNo = XNcifAdditionalFields[i].SelectSingleNode("fieldValueNumber").InnerText;
                                                    Representative2IDType = SfieldValueVarNo;
                                                }
                                            }

                                            if ((fieldColumnNumber == "52") && (fieldLabel == "Nationality") && (fieldValueVarchar != null))
                                            {
                                                string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                Representative2Nationality = SfieldValueVarchar;
                                            }

                                            if ((fieldColumnNumber == "53") && (fieldLabel == "Address 1") && (fieldValueVarchar != null))
                                            {
                                                string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                Representative2Address = SfieldValueVarchar;
                                            }

                                            if ((fieldColumnNumber == "54") && (fieldLabel == "Address 2") && (fieldValueVarchar != null))
                                            {
                                                string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                Representative2Address2 = SfieldValueVarchar;
                                            }

                                            if ((fieldColumnNumber == "56") && (fieldLabel == "Phone No") && (fieldValueVarchar != null))
                                            {
                                                string SfieldValueVarchar = XNcifAdditionalFields[i].SelectSingleNode("fieldValueVarchar").InnerText;
                                                Representative2Phone = SfieldValueVarchar;
                                            }

                                        }


                                     


                                        XmlNodeList XNidNumber = xmlDoc.GetElementsByTagName("idNumber");


                                        SDidNumber = XNidNumber[0].InnerXml;



                                        XmlNodeList XNidType = xmlDoc.GetElementsByTagName("idType");
                                        SDidType = XNidType[0].InnerXml;


                                        XmlNodeList XNidTypeDescription = xmlDoc.GetElementsByTagName("idTypeDescription");
                                        SDidTypeDescription = XNidTypeDescription[0].InnerXml;


                                        XmlNodeList XNcifCategory = xmlDoc.GetElementsByTagName("cifCategory");
                                        var VcifCategory = xmlDoc.GetElementsByTagName("cifCategory");
                                        if (VcifCategory.Count > 0)
                                        {
                                            SDCIFcifCategory = XNcifCategory[0].InnerXml;
                                        }

                                        XmlNodeList XNcifIsComplete = xmlDoc.GetElementsByTagName("cifIsComplete");
                                        var VcifIsComplete = xmlDoc.GetElementsByTagName("cifIsComplete");
                                        if (VcifIsComplete.Count > 0)
                                        {
                                            SDCIFcifIsComplete = XNcifIsComplete[0].InnerXml;
                                        }



                                        XmlNodeList XNbusinessRisk = xmlDoc.GetElementsByTagName("businessRisk");
                                        SDCIFbusinessRisk = XNbusinessRisk[0].InnerXml;


                                        XmlNodeList XNSDCIFcifLimitCapDescription = xmlDoc.GetElementsByTagName("cifLimitCapDescription");
                                        SDCIFcifLimitCapDescription = XNSDCIFcifLimitCapDescription[0].InnerXml;

                                   
                                            XmlNodeList XNcifRating = xmlDoc.GetElementsByTagName("cifRating");
                                        var VcifRating = xmlDoc.GetElementsByTagName("cifRating");
                                        if (VcifRating.Count >0)
                                        {
                                            SDCIFcifRating = XNcifRating[0].InnerXml;
                                        }

                       
                                        XmlNodeList XNSDCIFcifRatingDescription = xmlDoc.GetElementsByTagName("cifRatingDescription");
                                        var vSDCIFcifRatingDescription = xmlDoc.GetElementsByTagName("cifRatingDescription");
                                        if (vSDCIFcifRatingDescription.Count >0)
                                        {
                                            SDCIFcifRatingDescription = XNSDCIFcifRatingDescription[0].InnerXml;
                                        }


                                        XmlNodeList XNSDCIFcountryDescription = xmlDoc.GetElementsByTagName("countryDescription");
                                        SDCIFcountryDescription = XNSDCIFcountryDescription[0].InnerXml;


                                        XmlNodeList XNSDCIFcountryOfBirth = xmlDoc.GetElementsByTagName("countryOfBirth");
                                        var VcountryOfBirth = xmlDoc.GetElementsByTagName("countryOfBirth");
                                        if (VcountryOfBirth.Count > 0)
                                        {
                                            SDCIFcountryOfBirth = XNSDCIFcountryOfBirth[0].InnerXml;
                                        }

                                        XmlNodeList XNSDCIFeconomicSector = xmlDoc.GetElementsByTagName("economicSector");
                                        SDCIFeconomicSector = XNSDCIFeconomicSector[0].InnerXml;

                                        XmlNodeList XNSDCIFeconomicSectorDescription = xmlDoc.GetElementsByTagName("economicSectorDescription");
                                        SDCIFeconomicSectorDescription = XNSDCIFeconomicSectorDescription[0].InnerXml;


                                        XmlNodeList XNSDCIFkyc = xmlDoc.GetElementsByTagName("kyc");
                                        SDCIFkyc = XNSDCIFkyc[0].InnerXml;

                                        XmlNodeList XNgender = xmlDoc.GetElementsByTagName("gender");
                                        var Vgender = xmlDoc.GetElementsByTagName("gender");
                                        if (Vgender.Count > 0)
                                        {
                                            Sgender = XNgender[0].InnerXml;
                                        }
                                        XmlNodeList XNSDCIFlegalStatus = xmlDoc.GetElementsByTagName("legalStatus");
                                        SDCIFlegalStatus = XNSDCIFlegalStatus[0].InnerXml;


                                        XmlNodeList XNSDCIFlegalStatusDescription = xmlDoc.GetElementsByTagName("legalStatusDescription");
                                        SDCIFlegalStatusDescription = XNSDCIFlegalStatusDescription[0].InnerXml;

                                        XmlNodeList XNoccupation = xmlDoc.GetElementsByTagName("occupation");
                                        var Voccupation = xmlDoc.GetElementsByTagName("occupation");
                                        if (Voccupation.Count > 0)
                                        {
                                        
                                            SDCIFoccupation = XNoccupation[0].InnerXml;
                                        }

                                        XmlNodeList XNoccupationDescription = xmlDoc.GetElementsByTagName("occupationDescription");
                                        var VoccupationDescription = xmlDoc.GetElementsByTagName("occupationDescription");
                                        if (VoccupationDescription.Count >0)
                                        {

                                      
                                            SDCIFoccupationDescription = XNoccupationDescription[0].InnerXml;
                                        }

                                        XmlNodeList XNemployerCifName = xmlDoc.GetElementsByTagName("employerCifName");
                                        var VemployerCifName = xmlDoc.GetElementsByTagName("employerCifName");
                                        if (VemployerCifName.Count > 0)
                                        {


                                            SemployerCifName = XNemployerCifName[0].InnerXml;
                                        }

                                        XmlNodeList XNprofession = xmlDoc.GetElementsByTagName("profession");
                                        var Vprofession = xmlDoc.GetElementsByTagName("profession");
                                        if (Vprofession.Count >0)
                                        {
                                            SDCIFprofession = XNprofession[0].InnerXml;
                                        }

                                        XmlNodeList XNranking = xmlDoc.GetElementsByTagName("ranking");
                                        var Vranking = xmlDoc.GetElementsByTagName("ranking");
                                        if (Vranking.Count >0)
                                        {
                                            SDCIFranking = XNranking[0].InnerXml;

                                        }
                                        XmlNodeList XNrankingDescription = xmlDoc.GetElementsByTagName("rankingDescription");
                                        SDCIFrankingDescription = XNrankingDescription[0].InnerXml;


                                        XmlNodeList XNresident = xmlDoc.GetElementsByTagName("resident");
                                        var Vresident = xmlDoc.GetElementsByTagName("resident");
                                        if (Vresident.Count>0)
                                        {
                                            SDCIFresident = XNresident[0].InnerXml;
                                        }

                                        XmlNodeList XNcifBranchCode = xmlDoc.GetElementsByTagName("cifBranchCode");
                                        SDCIFcifBranchCode = XNcifBranchCode[0].InnerXml;


                                        XmlNodeList XNcifBranchDescription = xmlDoc.GetElementsByTagName("cifBranchDescription");
                                        SDCIFcifBranchDescription = XNcifBranchDescription[0].InnerXml;


                                        XmlNodeList XNcifType = xmlDoc.GetElementsByTagName("cifType");
                                        SDCIFcifType = XNcifType[0].InnerXml;



                                        XmlNodeList XNcifTypeDescription = xmlDoc.GetElementsByTagName("cifTypeDescription");
                                        SDCIFcifTypeDescription = XNcifTypeDescription[0].InnerXml;

                                       
                                      


                                        XmlNodeList XNidDeliveryDate = xmlDoc.GetElementsByTagName("idDeliveryDate");
                                        var VidDeliveryDate = xmlDoc.GetElementsByTagName("idDeliveryDate");
                                        if (VidDeliveryDate.Count > 0)
                                        {
                                            SDCIFidDeliveryDate = XNidDeliveryDate[0].InnerXml;
                                        }


                                        XmlNodeList XNidExpiryDate = xmlDoc.GetElementsByTagName("idExpiryDate");
                                        var VidExpiryDate = xmlDoc.GetElementsByTagName("idExpiryDate");
                                        if (VidExpiryDate.Count > 0)
                                        {
                                            SDCIFidExpiryDate = XNidExpiryDate[0].InnerXml;

                                        }

                                        XmlNodeList XNjoinType = xmlDoc.GetElementsByTagName("joinType");
                                        var VjoinType = xmlDoc.GetElementsByTagName("joinType");
                                        if (VjoinType.Count > 0)
                                        {
                                            SDCIFjoinType = XNjoinType[0].InnerXml;
                                        }

                                        
                                        XmlNodeList XNjointAccounts = xmlDoc.GetElementsByTagName("jointAccounts");
                                        var VjointAccounts = xmlDoc.GetElementsByTagName("jointAccounts");
                                        if (VjointAccounts.Count > 0)
                                        {
                                            SDCIFjointAccounts = XNjointAccounts[0].InnerXml;
                                        }


                                        XmlNodeList XNlongNameArabic = xmlDoc.GetElementsByTagName("longNameArabic");
                                        SDCIFlongNameArabic = XNlongNameArabic[0].InnerXml;



                                        XmlNodeList XNlongNameEnglish = xmlDoc.GetElementsByTagName("longNameEnglish");
                                        SDCIFlongNameEnglish = XNlongNameEnglish[0].InnerXml;


                                        XmlNodeList XNmaritalStatus = xmlDoc.GetElementsByTagName("maritalStatus");
                                        var VmaritalStatus = xmlDoc.GetElementsByTagName("maritalStatus");
                                        if (VmaritalStatus.Count > 0)
                                        {

                                            SDCIFmaritalStatus = XNmaritalStatus[0].InnerXml;

                                        }

                                        XmlNodeList XNmodeOfStatementDelivery = xmlDoc.GetElementsByTagName("modeOfStatementDelivery");
                                        SDCIFmodeOfStatementDelivery = XNmodeOfStatementDelivery[0].InnerXml;



                                        XmlNodeList XNnationality = xmlDoc.GetElementsByTagName("nationality");
                                        var Vnationality = xmlDoc.GetElementsByTagName("nationality");
                                        if (Vnationality.Count > 0)
                                        {
                                            SDCIFnationality = XNnationality[0].InnerXml;
                                        }


                                        XmlNodeList XNnationalityDescription = xmlDoc.GetElementsByTagName("nationalityDescription");

                                        var VnationalityDescription = xmlDoc.GetElementsByTagName("nationalityDescription");
                                        if (VnationalityDescription.Count > 0)
                                        {
                                            SDCIFnationalityDescription = XNnationalityDescription[0].InnerXml;

                                        }
                                        XmlNodeList XNaddressEnglish = xmlDoc.GetElementsByTagName("addressEnglish");
                                        var VaddressEnglish = xmlDoc.GetElementsByTagName("addressEnglish");
                                        if(VaddressEnglish.Count > 0)
                                        {
                                            SaddressEnglish = XNaddressEnglish[0].InnerXml;
                                        }
                                        XmlNodeList XNaddressArabic = xmlDoc.GetElementsByTagName("addressArabic");
                                        var VaddressArabic = xmlDoc.GetElementsByTagName("addressArabic");
                                        if(VaddressArabic.Count > 0)
                                        {
                                            SaddressArabic = XNaddressArabic[0].ToString();
                                        }
                                        XmlNodeList XNareaDescription = xmlDoc.GetElementsByTagName("areaDescription");
                                        var VareaDescription = xmlDoc.GetElementsByTagName("areaDescription");
                                        if(VareaDescription.Count > 0)
                                        {
                                            SareaDescription = XNareaDescription[0].InnerXml;
                                        }

                                        XmlNodeList XNcountryDescription = xmlDoc.GetElementsByTagName("countryDescription");
                                        var VcountryDescription = xmlDoc.GetElementsByTagName("countryDescription");
                                        if(VcountryDescription.Count > 0)
                                        {
                                            ScountryDescription = XNcountryDescription[0].InnerXml;
                                        }

                                        XmlNodeList XNregionDescription = xmlDoc.GetElementsByTagName("regionDescription");
                                        var VregionDescription = xmlDoc.GetElementsByTagName("regionDescription");
                                        if(VregionDescription.Count > 0)
                                        {
                                            SregionDescription = XNregionDescription[0].InnerXml;
                                        }

                                        XmlNodeList XNsecondNameArabic = xmlDoc.GetElementsByTagName("secondNameArabic");
                                        var VsecondNameArabic = xmlDoc.GetElementsByTagName("secondNameArabic");
                                        if (VsecondNameArabic.Count > 0)
                                        {
                                            secondNameArabic = XNsecondNameArabic[0].InnerXml;
                                        }

                                        XmlNodeList XNsecondNameEnglish = xmlDoc.GetElementsByTagName("secondNameEnglish");
                                        var VsecondNameEnglish = xmlDoc.GetElementsByTagName("secondNameEnglish");
                                        if (VsecondNameEnglish.Count > 0)
                                        {
                                            secondNameEnglish = XNsecondNameEnglish[0].InnerXml;
                                        }

                                        XmlNodeList XNlastNameArabic = xmlDoc.GetElementsByTagName("lastNameArabic");
                                        var VlastNameArabic = xmlDoc.GetElementsByTagName("lastNameArabic");
                                        if (VsecondNameArabic.Count > 0)
                                        {
                                            lastNameArabic = XNlastNameArabic[0].InnerXml;
                                        }

                                        XmlNodeList XNlastNameEnglish = xmlDoc.GetElementsByTagName("lastNameEnglish");
                                        var VlastNameEnglish = xmlDoc.GetElementsByTagName("lastNameEnglish");
                                        if (VlastNameEnglish.Count > 0)
                                        {
                                            lastNameEnglish = XNlastNameEnglish[0].InnerXml;
                                        }

                                        XmlNodeList XNthirdNameArabic = xmlDoc.GetElementsByTagName("thirdNameArabic");
                                        var VthirdNameArabic = xmlDoc.GetElementsByTagName("thirdNameArabic");
                                        if (VthirdNameArabic.Count > 0)
                                        {
                                            thirdNameArabic = XNthirdNameArabic[0].InnerXml;
                                        }

                                        XmlNodeList XNthirdNameEnglish = xmlDoc.GetElementsByTagName("thirdNameEnglish");
                                        var VthirdNameEnglish = xmlDoc.GetElementsByTagName("thirdNameEnglish");
                                        if (VthirdNameEnglish.Count > 0)
                                        {
                                            thirdNameEnglish = XNthirdNameEnglish[0].InnerXml;
                                        }

                                        XmlNodeList XNfirstNameArabic = xmlDoc.GetElementsByTagName("firstNameArabic");
                                        var VfirstNameArabic = xmlDoc.GetElementsByTagName("firstNameArabic");
                                        if (VfirstNameArabic.Count > 0)
                                        {
                                            firstNameArabic = XNfirstNameArabic[0].InnerXml;
                                        }
                                        XmlNodeList XNemail = xmlDoc.GetElementsByTagName("email");
                                        var Vemail = xmlDoc.GetElementsByTagName("email");
                                        if (Vemail.Count > 0)
                                        {
                                            email = XNemail[0].InnerXml;
                                        }

                                        XmlNodeList XNfirstNameEnglish = xmlDoc.GetElementsByTagName("firstNameEnglish");
                                        var VfirstNameEnglish = xmlDoc.GetElementsByTagName("firstNameEnglish");
                                        if (VfirstNameEnglish.Count > 0)
                                        {
                                            firstNameEnglish = XNfirstNameEnglish[0].InnerXml;
                                        }

                                        XmlNodeList XNdateOfBirth = xmlDoc.GetElementsByTagName("dateOfBirth");
                                        var VdateOfBirth = xmlDoc.GetElementsByTagName("dateOfBirth");
                                        if (VdateOfBirth.Count > 0)
                                        {
                                            dateOfBirth = XNdateOfBirth[0].InnerXml;
                                        }
                                        XmlNodeList XNcountry = xmlDoc.GetElementsByTagName("country");
                                        var Vcountry = xmlDoc.GetElementsByTagName("country");
                                        if (Vcountry.Count > 0)
                                        {
                                            country = XNcountry[0].InnerXml;
                                        }

                                        XmlNodeList XNmobile = xmlDoc.GetElementsByTagName("mobile");
                                        var Vmobile = xmlDoc.GetElementsByTagName("mobile");
                                        if (Vmobile.Count > 0)
                                        {
                                            mobile = XNmobile[0].InnerXml;
                                        }

                                        XmlNodeList XNstatus = xmlDoc.GetElementsByTagName("status");
                                        SDCIFstatus = XNstatus[0].InnerXml;

                                        XmlNodeList XNblock = xmlDoc.GetElementsByTagName("block");
                                        var Vblock = xmlDoc.GetElementsByTagName("block");
                                        if (Vblock.Count > 0)
                                        {
                                            block = XNblock[0].InnerXml;
                                        }

                                        XmlNodeList XNblockArabic = xmlDoc.GetElementsByTagName("blockArabic");
                                        var VblockArabic = xmlDoc.GetElementsByTagName("blockArabic");
                                        if (VblockArabic.Count > 0)
                                        {
                                            blockArabic = XNblockArabic[0].InnerXml;
                                        }

                                        CheckFields(ChannelName, "CIFDetails");
                                        respnsCIFDTS.Add(new RespCIFDTS
                                        {
                                            CIFidNumber = SDidNumber,
                                            CIFidType = SDidType,
                                            CIFidTypeDescription = SDidTypeDescription,
                                            CIFcifCategory = SDCIFcifCategory,
                                            CIFcifIsComplete = SDCIFcifIsComplete,
                                            CIFbusinessRisk = SDCIFbusinessRisk,
                                            CIFcifLimitCapDescription = SDCIFcifLimitCapDescription,
                                            CIFcifRating = SDCIFcifRating,
                                            CIFcifRatingDescription = SDCIFcifRatingDescription,
                                            CIFcountryDescription = SDCIFcountryDescription,
                                            CIFcountryOfBirth = SDCIFcountryOfBirth,
                                            CIFeconomicSector = SDCIFeconomicSector,
                                            CIFeconomicSectorDescription = SDCIFeconomicSectorDescription,
                                            CIFkyc = SDCIFkyc,
                                            CIFlegalStatus = SDCIFlegalStatus,
                                            CIFlegalStatusDescription = SDCIFlegalStatusDescription,
                                            CIFoccupation = SDCIFoccupation,
                                            employerCifName = SemployerCifName,
                                            CIFoccupationDescription = SDCIFoccupationDescription,
                                            CIFprofession = SDCIFprofession,
                                            CIFranking = SDCIFranking,
                                            CIFrankingDescription = SDCIFrankingDescription,
                                            CIFresident = SDCIFresident,
                                            CIFcifBranchCode = SDCIFcifBranchCode,
                                            CIFcifBranchDescription = SDCIFcifBranchDescription,
                                            CIFcifType = SDCIFcifType,
                                            CIFcifTypeDescription = SDCIFcifTypeDescription,
                                            CIFidDeliveryDate = SDCIFidDeliveryDate,
                                            CIFidExpiryDate = SDCIFidExpiryDate,
                                            CIFjoinType = SDCIFjoinType,
                                            CIFjointAccounts = SDCIFjointAccounts,
                                            CIFlongNameArabic = SDCIFlongNameArabic,
                                            CIFlongNameEnglish = SDCIFlongNameEnglish,
                                            firstNameEnglish = firstNameEnglish,
                                            firstNameArabic = firstNameArabic,
                                            secondNameArabic = secondNameArabic,
                                            secondNameEnglish = secondNameEnglish,
                                            thirdNameArabic = thirdNameArabic,
                                            thirdNameEnglish = thirdNameEnglish,
                                            lastNameArabic= lastNameArabic,
                                            lastNameEnglish = lastNameEnglish,
                                            gender = Sgender,
                                            dateOfBirth = dateOfBirth,
                                            CIFmaritalStatus = SDCIFmaritalStatus,
                                            CIFmodeOfStatementDelivery = SDCIFmodeOfStatementDelivery,
                                            CIFnationality = SDCIFnationality,
                                            CIFnationalityDescription = SDCIFnationalityDescription,
                                            CIFstatus = SDCIFstatus,
                                            addressEnglish = SaddressEnglish,
                                            addressArabic = SaddressArabic,
                                            areaDescription = SareaDescription,
                                            country = country,
                                            countryDescription = ScountryDescription,
                                            regionDescription = SregionDescription,
                                            mobile = mobile,
                                            email = email,
                                            blockArabic = blockArabic,
                                            block =block,
                                            TaxIDNumber= TaxIDNumber,
                                            Director1= Director1,
                                            Director2= Director2,
                                            Director3= Director3,
                                            Representative1Name = Representative1Name,
                                            Representative1ID = Representative1ID,
                                            Representative1IDExpire = Representative1IDExpire,
                                            Representative1NationalIDIssueDate = Representative1NationalIDIssueDate,
                                            Representative1NationalIDIssuePlace = Representative1NationalIDIssuePlace,
                                            Representative1IDType = Representative1IDType,
                                            Representative1Nationality = Representative1Nationality,
                                            Representative1Address = Representative1Address,
                                            Representative1Address2 = Representative1Address2,
                                            Representative2Address2 = Representative2Address2,
                                            Representative1Phone = Representative1Phone,
                                            Representative2Name = Representative2Name,
                                            Representative2ID = Representative2ID,
                                            Representative2IDExpire = Representative2IDExpire,
                                            Representative2NationalIDIssueDate = Representative1NationalIDIssueDate,
                                            Representative2NationalIDIssuePlace = Representative1NationalIDIssuePlace,
                                            Representative2IDType = Representative2IDType,
                                            Representative2Nationality = Representative2Nationality,
                                            Representative2Address = Representative2Address,
                                        
                                            Representative2Phone = Representative2Phone,
                                            CIF = CIFNo,



                                            statusCode = SstatusCode,
                                            statusDesc = SstatusDesc
                                        });

                                    }
                                }
                                else
                                {

                                    respnsCIFDTS.Add(new RespCIFDTS
                                    {

                                        statusCode = SstatusCode,
                                        statusDesc = SstatusDesc
                                    });
                                }

                            }
                        }

                    }
                    else
                    {
                        SstatusCode = "-985";
                        SstatusDesc = "you are not authorize";
                        respnsCIFDTS.Add(new RespCIFDTS
                        {

                            statusCode = SstatusCode,
                            statusDesc = SstatusDesc
                        });
                    }
                    
                }
                else
                {
                    respnsCIFDTS.Add(new RespCIFDTS
                    {

                        statusCode = SstatusCode,
                        statusDesc = SstatusDesc
                    });
                }

                string statuslog = "";
                if (SstatusCode == "0")
                {
                    statuslog = "Success";
                }
                else
                {
                    statuslog = "Failed";
                }
                DalCode.UpdateLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), JsonConvert.SerializeObject((respnsCIFDTS)), statuslog, ChannelName, RequestID);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                respnsCIFDTS.Add(new RespCIFDTS
                {

                    statusCode = "-999",
                    statusDesc = CIFNo + "\t" + ex.Message.ToString() + "\n" + ex.StackTrace + "\n" + ex.InnerException
                }) ;
            }
            return JsonConvert.SerializeObject(respnsCIFDTS, Newtonsoft.Json.Formatting.Indented);

        }
    }
}
