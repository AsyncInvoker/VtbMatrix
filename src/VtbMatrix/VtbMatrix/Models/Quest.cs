using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VtbMatrix.Models
{
    /// <summary>
    /// Задание для сотрудников.
    /// </summary>
    public class Quest
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Название задания.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание задания.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Путь к иконке задания.
        /// </summary>
        public string IconPath { get; set; }

        /// <summary>
        /// Дата создания задания.
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
