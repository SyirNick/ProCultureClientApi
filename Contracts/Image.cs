namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Main image
    /// </summary>
    public class Image
    {
        public Image(string name, string realName, string author, string source)
        { 
            Name = name;
            RealName = realName;
            Author = author;
            Source = source;
        }

        /// <summary>
        /// Image name on PRO.Culture.RF
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Base image name
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// Image author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Image link
        /// </summary>
        public string Source { get; set; }
    }
}
