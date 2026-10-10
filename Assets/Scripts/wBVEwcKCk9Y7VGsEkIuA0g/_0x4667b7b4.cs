using UnityEngine;

/// <summary>
/// Player progress in PlayerPrefs. Every key literal lives INSIDE the method that uses it,
/// never in a static field: Plana turns string constants into runtime-decrypted fields and
/// reorders declarations, which kills types whose statics depend on each other (C.52).
/// </summary>
public static class _0x4667b7b4
{
    public static int SelectedLevel()
    {
        string _0x3c454f78 = _0x9cb0000f._0x25a52fea(new byte[17] { 48, 26, 25, 1, 37, 19, 26, 19, 21, 2, 19, 18, 58, 19, 0, 19, 26 }, 118);
        int _0x0733f2dc = PlayerPrefs.GetInt(_0x3c454f78, 0);
        return Clamp(_0x0733f2dc);
    }

    public static void Unlock(int _0x248edb8c)
    {
        string _0xc00f5dba = _0x9cb0000f._0x25a52fea(new byte[17] { 10, 32, 35, 59, 25, 34, 32, 35, 47, 39, 41, 40, 0, 41, 58, 41, 32 }, 76);
        int _0x4fc51f82 = Clamp(_0x248edb8c);
        if (_0x4fc51f82 > UnlockedLevel())
        {
            PlayerPrefs.SetInt(_0xc00f5dba, _0x4fc51f82);
            PlayerPrefs.Save();
        }
    }

    public static int Stars(int _0x771b7b9b)
    {
        int _0x3c3a2b53 = BestEfficiency(_0x771b7b9b);
        if (_0x3c3a2b53 <= 0)
        {
            return 0;
        }

        return StarsFor(_0x3c3a2b53);
    }

    public static int UnlockedLevel()
    {
        string _0x14b8df5b = _0x9cb0000f._0x25a52fea(new byte[17] { 53, 31, 28, 4, 38, 29, 31, 28, 16, 24, 22, 23, 63, 22, 5, 22, 31 }, 115);
        int _0xd251b76b = PlayerPrefs.GetInt(_0x14b8df5b, 0);
        return Clamp(_0xd251b76b);
    }

    public static void RecordEfficiency(int _0xe87dd825, int _0xf6813a36)
    {
        string _0xa55b5f50 = _0x9cb0000f._0x25a52fea(new byte[11] { 3, 41, 42, 50, 7, 32, 54, 49, 0, 35, 35 }, 69) + Clamp(_0xe87dd825);
        if (_0xf6813a36 > PlayerPrefs.GetInt(_0xa55b5f50, 0))
        {
            PlayerPrefs.SetInt(_0xa55b5f50, _0xf6813a36);
            PlayerPrefs.Save();
        }
    }

    /// <summary>
    /// A fresh attempt number every time a grid is entered, so replaying the same grid deals a
    /// different crossing pattern instead of the identical board (C.11).
    /// </summary>
    public static int NextAttempt(int _0xc05e62c1)
    {
        string _0x11ae199f = _0x9cb0000f._0x25a52fea(new byte[11] { 142, 164, 167, 191, 137, 188, 188, 173, 165, 184, 188 }, 200) + Clamp(_0xc05e62c1);
        int _0x6967900a = PlayerPrefs.GetInt(_0x11ae199f, 0) + 1;
        if (_0x6967900a > 100000)
        {
            _0x6967900a = 1;
        }

        PlayerPrefs.SetInt(_0x11ae199f, _0x6967900a);
        PlayerPrefs.Save();
        return _0x6967900a;
    }

    public static int BestOverall()
    {
        int _0x5f749d87 = 0;
        for (int _0xc101017d = 0; _0xc101017d < _0x1b49e039.TotalLevels; _0xc101017d++)
        {
            int _0x768103e8 = BestEfficiency(_0xc101017d);
            if (_0x768103e8 > _0x5f749d87)
            {
                _0x5f749d87 = _0x768103e8;
            }
        }

        return _0x5f749d87;
    }

    public static int BestEfficiency(int _0x14765b4e)
    {
        string _0x6fb80503 = _0x9cb0000f._0x25a52fea(new byte[11] { 159, 181, 182, 174, 155, 188, 170, 173, 156, 191, 191 }, 217) + Clamp(_0x14765b4e);
        return PlayerPrefs.GetInt(_0x6fb80503, 0);
    }

    public static int StarsFor(int _0xbb19ec35)
    {
        if (_0xbb19ec35 >= 90)
        {
            return 3;
        }

        return _0xbb19ec35 >= 60 ? 2 : 1;
    }

    private static int Clamp(int _0x9c9386e4)
    {
        if (_0x9c9386e4 < 0)
        {
            return 0;
        }

        return _0x9c9386e4 > _0x1b49e039.TotalLevels - 1 ? _0x1b49e039.TotalLevels - 1 : _0x9c9386e4;
    }

    public static void SelectLevel(int _0x882a61ad)
    {
        string _0xfd3270ed = _0x9cb0000f._0x25a52fea(new byte[17] { 252, 214, 213, 205, 233, 223, 214, 223, 217, 206, 223, 222, 246, 223, 204, 223, 214 }, 186);
        PlayerPrefs.SetInt(_0xfd3270ed, Clamp(_0x882a61ad));
        PlayerPrefs.Save();
    }
}

internal static class _0x9cb0000f
{
    internal static string _0x25a52fea(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}