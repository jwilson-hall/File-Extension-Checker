namespace File_Extension_Checker.assets
{
    class fileObject
    {
        public string fileExtension { get; set; }
        public string fileHeaderInfo { get; set; }
        public string fileDirectory { get; set; }

        public fileObject(string fExtension, string fDirectory, string? fHeader)
        {
            this.fileExtension = fExtension;
            this.fileDirectory = fDirectory;
            this.fileHeaderInfo = fHeader;
        }
    }
}
