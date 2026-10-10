/// <summary>
/// Resolves the whole scheme in one pass: a flow enters column c at the top, each row's
/// deflector nudges it one channel left or right, and after the last row it lands in some
/// receiver. Two flows may land in the SAME receiver — that is a legal, punishable state,
/// not a bug, so nothing here tries to prevent it.
/// </summary>
public sealed class _0x67292414
{
    private readonly int[] _0x031d25c7;
    public void _0xcd91fdf8(_0x644b9457 _0x9ba0540d)
    {
        for (int _0x8c2f0ad0 = 0; _0x8c2f0ad0 < _0x644b9457.Channels; _0x8c2f0ad0++)
        {
            int _0xeff73d84 = _0x8c2f0ad0;
            this._0x031d25c7[_0x8c2f0ad0 * (this._0xa3e62e64 + 1)] = _0xeff73d84;
            for (int _0x9b47b446 = 0; _0x9b47b446 < _0x9ba0540d.Rows; _0x9b47b446++)
            {
                _0xeff73d84 = Shift(_0x9ba0540d._0xc88631c2(_0x9b47b446, _0xeff73d84), _0xeff73d84);
                this._0x031d25c7[(_0x8c2f0ad0 * (this._0xa3e62e64 + 1)) + _0x9b47b446 + 1] = _0xeff73d84;
            }

            for (int _0x243830dc = _0x9ba0540d.Rows; _0x243830dc < this._0xa3e62e64; _0x243830dc++)
            {
                this._0x031d25c7[(_0x8c2f0ad0 * (this._0xa3e62e64 + 1)) + _0x243830dc + 1] = _0xeff73d84;
            }

            this._0xdbe731ca[_0x8c2f0ad0] = _0xeff73d84;
        }
    }

    public _0x67292414(int _0x0c2c0321)
    {
        this._0xa3e62e64 = _0x0c2c0321 < 1 ? 1 : _0x0c2c0321;
        this._0x031d25c7 = new int[_0x644b9457.Channels * (this._0xa3e62e64 + 1)];
    }

    public int _0x38dc308a
    {
        get
        {
            return this._0xa3e62e64;
        }
    }

    /// <summary>Column the flow of <paramref name = "channel"/> occupies above row <paramref name = "row"/>.</summary>
    public int _0xc977bac9(int _0xb823a46a, int _0x609721a6)
    {
        return this._0x031d25c7[(_0xb823a46a * (this._0xa3e62e64 + 1)) + _0x609721a6];
    }

    private readonly int _0xa3e62e64;
    public static int Shift(int _0xa48084fc, int _0xa2da82f4)
    {
        if (_0xa48084fc == _0x644b9457.DivertRight)
        {
            return _0xa2da82f4 + 1 > _0x644b9457.Channels - 1 ? _0x644b9457.Channels - 1 : _0xa2da82f4 + 1;
        }

        if (_0xa48084fc == _0x644b9457.DivertLeft)
        {
            return _0xa2da82f4 - 1 < 0 ? 0 : _0xa2da82f4 - 1;
        }

        return _0xa2da82f4;
    }

    /// <summary>Receiver index fed by channel <paramref name = "channel"/>.</summary>
    public int _0xfab3d94d(int _0xaafcd2c1)
    {
        return this._0xdbe731ca[_0xaafcd2c1];
    }

    private readonly int[] _0xdbe731ca = new int[_0x644b9457.Channels];
    /// <summary>How many receivers are currently fed something other than their own colour.</summary>
    public int _0xc01493ed(_0x644b9457 _0x15660f77)
    {
        this._0xcd91fdf8(_0x15660f77);
        int _0xae68025d = 0;
        for (int _0x5272048a = 0; _0x5272048a < _0x644b9457.Channels; _0x5272048a++)
        {
            bool _0xf96e84c1 = false;
            bool _0x148c8354 = false;
            for (int _0x509450d3 = 0; _0x509450d3 < _0x644b9457.Channels; _0x509450d3++)
            {
                if (this._0xdbe731ca[_0x509450d3] != _0x5272048a)
                {
                    continue;
                }

                _0xf96e84c1 = true;
                if (_0x15660f77.SourceColour[_0x509450d3] == _0x15660f77.TargetColour[_0x5272048a])
                {
                    _0x148c8354 = true;
                }
            }

            if (!_0xf96e84c1 || !_0x148c8354)
            {
                _0xae68025d++;
            }
        }

        return _0xae68025d;
    }
}