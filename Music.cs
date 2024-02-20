public class GameMusic
{
    // Gör bgm till en Music variabel som innehåller musiken "bgm1.mp3"
    public static Music bgm = Raylib.LoadMusicStream("bgm/monkey.wav");

    // Ändrar volymet så det inte blir för högt eller lågt
    private static void SetSound()
    {
        Raylib.SetMusicVolume(bgm, (float)0.5);
    }
}