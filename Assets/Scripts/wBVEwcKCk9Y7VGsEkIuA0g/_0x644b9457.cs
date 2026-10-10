/// <summary>
/// One generated grid: the deflector rows, the colour of every emitter, the colour every
/// receiver wants, and the budget the player gets. Plain data, no Unity types, so the
/// generator and the simulator can be exercised without a scene.
/// </summary>
public sealed class _0x644b9457
{
    public int Rows;
    public void _0x393ee25b(int _0x3bfd3633, int _0x889c708f, int _0x05522240)
    {
        this.Cells[(_0x3bfd3633 * Channels) + _0x889c708f] = _0x05522240;
    }

    public const int Channels = 7;
    public int ScrambleDepth;
    public float FillRate;
    public int[] TargetColour; // per receiver
    public const int DivertRight = 1;
    public void _0xf1c388f5(int _0xcad8b9d3, int _0x72dd6f2e)
    {
        int _0xbe617e3b = (_0xcad8b9d3 * Channels) + _0x72dd6f2e;
        int _0x198c4959 = _0xbe617e3b + 1;
        int _0x3ea6c9e1 = this.Cells[_0xbe617e3b];
        this.Cells[_0xbe617e3b] = this.Cells[_0x198c4959];
        this.Cells[_0x198c4959] = _0x3ea6c9e1;
    }

    public int[] SourceColour; // per channel, index into PaletteBook.FlowColours()
    public const int DivertLeft = 2;
    public int MoveLimit;
    public const int Straight = 0;
    public int _0xc88631c2(int _0xe8c8a1e8, int _0x01cce520)
    {
        return this.Cells[(_0xe8c8a1e8 * Channels) + _0x01cce520];
    }

    public int LevelIndex;
    public int Seed;
    public int[] Cells; // Rows * Channels, row-major
}