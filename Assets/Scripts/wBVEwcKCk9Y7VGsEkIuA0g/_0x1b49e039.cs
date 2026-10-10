using UnityEngine;

/// <summary>
/// Solvability is proved BY CONSTRUCTION (C.11): build a solved scheme out of disjoint
/// adjacent swap pairs, read the permutation it realises, colour the emitters so that
/// scheme is a full solution, then undo it with S random player moves. Every scramble move
/// is its own inverse, so the level is always solvable in at most S swaps and the budget is
/// S + 3. Nothing is searched, so nothing can fail to converge.
/// </summary>
public sealed class _0x1b49e039
{
    private readonly _0x67292414 _0xbc42b37b = new _0x67292414(4);
    public static int ScrambleFor(int _0x7f43f6ac)
    {
        if (_0x7f43f6ac <= 0)
        {
            return 3;
        }

        if (_0x7f43f6ac <= 2)
        {
            return 4;
        }

        if (_0x7f43f6ac <= 5)
        {
            return 5;
        }

        if (_0x7f43f6ac <= 8)
        {
            return 6;
        }

        return 8;
    }

    public static int RowsFor(int _0x8924b788)
    {
        if (_0x8924b788 <= 0)
        {
            return 2;
        }

        if (_0x8924b788 <= 2)
        {
            return 3;
        }

        if (_0x8924b788 <= 5)
        {
            return 3;
        }

        return 4;
    }

    /// <summary>
    /// Random disjoint adjacent pairs per row. A pair (c, c+1) set to DivertRight/DivertLeft
    /// exchanges exactly those two flows, so the row is a permutation and no two flows ever
    /// merge in the SOLVED scheme.
    /// </summary>
    private void _0x00f75067(_0x644b9457 _0x479a531d, System.Random _0xbf661e01)
    {
        for (int _0x8e280311 = 0; _0x8e280311 < _0x479a531d.Rows; _0x8e280311++)
        {
            for (int _0xd2f94148 = 0; _0xd2f94148 < _0x644b9457.Channels; _0xd2f94148++)
            {
                _0x479a531d._0x393ee25b(_0x8e280311, _0xd2f94148, _0x644b9457.Straight);
            }

            int _0xf912b9fb = _0xbf661e01.Next(0, 2);
            while (_0xf912b9fb < _0x644b9457.Channels - 1)
            {
                if (_0xbf661e01.Next(0, 100) < 62)
                {
                    _0x479a531d._0x393ee25b(_0x8e280311, _0xf912b9fb, _0x644b9457.DivertRight);
                    _0x479a531d._0x393ee25b(_0x8e280311, _0xf912b9fb + 1, _0x644b9457.DivertLeft);
                    _0xf912b9fb += 2;
                }
                else
                {
                    _0xf912b9fb += 1;
                }
            }
        }
    }

    public const int TotalLevels = 12;
    public _0x644b9457 _0x09d51a76(int _0xdbf91c1f, int _0xe6c75a4c)
    {
        int _0x8f466ef7 = (_0xdbf91c1f * 7919) ^ (_0xe6c75a4c * 104729);
        System.Random _0xd05b7ef6 = new System.Random(_0x8f466ef7);
        int _0x28de0b47 = RowsFor(_0xdbf91c1f);
        int _0x75260af0 = ColoursFor(_0xdbf91c1f);
        int _0xdb6c0a9b = ScrambleFor(_0xdbf91c1f);
        _0x644b9457 _0x514a0019 = new _0x644b9457();
        _0x514a0019.LevelIndex = _0xdbf91c1f;
        _0x514a0019.Rows = _0x28de0b47;
        _0x514a0019.Cells = new int[_0x28de0b47 * _0x644b9457.Channels];
        _0x514a0019.SourceColour = new int[_0x644b9457.Channels];
        _0x514a0019.TargetColour = new int[_0x644b9457.Channels];
        _0x514a0019.ScrambleDepth = _0xdb6c0a9b;
        _0x514a0019.MoveLimit = _0xdb6c0a9b + 3;
        _0x514a0019.FillRate = FillRateFor(_0xdbf91c1f);
        _0x514a0019.Seed = _0x8f466ef7;
        this._0x00f75067(_0x514a0019, _0xd05b7ef6);
        this._0xbc42b37b._0xcd91fdf8(_0x514a0019);
        this._0xaf9a452e(_0x514a0019, _0xd05b7ef6, _0x75260af0);
        this._0x5ecc36b2(_0x514a0019, _0xd05b7ef6, _0xdb6c0a9b);
        {
#if B_LOGS
            {
                Debug.Log(_0xf3ebdc67._0xedb0e9d2(new byte[12] { 45, 26, 19, 0, 19, 26, 43, 86, 31, 18, 14, 75 }, 118) + _0xdbf91c1f + _0xf3ebdc67._0xedb0e9d2(new byte[9] { 16, 81, 68, 68, 85, 93, 64, 68, 13 }, 48) + _0xe6c75a4c + _0xf3ebdc67._0xedb0e9d2(new byte[6] { 92, 15, 25, 25, 24, 65 }, 124) + _0x8f466ef7 + _0xf3ebdc67._0xedb0e9d2(new byte[6] { 112, 34, 63, 39, 35, 109 }, 80) + _0x28de0b47 + _0xf3ebdc67._0xedb0e9d2(new byte[9] { 255, 188, 176, 179, 176, 170, 173, 172, 226 }, 223) + _0x75260af0 + _0xf3ebdc67._0xedb0e9d2(new byte[7] { 151, 192, 197, 216, 217, 208, 138 }, 183) + this._0xbc42b37b._0xc01493ed(_0x514a0019));
            }
#endif
        }

        return _0x514a0019;
    }

