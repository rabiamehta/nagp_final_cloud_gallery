using System;
using System.ComponentModel.DataAnnotations;

namespace nagp_gallery.Models
{
    public class Image
    {
        public Image(String name,String size)
        {
            this.Id = new Random().Next();
            this.Name = name;
            this.Size = size;
            this.CreatedDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Size { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}
