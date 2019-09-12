using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MetadataEntityModel
{
    /// <summary>
    /// Единица измерения
    /// </summary>
    public class UnitModel : MetadataEntityModel.RootEntityModel
    {
        /// <summary>
        /// Короткое имя
        /// </summary>
        [Display(Name ="Сокращённое наименование")]
        public string ShortName { get; set; }

        /// <summary>
        /// Полное имя
        /// </summary>
        [Display(Name = "Полное наименование")]
        public string FullName { get; set; }

        /// <summary>
        /// Связаные товары
        /// </summary>
        public List<ProductModel> Products { get; set; }
    }
}
