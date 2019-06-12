namespace Trestlebridge.Interfaces
{
    public interface IChicken: IResource
    {
        double GrassPerDay { get; set; }
        void Graze();
    }

};