    /// <summary>
    /// Pick what each receiver wants (every colour of the palette slice shows up at least
    /// once), then give emitter c the colour of the receiver its flow currently reaches.
    /// The laid-out scheme is now a complete solution of the level.
    /// </summary>
    private void _0xaf9a452e(_0x644b9457 _0xa792870b, System.Random _0x026cd134, int _0x47026709)
    {
        for (int _0x708a4063 = 0; _0x708a4063 < _0x644b9457.Channels; _0x708a4063++)
        {
            _0xa792870b.TargetColour[_0x708a4063] = _0x708a4063 < _0x47026709 ? _0x708a4063 : _0x026cd134.Next(0, _0x47026709);
        }

        for (int _0xab872c92 = _0x644b9457.Channels - 1; _0xab872c92 > 0; _0xab872c92--)
        {
            int _0x20c3ce72 = _0x026cd134.Next(0, _0xab872c92 + 1);
            int _0x6d06d91e = _0xa792870b.TargetColour[_0xab872c92];
            _0xa792870b.TargetColour[_0xab872c92] = _0xa792870b.TargetColour[_0x20c3ce72];
            _0xa792870b.TargetColour[_0x20c3ce72] = _0x6d06d91e;
        }

        for (int _0x0a429f0a = 0; _0x0a429f0a < _0x644b9457.Channels; _0x0a429f0a++)
        {
            _0xa792870b.SourceColour[_0x0a429f0a] = _0xa792870b.TargetColour[this._0xbc42b37b._0xfab3d94d(_0x0a429f0a)];
        }
    }

    /// <summary>
    /// Insurance only: a hand-checked layout with three mismatched receivers, used when the
    /// scrambler somehow never lands inside the band. It is never the game, only the net.
    /// </summary>
    private void _0xe7d12ac9(_0x644b9457 _0xbea9cb43)
    {
        _0xbea9cb43.Rows = 2;
        _0xbea9cb43.Cells = new int[]
        {
            _0x644b9457.DivertRight,
            _0x644b9457.DivertLeft,
            _0x644b9457.Straight,
            _0x644b9457.DivertRight,
            _0x644b9457.DivertLeft,
            _0x644b9457.Straight,
            _0x644b9457.Straight,
            _0x644b9457.Straight,
            _0x644b9457.DivertRight,
            _0x644b9457.DivertLeft,
            _0x644b9457.Straight,
            _0x644b9457.Straight,
            _0x644b9457.DivertRight,
            _0x644b9457.DivertLeft
        };
        _0xbea9cb43.SourceColour = new int[]
        {
            0,
            1,
            0,
            1,
            2,
            1,
            2
        };
        _0xbea9cb43.TargetColour = new int[]
        {
            1,
            0,
            1,
            2,
            0,
            2,
            1
        };
        _0xbea9cb43.ScrambleDepth = 3;
        _0xbea9cb43.MoveLimit = 6;
    }

    /// <summary>
    /// Undo the solution with the player's own move (swap two neighbours in one row), then
    /// insist the result is genuinely unsolved but not hopeless: 2..5 starved or poisoned
    /// receivers. Re-scramble if it lands outside that band; the loop cannot run away
    /// because each pass starts from the solved board again.
    /// </summary>
    private void _0x5ecc36b2(_0x644b9457 _0x88905764, System.Random _0x2fdf9ada, int _0x4502113e)
    {
        int[] _0xac79a499 = (int[])_0x88905764.Cells.Clone();
        for (int _0xe880ab23 = 0; _0xe880ab23 < 20; _0xe880ab23++)
        {
            System.Array.Copy(_0xac79a499, _0x88905764.Cells, _0xac79a499.Length);
            for (int _0xea93aaa4 = 0; _0xea93aaa4 < _0x4502113e; _0xea93aaa4++)
            {
                int _0x9b27f3a0 = _0x2fdf9ada.Next(0, _0x88905764.Rows);
                int _0xd6f39738 = _0x2fdf9ada.Next(0, _0x644b9457.Channels - 1);
                _0x88905764._0xf1c388f5(_0x9b27f3a0, _0xd6f39738);
            }

            int _0x0dcbc7a3 = this._0xbc42b37b._0xc01493ed(_0x88905764);
            if (_0x0dcbc7a3 >= 2 && _0x0dcbc7a3 <= 5)
            {
                return;
            }
        }

        this._0xe7d12ac9(_0x88905764);
    }

    public static int ColoursFor(int _0x1c1bab87)
    {
        if (_0x1c1bab87 <= 2)
        {
            return 2;
        }

        if (_0x1c1bab87 <= 8)
        {
            return 3;
        }

        return 4;
    }

    public static float FillRateFor(int _0x9fa5238a)
    {
        if (_0x9fa5238a <= 2)
        {
            return 3.2f;
        }

        if (_0x9fa5238a <= 5)
        {
            return 3.0f;
        }

        if (_0x9fa5238a <= 8)
        {
            return 2.8f;
        }

        return 2.6f;
    }
}

internal static class _0xf3ebdc67
{
    internal static string _0xedb0e9d2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}