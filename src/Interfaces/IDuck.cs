namespace Trestlebridge.Interfaces
{
    public interface IDuck: IResource
    {
        double GrassPerDay { get; set; }
        void Graze();
    }

};