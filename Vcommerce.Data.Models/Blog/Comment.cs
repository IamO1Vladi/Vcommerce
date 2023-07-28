using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VCommerce.Common.DataBaseValidations.CommentsValidations;

namespace Vcommerce.Data.Models.Blog
{
    public class Comment
    {

        public Comment()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(MaxAvatarUrlLength)]
        public string AvatarImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime DatePosted { get; set; }

        [Required]
        [ForeignKey(nameof(RelatedPost))]
        public Guid RelatedPostGuid { get; set; }

        public virtual BlogPost RelatedPost { get; set; }

        //Creating a self-referencing relationship for replies logic

        [ForeignKey(nameof(ParentComment))]
        public Guid? ParentCommentId { get; set; }

        public virtual Comment ParentComment { get; set; }

        public virtual ICollection<Comment> Replies { get; set; }



    }
}
