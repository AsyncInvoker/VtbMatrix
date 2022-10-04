using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VtbMatrix.Models
{
    /// <summary>
    /// NFT-сертефикат.
    /// </summary>
    public class NftCertificate
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
        /// BlockChain сертефиката.
        /// </summary>
        public string BlockChain { get; set; }

        /// <summary>
        /// TokenId сертефиката.
        /// </summary>
        public string TokenId { get; set; }

        /// <summary>
        /// Путь к иконке Сертефиката.
        /// </summary>
        public string IconPath { get; set; }
    }
}
