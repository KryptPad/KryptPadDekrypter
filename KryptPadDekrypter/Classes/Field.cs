﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace KryptPadWebApp.Models.Entities
{
    public class Field
    {
        /// <summary>
        /// Gets or sets the Id of the field
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the field. e.g Password
        /// </summary>
        [Required]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the Base64 encoded cipher text
        /// </summary>
        public string? Value { get; set; }

    }
}