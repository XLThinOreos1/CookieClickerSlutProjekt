global using Raylib_cs;
global using System.Numerics;
global using System.IO;
using GUI;

Raylib.InitWindow(1280, 720, "Clicker");
Raylib.SetTargetFPS(30);

while (!Raylib.WindowShouldClose())
{
    void Update()
    {
        GameTextures.Render();
    }
}

