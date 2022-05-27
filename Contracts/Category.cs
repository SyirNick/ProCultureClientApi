namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Category
    /// </summary>
    public class Category
    {
        public Category(string name, string sysName)
        {
            Name = name;
            SysName = sysName;
        }

        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Category system name
        /// </summary>
        public string SysName { get; set; }
    }
}
