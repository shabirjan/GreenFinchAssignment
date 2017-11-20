using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GreenFinchAssignment.Web.Models
{
    public class SubscribingSourceViewModel
    {
        [Key]
        public int SubscribingSourceId { get; set; }

        [DisplayName("Subscribing Source")]
        public string Name { get; set; }



    }
}
