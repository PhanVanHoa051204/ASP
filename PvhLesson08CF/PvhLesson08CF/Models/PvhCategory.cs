using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PvhLesson08CF.Models
{
    /// <summary>
    /// tao cau truc bang du lieu
    /// </summary>
    public class PvhCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        // thuoc tinh the he
        public virtual ICollection<Pvhbook> Pvhbooks { get; set; }
    }
}