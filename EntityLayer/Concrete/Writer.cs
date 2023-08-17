using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using static System.Net.WebRequestMethods;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        public Writer()
        {
            Heading = new Collection<Heading>();
            contents = new Collection<Content>();
        }

        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(500)]
        //https://sosyalmedya.co/wp-content/uploads/2011/06/Facebook-Profil-Resimleri-940x470.jpg
        //"~/AdminLTE-3.0.4/Images/person.jpeg"
        public string WriterImage { get; set; } 
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(500)]
        public string WriterAbout { get; set; }
        [StringLength(200)]
        public string WriterTitle { get; set; }
        [StringLength(50)]
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }

        public ICollection<Heading> Heading { get; set; }
        public ICollection<Content> contents { get; set; }
    }
}
