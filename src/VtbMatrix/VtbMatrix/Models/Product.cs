using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VtbMatrix.Models
{
    /// <summary>
    /// Товар для обмена на NFT или монетки.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Цена в монетках.
        /// </summary>
        public uint CoinPrice { get; set; }

        /// <summary>
        /// Цена в NFT-сертефикатах.
        /// </summary>
        public uint NftPrice { get; set; }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Путь к иконке товара.
        /// </summary>
        [Column("IconPath", TypeName = "text")]
        public string IconPath { get; set; }
    }
}
