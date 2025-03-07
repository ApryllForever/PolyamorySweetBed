namespace PolyamorySweetBed
{
    public class PolyamorySweetBedAPI
    {
        public int GetBedWidth()
        {
            if (!ModEntry.Config.EnableMod)
                return 3;
            return ModEntry.Config.BedWidth;
        }
    }
}