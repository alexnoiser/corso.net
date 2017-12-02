using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvcSuperheroes.Models
{
    public class SuperHero
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        //[DisplayName("El nome figo")] //* vedi spiegazione in fondo
        public string HeroName { get; set; }

        [MaxLength(50)]
        //[DisplayName("El nome che no conossi nisun")]
        public string SecretName { get; set; }

        [MaxLength(50)]
        //[DisplayName("Dove che el stà")]
        public string City { get; set; }

        [Range(0, int.MaxValue)]
        //[DisplayName("Quanto che el pesta")]
        public int Power { get; set; }

        //[DisplayName("El svola")]
        public bool CanFly { get; set; }

        //[DisplayName("Cossa nassi?")]
        public DateTime? Birth { get; set; }

        public ICollection<Villain> Villains { get; set; }
    }

    /*
     * Con l'attributo DisplayName,
     * quando C# deve recuperare il nome della proprietà,
     * invece di usare il nome vero utilizza la stringa
     * indicata nell'attributo.
     */
}
