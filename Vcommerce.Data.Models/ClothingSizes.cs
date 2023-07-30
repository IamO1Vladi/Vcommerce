using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vcommerce.Data.Models.Enums;

using static VCommerce.Common.DataBaseValidations.ProductValidations;

namespace Vcommerce.Data.Models
{
    public class ClothingSizes
    {
        public ClothingSizes()
        {
            this.Id= Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [Required]
        public ClothesSizes Size { get; set; }

        [Required]
        [Range(minimum: MinQuantity, maximum: MaxQuantity)]
        public int SizeQuantity { get; set; }

        [Required]
        [ForeignKey(nameof(RelatedClothing))]
        public Guid ClothingId { get; set; }

        
        public virtual Clothes RelatedClothing { get; set; } = null!;
    }
}
