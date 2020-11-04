namespace File_Extension_Checker.assets
{
    class fileType
    {
        public string fileExtention { get; }
        public string fileHeader { get; }
        public fileType (string fE, string fH)
        {
            this.fileExtention = fE;
            this.fileHeader = fH;
        }
    }
}
