using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookRecomendationWebApp.Models
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookViewModel
    {
        [DisplayName("authorname")]
        [Required(ErrorMessage = "please enter the author name")]
        [RegularExpression(@"^[a-zA-z]+$", ErrorMessage = "author name can have only english alphabet")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "author name contain minimum 10 alphabets")]

        public string authorName { get; set; }

        [DisplayName("authorID")]
        [Required(ErrorMessage = "please enter authorID")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "authorid can have only numbers")]
        [MinLength(50, MinimumLength = 10, ErrorMessage = "authorid contain minimum 10 numbers")]
        public  int authorID { get; set; }

    }
}