using Amazon;
using Amazon.Polly;
using Amazon.Polly.Model;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;
using Scribe_Factory_Core.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Scribe_Factory_Core.Repositories
{
    public class AWSHelper
    {
        AmazonPollyClient pollyClient = null;
        BasicAWSCredentials BasicAWSCredentials = null;
        public AWSHelper(string accesskey, string secretKey)
        {
            BasicAWSCredentials = new BasicAWSCredentials(accesskey, secretKey);

            pollyClient = new AmazonPollyClient(BasicAWSCredentials, RegionEndpoint.USEast1);
            GetAllVoiceType();

        }

        private void GetAllVoiceType()
        {
            if (StaticVoiceDetails.AllVoices == null)
            {
                var VoiceList = pollyClient.DescribeVoicesAsync(new DescribeVoicesRequest()).Result;
                List<VoiceModel> voiceModels = new List<VoiceModel>();
                StaticVoiceDetails.AllVoices = VoiceList.Voices.Select(x => new VoiceModel { Engine = x.SupportedEngines, Gender = x.Gender, Id = x.Id, Name = x.Name, LanguageCode = x.LanguageCode, LanguageName = x.LanguageName }).ToList();

            }
        }
        public List<VoiceModel> GetLanguagesAgainstGender(string gender)
        {
            return StaticVoiceDetails.AllVoices.Where(x => x.Gender == gender).Select(x => new VoiceModel { LanguageCode = x.LanguageCode, LanguageName = x.LanguageName }).ToList();
        }
        public List<VoiceModel> GetVoicesAgainstLanguage(string LanguageCode,string gender)
        {
            return StaticVoiceDetails.AllVoices.Where(x => x.LanguageCode == LanguageCode && x.Gender == gender).Select(x => new VoiceModel { Id = x.Id, Name = x.Name }).ToList();
        }
        public bool ConvertTextToSpeech(string text, string languageCode, string VoiceId, string Engine, string bucketName,string FileName)
        {
            try
            {
                var synthesizeSpeechResponse = pollyClient.SynthesizeSpeechAsync(new SynthesizeSpeechRequest
                {
                    LanguageCode = languageCode,
                    OutputFormat = "mp3",
                    SampleRate = "16000",
                    Text = text,
                    TextType = "text",
                    VoiceId = VoiceId,
                    Engine = Engine
                }).Result;
                return sendMyFileToS3(synthesizeSpeechResponse.AudioStream, bucketName, "", FileName);

                //AudioHelper audioHelper = new AudioHelper();
                //return audioHelper.SaveMp3(synthesizeSpeechResponse, "Polly.mp3").Result;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool sendMyFileToS3(System.IO.Stream localFilePath, string bucketName, string subDirectoryInBucket, string fileNameInS3)
        {
            IAmazonS3 client = new AmazonS3Client(BasicAWSCredentials, RegionEndpoint.USWest2);
            TransferUtility utility = new TransferUtility(client);
            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();

            if (subDirectoryInBucket == "" || subDirectoryInBucket == null)
            {
                request.BucketName = bucketName; //no subdirectory just bucket name  
            }
            else
            {   // subdirectory and bucket name  
                request.BucketName = bucketName + @"/" + subDirectoryInBucket;
            }
            request.Key = fileNameInS3; //file name up in S3  
            MemoryStream ms = new MemoryStream();
            localFilePath.CopyTo(ms);
            request.InputStream = ms;
            utility.Upload(request); //commensing the transfer  

            return true; //indicate that the file was sent  
        }
    }
}
