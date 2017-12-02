namespace WebMvcSuperheroes.ViewModels
{
    public class SuperHeroIndexViewModel
    {
        public int Id { get; set; }

        public string HeroName { get; set; }

        public string Power { get; set; }

        public bool CanFly { get; set; }

        public int VillainsToFight { get; set; }
    }
}
