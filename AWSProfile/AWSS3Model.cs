using System.IO;

namespace AWSProfile
{
    public class AWSS3Model
    {
        private string _AWSS3Key;
        private string _SourceKey;
        private string _DestinationKey;
        public string AWSAccessKey { get; set; }
        public string AWSSecretKey { get; set; }
        public string AWSBucketName { get; set; }
        public string AWSS3Key { get { return ((string.IsNullOrEmpty(this.AWSRootFolder) || string.IsNullOrEmpty(this._AWSS3Key)) ? string.Empty : this.AWSRootFolder + @"/" + this._AWSS3Key); } set { this._AWSS3Key = value; } }
        public string AWSEndPoint { get; set; }
        public string AWSHost { get; set; }
        public string AWSRootFolder { get; set; }
        public string SourceBucket { get; set; }
        public string DestinationBucket { get; set; }
        public string StorageServer { get; set; }
        public Stream InputStream { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileExt { get; set; }
        public string FilePath { get; set; }
        public string FileLastModified { get; set; }
        public string FileOwner { get; set; }
        public long FileSize { get; set; }
        public string AWSUrl { get; set; }
        public string AWSFolderKey { get; set; }
        public string DirectoryName { get; set; }
        public string FolderName { get; set; }
        public string SourceKey { get { return (this._SourceKey); } set { this._SourceKey = value; } }
        public string DestinationKey { get { return (this._DestinationKey); } set { this._DestinationKey = value; } }
        public string SourceDirectoryUrl { get; set; }
        public string DestinationDirectoryUrl { get; set; }
        public Stream OutputStream { get; set; }
        public string LocalArchivePath { get; set; }
    }
}
