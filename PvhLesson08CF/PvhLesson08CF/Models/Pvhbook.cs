using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PvhLesson08CF.Models
{
    /// <summary>
    /// Tao ra cau truc bang book
    /// </summary>
    public class Pvhbook
    {
        [Key]
        public int PvhbookId { get; set; }
        public string PvhTitle { get; set; }
        public string PvhAuthor { get; set; }
        public int PvhYear { get; set; }
        public string PvhPicture { get; set; }
        public int PvhCategoryId { get; set; }
        // thuoc tinh quan he
        public virtual PvhCategory PvhCategory { get; set; }
    }
}