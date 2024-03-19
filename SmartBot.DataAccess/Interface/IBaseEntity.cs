using System.ComponentModel.DataAnnotations;

namespace SmartBot.DataAccess.Interface
{
    public interface IBaseEntity
    {
        [Key]
        int Id { get; set; }
        int Deleted { get; set; }

    }
}