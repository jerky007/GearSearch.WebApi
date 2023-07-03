namespace GearSearch.WebApi.DomainObjects
{
    public abstract class ItemBase
    {
        public string Name { get; set; }
        public string AreaName { get; set; }
        public string Keywords { get; set; }
        public string Level { get; set; }
        public string Material { get; set; }
        public string Rarity { get; set; }
        public string Weight { get; set; }
        public string Worth { get; set; }
    }
}
