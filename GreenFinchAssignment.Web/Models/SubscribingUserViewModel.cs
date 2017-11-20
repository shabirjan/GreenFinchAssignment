using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GreenFinchAssignment.Web.Models
{
    public class SubscribingUserViewModel
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email")]

        [Remote("EmailExists", "NewsLetter", HttpMethod = "POST", ErrorMessage = "Email already subscribed to newsletter.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("How did you hear about us?")]
        public int SubscribingSourceId { get; set; }


        [DisplayName("Joining Reason")]
        [DataType(DataType.MultilineText)]
        public string SubscribingReason { get; set; }
    }
}
