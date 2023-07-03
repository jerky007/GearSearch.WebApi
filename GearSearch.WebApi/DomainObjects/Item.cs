namespace GearSearch.WebApi.DomainObjects
{
    public class Item
    {
        public Affect[] Affects { get; set; }
        public string Name { get; set; }
        public string AreaName { get; set; }
        public string Keywords { get; set; }
        public string Level { get; set; }
        public string Material { get; set; }
        public string Rarity { get; set; }
        public string Weight { get; set; }
        public string Worth { get; set; }
        public string DamDice { get; set; }
        public string WeaponAttack { get; set; }
        public string WeaponAverage { get; set; }
        public string WeaponFlags { get; set; }
        public string WeaponType { get; set; }
        public string ArmorClass { get; set; }
    }
}
