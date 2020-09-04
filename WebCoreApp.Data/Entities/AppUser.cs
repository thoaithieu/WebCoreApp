using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Data.Interfaces;

namespace WebCoreApp.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public AppUser()
        {

        }
        public AppUser(Guid id, string fullname, string address, string userName, string email, string phoneNumber,
            string avatar, string province, int districtId, string wardCode, Status status)
        {
            Id = id;
            FullName = fullname;
            Address = address;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            Avatar = avatar;
            Province = province;
            DistrictId = districtId;
            WardCode = wardCode;
            Status = status;
        }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public decimal Balance { get; set; }
        public string Avatar { get; set; }
        public string Province { get; set; }
        public int? DistrictId { get; set; }
        public string WardCode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}
