
using Amazon;


namespace StatZilla.Models
{
    public class AWSRegionComboItem 
    {
        public int ID;
        public string Text;
    }

    public class S3Bucket: Session
    {
        public bool isActive;
        public string bucketName;
        public string destinationPath;
        public string secretKey;
        public string accessKey;
        public RegionEndpoint regEndpoint;

        public S3Bucket() { }
        public S3Bucket( string file, string bucket,string path, string secret, string access, string region)
        {
            sessionFilename = file;
            bucketName = bucket;
            destinationPath = path;
            secretKey = secret;
            accessKey = access;
            regEndpoint = GetRegion(region);
        }

        public static string GetStringRegion(RegionEndpoint reg)
        {
            string currentReg = "";

            if (reg == RegionEndpoint.USEast2)
                currentReg = "US East (Ohio)";
            else if (reg == RegionEndpoint.USEast1)
                currentReg = "US East (N. Virginia)";
            else if (reg == RegionEndpoint.USWest1)
                currentReg = "US West (N. California)";
            else if (reg == RegionEndpoint.USWest2)
                currentReg = "US West (Oregon)";
            else if (reg == RegionEndpoint.AFSouth1)
                currentReg = "Africa (Cape Town)";
            else if (reg == RegionEndpoint.APEast1)
                currentReg = "Asia Pacific (Hong Kong)***";
            else if (reg == RegionEndpoint.APSoutheast3)
                currentReg = "Asia Pacific (Jakarta)";
            else if (reg == RegionEndpoint.APSouth1)
                currentReg = "Asia Pacific (Mumbai)";
            else if (reg == RegionEndpoint.APNortheast3)
                currentReg = "Asia Pacific (Osaka)";
            else if (reg == RegionEndpoint.APNortheast2)
                currentReg = "Asia Pacific (Seoul)";
            else if (reg == RegionEndpoint.APSoutheast1)
                currentReg = "Asia Pacific (Singapore)";
            else if (reg == RegionEndpoint.APSoutheast2)
                currentReg = "Asia Pacific (Sydney)";
            else if (reg == RegionEndpoint.APNortheast1)
                currentReg = "Asia Pacific (Tokyo)";
            else if (reg == RegionEndpoint.CACentral1)
                currentReg = "Canada (Central)";
            else if (reg == RegionEndpoint.CNNorth1)
                currentReg = "China (Beijing)";
            else if (reg == RegionEndpoint.CNNorthWest1)
                currentReg = "China (Ningxia)";
            else if (reg == RegionEndpoint.EUCentral1)
                currentReg = "Europe (Frankfurt)";
            else if (reg == RegionEndpoint.EUWest1)
                currentReg = "Europe (Ireland)";
            else if (reg == RegionEndpoint.EUWest2)
                currentReg = "Europe (London)";
            else if (reg == RegionEndpoint.EUSouth1)
                currentReg = "Europe (Milan)";
            else if (reg == RegionEndpoint.EUWest3)
                currentReg = "Europe (Paris)";
            else if (reg == RegionEndpoint.EUNorth1)
                currentReg = "Europe (Stockholm)";
            else if (reg == RegionEndpoint.SAEast1)
                currentReg = "South America (São Paulo)";
            else if (reg == RegionEndpoint.MESouth1)
                currentReg = "Middle East (Bahrain)";
            else if (reg == RegionEndpoint.USGovCloudEast1)
                currentReg = "AWS GovCloud (US-East)";
            else if (reg == RegionEndpoint.USGovCloudWest1)
                currentReg = "AWS GovCloud (US-West)";

            return currentReg;
        }

        public static RegionEndpoint GetRegion (string region) 
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
