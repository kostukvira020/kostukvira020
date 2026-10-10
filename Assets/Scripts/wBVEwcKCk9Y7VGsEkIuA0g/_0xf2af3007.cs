using UnityEngine;

/// <summary>
/// RETRO_NEON palette, accent values taken verbatim from the brief.
/// Every field is initialised from LITERALS ONLY and never reads another field or
/// method of this type: Plana reorders static declarations and encrypts strings, so a
/// field that depends on a sibling can run before it exists (CLAUDE-unity.md C.52).
/// Grouped arrays are therefore built by a METHOD, on demand, not by a field.
/// </summary>
public static class _0xf2af3007
{
    public static readonly Color TextPrimary = new Color(0.961f, 0.945f, 0.910f, 1f);
    /// <summary>The four flow colours, rebuilt per call from literals (see C.52).</summary>
    public static Color[] FlowColours()
    {
        return new Color[]
        {
            new Color(0.235f, 0.337f, 0.808f, 1f),
            new Color(0.157f, 0.780f, 0.788f, 1f),
            new Color(0.957f, 0.808f, 0.275f, 1f),
            new Color(0.941f, 0.392f, 0.486f, 1f)
        };
    }

    public static readonly Color Shade = new Color(0.024f, 0.039f, 0.086f, 1f);
    public static readonly Color AccentRose = new Color(0.941f, 0.392f, 0.486f, 1f);
    public static readonly Color Line = new Color(0.235f, 0.337f, 0.808f, 1f);
    public static readonly Color TextMuted = new Color(0.624f, 0.690f, 0.847f, 1f);
    public static readonly Color Surface2 = new Color(0.118f, 0.153f, 0.278f, 1f);
    public static Color Flow(int _0x69216d98)
    {
        Color[] _0xbb9c7a88 = FlowColours();
        if (_0x69216d98 < 0)
        {
            _0x69216d98 = 0;
        }

        return _0xbb9c7a88[_0x69216d98 % _0xbb9c7a88.Length];
    }

    public static Color WithAlpha(Color _0x9735ffce, float _0xcac5d98a)
    {
        return new Color(_0x9735ffce.r, _0x9735ffce.g, _0x9735ffce.b, _0xcac5d98a);
    }

    public static readonly Color BgDeep = new Color(0.063f, 0.082f, 0.169f, 1f);
    public static readonly Color Ink = new Color(0.039f, 0.059f, 0.122f, 1f);
    public static readonly Color AccentCyan = new Color(0.157f, 0.780f, 0.788f, 1f);
    public static readonly Color Surface = new Color(0.086f, 0.114f, 0.220f, 1f);
    public static readonly Color AccentAmber = new Color(0.957f, 0.808f, 0.275f, 1f);
}