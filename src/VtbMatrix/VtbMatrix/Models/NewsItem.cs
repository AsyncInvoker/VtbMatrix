using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VtbMatrix.Models
{
    /// <summary>
    /// Класс сопоставляется с таблицей Лента новостей на главной странице.
    /// </summary>
    public class NewsItem
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Название новости.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание новости.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Путь к иконке новости.
        /// </summary>
        public string IconPath { get; set; }

        /// <summary>
        /// Дата появления новости.
        /// </summary>
        public DateTime PostDate { get; set; }
    }
}
