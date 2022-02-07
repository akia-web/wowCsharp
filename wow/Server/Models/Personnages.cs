using System.Collections.Generic;

namespace wow.Server.Models
{
    public class APIResult
    {
        public List<Compte> wow_accounts;
    }

    public class Compte
    {
        public int id;
        public List<Personnages> characters;
    }

    public class Personnages
    {
        public int Id;
        public string name;
        public Race playable_race;
        public Realm realm;
        public Character character;
        public string contenu;

    }

    public class Character
    {
        public string href;
    }

    public class Race
    {
        public Dictionary<string, string> name;

        public string GetFR()
        {
            return (name["fr_FR"]);
        }
    }

    public class Realm
    {
        public Dictionary<string, string> name;

        public string GetFR()
        {
            return (name["fr_FR"]);
        }
    }
}


    /*$info->name = $personnages[$j]->{ 'name'};
                $info->reaml = $personnages[$j]->{ 'realm'}->{ 'name'}->{ 'fr_FR'};
                $info->classe = $personnages[$j]->{ 'playable_class'}->{ 'name'}->{ 'fr_FR'};
                $info->race = $personnages[$j]->{ 'playable_race'}->{ 'name'}->{ 'fr_FR'};
                $info->faction = $personnages[$j]->{ 'faction'}->{ 'name'}->{ 'fr_FR'};
                $info->level = $personnages[$j]->{ 'level'};
                $info->urlPersonnage =$personnages[$j]->{ 'character'}->{ 'href'};
                $info->imagePetite = "";
                $info->moyenneFace = "";
                $info->grande = "";
                $info->grandePNG = "";
                $info->personnageValide = true;*/