using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.Media;
using AlmostList.Client.Models.Properties.User;
using Android.Accounts;
using Android.Media;
using Android.Text;
using Java.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Provider.ContactsContract.CommonDataKinds;

namespace AlmostList.Client.Objects.Models.Review
{
    public class Review
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public int? MediaId { get; set; }
        public MediaType? MediaType { get; set; }
        public string? Summary { get; set; }
        public string? Body { get; set; }
        public int? Rating { get; set; }
        public int? RatingAmount { get; set; }
        public ReviewRating? UserRating { get; set; }
        public int? Score { get; set; }
        public bool? Private { get; set; }
        public string? SiteUrl { get; set; }
        public int? CreatedAt { get; set; }
        public int? UpdatedAt { get; set; }
        public User? User { get; set; }
        public Media? Media { get; set; }
    }
}
