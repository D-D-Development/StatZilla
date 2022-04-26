using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using StatZilla_Services.Utility;

namespace StatZilla_Services.Services
{
    class S3Send
    {
        public static bool Send(string awsAccessKey, string awsSecretKey, string localFilePath, string bucketName, string subDirectoryInBucket, string fileNameInS3, string regionEndpoint, Log ServiceLog)
        {

            try
            {

                IAmazonS3 client = new AmazonS3Client(awsAccessKey, awsSecretKey, GetRegion(regionEndpoint));

                // create a TransferUtility instance passing it the IAmazonS3 created in the first step
                TransferUtility utility = new(client);

                // making a TransferUtilityUploadRequest instance
                TransferUtilityUploadRequest request = new();

                if (subDirectoryInBucket == "" || subDirectoryInBucket == null)
                {
                    request.BucketName = bucketName; //no subdirectory just bucket name
                }
                else
                {   // subdirectory and bucket name
                    request.BucketName = bucketName + @"/" + subDirectoryInBucket;
                }
                request.Key = fileNameInS3; //file name up in S3
                request.FilePath = localFilePath; //local file name
                utility.Upload(request); //commensing the transfer
                return true; //indicate that the file was sent

            }
            catch (Exception ex)
            {
                return false;
                ServiceLog.WriteLine(Log.Type.ERROR, ex.Message);
            }

        }
        public static RegionEndpoint GetRegion(string region)
        {
            if (region == "US East (Ohio)")
                return RegionEndpoint.USEast2;
            else if (region == "US East (N. Virginia)")
                return RegionEndpoint.USEast1;
            else if (region == "US West (N. California)")
                return RegionEndpoint.USWest1;
            else if (region == "US West (Oregon)")
                return RegionEndpoint.USWest2;
            else if (region == "Africa (Cape Town)")
                return RegionEndpoint.AFSouth1;
            else if (region == "Asia Pacific (Hong Kong)***")
                return RegionEndpoint.APEast1;
            else if (region == "Asia Pacific (Jakarta)")
                return RegionEndpoint.APSoutheast3;
            else if (region == "Asia Pacific (Mumbai)")
                return RegionEndpoint.APSouth1;
            else if (region == "Asia Pacific (Osaka)")
                return RegionEndpoint.APNortheast3;
            else if (region == "Asia Pacific (Seoul)")
                return RegionEndpoint.APNortheast2;
            else if (region == "Asia Pacific (Singapore)")
                return RegionEndpoint.APSoutheast1;
            else if (region == "Asia Pacific (Sydney)")
                return RegionEndpoint.APSoutheast2;
            else if (region == "Asia Pacific (Tokyo)")
                return RegionEndpoint.APNortheast1;
            else if (region == "Canada (Central)")
                return RegionEndpoint.CACentral1;
            else if (region == "China (Beijing)")
                return RegionEndpoint.CNNorth1;
            else if (region == "China (Ningxia)")
                return RegionEndpoint.CNNorthWest1;
            else if (region == "Europe (Frankfurt)")
                return RegionEndpoint.EUCentral1;
            else if (region == "Europe (Ireland)")
                return RegionEndpoint.EUWest1;
            else if (region == "Europe (London)")
                return RegionEndpoint.EUWest2;
            else if (region == "Europe (Milan)")
                return RegionEndpoint.EUSouth1;
            else if (region == "Europe (Paris)")
                return RegionEndpoint.EUWest3;
            else if (region == "Europe (Stockholm)")
                return RegionEndpoint.EUNorth1;
            else if (region == "South America (São Paulo)")
                return RegionEndpoint.SAEast1;
            else if (region == "Middle East (Bahrain)")
                return RegionEndpoint.MESouth1;
            else if (region == "AWS GovCloud (US-East)")
                return RegionEndpoint.USGovCloudEast1;
            else if (region == "AWS GovCloud (US-West)")
                return RegionEndpoint.USGovCloudWest1;

            return RegionEndpoint.USEast2;
        }
    }
}
