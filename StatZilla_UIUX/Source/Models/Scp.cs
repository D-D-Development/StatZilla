namespace StatZilla.Models
{
    public class Scp : Session
    {
        public bool IsActive { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public string Path { get; set; }
        public Scp() { }

        public Scp (string file, string u, string  pswd, string hostname, string destination)
        {
            sessionFilename = file;
            User = u;
            Password = pswd;
            Host = hostname;
            Path = destination;
        }
    }
}
