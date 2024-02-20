namespace Interfaces;

public interface IClickable
{
    public bool IsHovering(Vector2 mousePos);
    public void Click();
}

public interface IRenderable
{
    public void Render();
}

public interface IDrawable
{
    public void Draw();
}