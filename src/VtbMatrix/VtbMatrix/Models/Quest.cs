using System;
using System.ComponentModel.DataAnnotations;

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
        public DateTime CreationDate { get; set; }
    }
}
