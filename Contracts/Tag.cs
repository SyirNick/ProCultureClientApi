using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Tag
    /// </summary>
    public class Tag
    {
        public Tag(int id, string name, string sysName, List<Category> categories, double rating)
        { 
            Id = id;
            Name = name;
            SysName = sysName;
            Categories = categories;
            Rating = rating;
        }

        /// <summary>
        /// Tag identifier
        /// </summary>
        [JsonProperty(PropertyName = "_Id")]
        public int Id { get; set; }

        /// <summary>
        /// Tag name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tag system name in PRO.Culture.RF
        /// </summary>
        public string SysName { get; set; }

        /// <summary>
        /// List of categories
        /// </summary>
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Tag rating
        /// </summary>
        public double Rating { get; set; }
    }
}
