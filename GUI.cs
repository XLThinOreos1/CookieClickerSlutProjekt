using CookieClicker;

namespace GUI;

public class GameTextures : Interfaces.IRenderable
{
    public static Texture2D ClickableCookie = Raylib.LoadTexture("textures/Cookie.png");

    public void Render()
    {
        Raylib.DrawTexture(CookieButton.ClickableCookie, 60, 100, Color.White);
    }
}