// Model for User Purchase Information

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OnlineBookStore.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line.")]
        public string AddressLines1 { get; set; }

        public string AddressLines2 { get; set; }

        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a city name.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state.")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country.")]
        public string Country { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter an email address.")]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [BindNever]
        public bool OrderShipped { get; set; }
    }
}
