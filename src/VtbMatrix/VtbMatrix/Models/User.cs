using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VtbMatrix.Models
{
    /// <summary>
    /// Класс сопоставляется с таблицей пользователей.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        [Column("Password", TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        /// <summary>
        /// Роль пользователя: Заказчик или Исполнитель.
        /// </summary>
        [Column("Role", TypeName = "nvarchar(100)")]
        public string Role { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        [Column("LastName", TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        [Column("FirstName", TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        /// <summary>
        /// Путь к иконке пользователя.
        /// </summary>
        public string IconPath { get; set; }

        /// <summary>
        /// Количество монет.
        /// </summary>
        public uint CoinBalance { get; set; }

        /// <summary>
        /// Опыт всего (влияет на уровень).
        /// </summary>
        public uint TotalExperience { get; set; }

        /// <summary>
        /// Опыт за период(месяц), влияет на лигу.
        /// </summary>
        public uint PeriodExperience { get; set; }
    }
}
