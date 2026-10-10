using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x56576ecc
{
    public static class _0x7463064a
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x2cde3fea
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0xad3b7799
    {
        public static int _0xcf449560
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x28d92d6b._0xed1460fd(new byte[5] { 163, 143, 137, 142, 147 }, 224)))
                    PlayerPrefs.SetInt(_0x28d92d6b._0xed1460fd(new byte[5] { 113, 93, 91, 92, 65 }, 50), 0);
                return PlayerPrefs.GetInt(_0x28d92d6b._0xed1460fd(new byte[5] { 247, 219, 221, 218, 199 }, 180));
            }

            set
            {
                PlayerPrefs.SetInt(_0x28d92d6b._0xed1460fd(new byte[5] { 102, 74, 76, 75, 86 }, 37), value);
                _0x58a96848.Instance._0x6eed6489();
            }
        }
    }

    public class _0x21397b8a
    {
        private static readonly _0x21397b8a _0xbcb8730d = new();
        public static readonly _0x21397b8a[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xbcb8730d,
            _0xbcb8730d,
            _0xbcb8730d,
        };
        private int _0x8e01797b => 0;
        private int _0x2f01d779 => 10;
        private string _0x385b7959 => _0x28d92d6b._0xed1460fd(new byte[4] { 175, 135, 140, 151 }, 226);
        private string _0x68e4d843 => _0x28d92d6b._0xed1460fd(new byte[8] { 88, 81, 66, 81, 88, 111, 36, 105 }, 20);

        private int _0x649b00ee
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x28d92d6b._0xed1460fd(new byte[25] { 149, 163, 164, 164, 179, 184, 162, 145, 186, 185, 180, 183, 186, 149, 190, 183, 166, 162, 179, 164, 159, 184, 178, 179, 174 }, 214)))
                    PlayerPrefs.SetInt(_0x28d92d6b._0xed1460fd(new byte[25] { 220, 234, 237, 237, 250, 241, 235, 216, 243, 240, 253, 254, 243, 220, 247, 254, 239, 235, 250, 237, 214, 241, 251, 250, 231 }, 159), 0);
                return PlayerPrefs.GetInt(_0x28d92d6b._0xed1460fd(new byte[25] { 252, 202, 205, 205, 218, 209, 203, 248, 211, 208, 221, 222, 211, 252, 215, 222, 207, 203, 218, 205, 246, 209, 219, 218, 199 }, 191));
            }

            set => PlayerPrefs.SetInt(_0x28d92d6b._0xed1460fd(new byte[25] { 53, 3, 4, 4, 19, 24, 2, 49, 26, 25, 20, 23, 26, 53, 30, 23, 6, 2, 19, 4, 63, 24, 18, 19, 14 }, 118), value);
        }

        public int _0xa40600fd
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x385b7959}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x385b7959}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x385b7959}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x385b7959}CurrentLevelIndex", value);
        }

        public int _0x25ab9538
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x385b7959}BestScore"))
                    this._0x25ab9538 = 0;
                return PlayerPrefs.GetInt($"{this._0x385b7959}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x385b7959}BestScore", value);
        }

        public bool _0x20496c73
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x385b7959}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x385b7959}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x385b7959}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x385b7959}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x3578949a
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x28d92d6b
{
    internal static string _0xed1460fd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}