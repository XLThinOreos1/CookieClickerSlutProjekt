using System.Text.Json;
namespace CookieClicker;

public class CookieButton : Interfaces.IClickable
{
    public static Texture2D ClickableCookie = Raylib.LoadTexture("textures/Cookie.png");
    GameStats.CookieStat myCookie = new();

    public void Click()
    {
        myCookie.CookieAmount++;
    }

    public bool IsHovering(Vector2 mousePos)
    {
        throw new NotImplementedException();
    }
}