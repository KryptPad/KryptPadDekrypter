using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace KryptPadWebApp.Models.Entities
{
    public class Profile
    {
        /// <summary>
        /// Gets or sets the Id of the profile
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the profile
        /// </summary>
        [Required]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the Key1 value of the profile
        /// </summary>
        [Required]
        public string? Key1 { get; set; }

        /// <summary>
        /// Gets or sets the Key2 value of the profile
        /// </summary>
        [Required]
        public string? Key2 { get; set; }

        /// <summary>
        /// List of categories under the profile
        /// </summary>
        public List<Category>? Categories { get; set; }
    }
}