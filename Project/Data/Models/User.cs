using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project.Data.Models
{
    public class User
    {
        public  int Id { get; set; }
        public  string UserName { get; set; }
        public  string Password { get; set; }
        //public byte[]   Salt { get; set; }
        //public byte[] Password { get; set; }
        public bool Status { get; set; }
        
        public class Map
        {
            public Map(EntityTypeBuilder<User> ebUser)
            {
                ebUser.HasKey(x => x.Id);
                ebUser.Property(x => x.UserName).HasColumnName("UserName").HasMaxLength(100);
                ebUser.Property(x => x.Password).HasColumnName("Password").HasMaxLength(100);
                ebUser.Property(x => x.Status).HasColumnType("bit");
            }
        }
    }
}