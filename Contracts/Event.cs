using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Event
    /// </summary>
    public class Event
    {
        public Event(int id, string name, string description, Image image)
        { 
            Id = id;
            Name = name;
            Description = description;
            Image = image;
        }

        /// <summary>
        /// Event identifier
        /// </summary>
        [JsonProperty(PropertyName = "_Id")]
        public int Id { get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Event description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Event main image
        /// </summary>
        public Image Image { get; set; }
    }
}
