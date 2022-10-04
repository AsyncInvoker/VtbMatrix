using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VtbMatrix.Models
{
    /// <summary>
    /// Класс сопоставляется с таблицей История.
    /// </summary>
    public class HistoryLine
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор пользователя, кому принадлежит строка истории.
        /// </summary>
        public long UserId { get; set; }

        [ForeignKey("Id")]
        public User User { get; set; }

        /// <summary>
        /// Описание события.
        /// </summary>
        public string Description { get; set; }
    }
}
