using TMPro;
using UnityEngine;

/// <summary>
/// Every TMP label this game creates goes through here (CLAUDE-unity.md C.10/C.12/C.14):
/// word wrap OFF (breaks are hand placed with \n), autosize ALWAYS on, a readable
/// fontSizeMin, a LIGHT face colour and a per-instance material whose outline contrasts
/// with that face.
/// </summary>
public static class _0x3ee0bdf3
{
    public static void SetText(TMP_Text _0xfe428e73, string _0x69ca3fc6)
    {
        if (_0xfe428e73 != null)
        {
            _0xfe428e73.text = _0x69ca3fc6;
        }
    }

    public const float UiFloor = 28f;
    public static void Apply(TMP_Text _0x3579b377, string _0x037128ff, Color _0xf1f6f803, float _0xd3449778, float _0xd1f9c3ec)
    {
        if (_0x3579b377 == null)
        {
            return;
        }

        float _0x400d02c5 = _0xd3449778 < UiFloor ? UiFloor : _0xd3449778;
        float _0x88a382d5 = _0xd1f9c3ec < _0x400d02c5 ? _0x400d02c5 : _0xd1f9c3ec;
        _0x3579b377.text = _0x037128ff;
        _0x3579b377.textWrappingMode = TextWrappingModes.NoWrap;
        _0x3579b377.overflowMode = TextOverflowModes.Overflow;
        _0x3579b377.enableAutoSizing = true;
        _0x3579b377.fontSizeMin = _0x400d02c5;
        _0x3579b377.fontSizeMax = _0x88a382d5;
        _0x3579b377.fontSize = _0x88a382d5;
        _0x3579b377.alignment = TextAlignmentOptions.Center;
        _0x3579b377.richText = false;
        _0x3579b377.raycastTarget = false;
        _0x3579b377.color = _0xf1f6f803;
        ApplyOutline(_0x3579b377, _0xf1f6f803);
    }

    /// <summary>
    /// Reading fontMaterial clones the shared asset, so the project-wide material stays
    /// intact while this one label gets an outline that cannot blend into its own face.
    /// </summary>
    public static void ApplyOutline(TMP_Text _0xdeb81ce6, Color _0x196b6d96)
    {
        // A TMP component added to an INACTIVE hierarchy never runs Awake, so it has no font
        // and no shared material — reading fontMaterial there throws and unwinds the caller.
        if (_0xdeb81ce6 == null || _0xdeb81ce6.font == null)
        {
            return;
        }

        Material _0xe44985e1 = _0xdeb81ce6.fontMaterial;
        if (_0xe44985e1 == null)
        {
            return;
        }

        float _0x2711fbb2 = (0.299f * _0x196b6d96.r) + (0.587f * _0x196b6d96.g) + (0.114f * _0x196b6d96.b);
        Color _0x5ed500ee = _0x2711fbb2 < 0.5f ? _0xf2af3007.TextPrimary : _0xf2af3007.Ink;
        _0xe44985e1.EnableKeyword(_0xc1317e05._0x27c3057c(new byte[10] { 69, 95, 94, 70, 67, 68, 79, 85, 69, 68 }, 10));
        _0xe44985e1.SetColor(ShaderUtilities.ID_OutlineColor, _0x5ed500ee);
        _0xe44985e1.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.22f);
        _0xe44985e1.SetFloat(ShaderUtilities.ID_FaceDilate, 0.18f);
    }
}

internal static class _0xc1317e05
{
    internal static string _0x27c3057c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}