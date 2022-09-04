using UnityEngine.UI;

namespace Props.Domains.Games
{
    public interface IGame
    {
        string GetName();
        string GetDescription();
        Image GetIcon();
    }
}