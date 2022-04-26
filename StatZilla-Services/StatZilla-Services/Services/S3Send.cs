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
        public static bool Send(string awsAccessKey, string awsSecretKey, string localFilePath, string bucketName, string subDirectoryInBucket, string fileNameInS3, RegionEndpoint regionEndpoint, Log ServiceLog)
        {

            try
            {

                IAmazonS3 client = new AmazonS3Client(awsAccessKey, awsSecretKey, regionEndpoint);

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
    }
}
