using API_Overtime.Utilities.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Overtime.Models
{
    [Table("tb_m_roles")]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [Column("name", TypeName = "varchar(20)")]
        public string Name { get; set; }

        //kardinalitas
        [JsonIgnore]
        public ICollection<AccountRole> AccountRoles { get; set; }
    }
}
