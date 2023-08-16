using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vcommerce.Data.Models.Users;
using static VCommerce.Common.DataBaseValidations.BlogPostValidations;

namespace Vcommerce.Data.Models.Blog
{
    public class BlogPost
    {

        public BlogPost()
        {
            this.Id = Guid.NewGuid();
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required] 
        [MaxLength(MaxTitleLength)] 
        public string Title { get; set; } = null!;

        [Required]
        public DateTime DatePosted { get; set; }

        [Required]
        [MaxLength(MaxImageUrlLength)]
        public string PostMainPictureUrl { get; set; } = null!;

        [MaxLength(MaxImageUrlLength)]
        public string? PostMidSectionLeftImageUrl { get; set; }

        [MaxLength(MaxImageUrlLength)]
        public string? PostMidSectionRightImageUrl { get; set; }

        [Required]
        [MaxLength(MaxContextLength)]
        public string Context { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Author))]
        public Guid AuthorId { get; set; }

        public ApplicationUser Author { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}
