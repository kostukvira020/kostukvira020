using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game scene's own HUD (C.2): chips for level / swaps / locked receivers, a Back and a
/// Pause target, the permanent gesture hint demanded by C.6, and one readout under each
/// receiver. Nothing here reuses a template placeholder — the template HUD is switched off
/// wholesale by the director before this builds.
/// </summary>
public sealed class _0xeb0d5652 : MonoBehaviour
{
    [SerializeField]
    private Sprite _roundPlate;
    private RectTransform _0x6593ad5c;
    private TextMeshProUGUI _0xb827519b;
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x92b5baa7()
    {
        if (this._director != null)
        {
            this._director._0x5b2708db();
        }
    }

    [SerializeField]
    private Sprite _pauseIcon;
    private TextMeshProUGUI _0xe735d8c0;
    public void _0x69836b6b(int _0x4a86a728)
    {
        _0x3ee0bdf3.SetText(this._0xe735d8c0, _0x69ab0399._0x870f6746(new byte[7] { 209, 210, 222, 214, 216, 217, 189 }, 157) + _0x4a86a728 + _0x69ab0399._0x870f6746(new byte[1] { 125 }, 82) + _0x644b9457.Channels);
    }

    public void _0x8509887c(int _0xce5d9f9e)
    {
        _0x3ee0bdf3.SetText(this._0xb827519b, _0x69ab0399._0x870f6746(new byte[5] { 64, 85, 78, 67, 39 }, 7) + _0xce5d9f9e);
    }

    public void _0x0c285c9f(int _0x2aa5b78a, string _0xfc2a0f0a, Color _0xed6831fb)
    {
        if (_0x2aa5b78a < 0 || _0x2aa5b78a >= this._0x285729f4.Length)
        {
            return;
        }

        TextMeshProUGUI _0x483b2a74 = this._0x285729f4[_0x2aa5b78a];
        if (_0x483b2a74 == null)
        {
            return;
        }

        _0x483b2a74.text = _0xfc2a0f0a;
        _0x483b2a74.color = _0xed6831fb;
    }

    [SerializeField]
    private _0x94b0aea0 _director;
    /// <summary>True when the transform belongs to this HUD, so the director's template sweep
    /// can tell its own controls apart from the ones the template parented into the panel.</summary>
    public bool _0xff467224(Transform _0xa293a39e)
    {
        return this._0x460d432e != null && _0xa293a39e != null && (_0xa293a39e == (Transform)this._0x460d432e || _0xa293a39e.IsChildOf(this._0x460d432e));
    }

    [SerializeField]
    private Sprite _backIcon;
    public void _0x3ef905a2(RectTransform _0xef9a0a02)
    {
        this._0x460d432e = _0x4c815587.Stretch(_0xef9a0a02, _0x69ab0399._0x870f6746(new byte[7] { 170, 128, 131, 155, 164, 153, 136 }, 236));
        _0x4c815587.Surface(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[9] { 77, 100, 119, 100, 109, 66, 105, 104, 113 }, 1), this._roundPlate, new Vector2(0.5f, 0.952f), Vector2.zero, new Vector2(340f, 96f), _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.75f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.94f), _0x4c815587.Ppu(96f), 3f);
        this._0xb827519b = _0x4c815587.Label(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[10] { 160, 137, 154, 137, 128, 186, 141, 128, 153, 137 }, 236), this._font, _0x69ab0399._0x870f6746(new byte[6] { 139, 158, 133, 136, 236, 253 }, 204), new Vector2(0.5f, 0.952f), Vector2.zero, new Vector2(320f, 80f), _0xf2af3007.TextPrimary, 34f, 44f);
        _0x4c815587.Surface(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[8] { 235, 207, 217, 200, 251, 208, 209, 200 }, 184), this._roundPlate, new Vector2(0.30f, 0.893f), Vector2.zero, new Vector2(360f, 88f), _0xf2af3007.WithAlpha(_0xf2af3007.AccentAmber, 0.65f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.94f), _0x4c815587.Ppu(88f), 3f);
        this._0xf2f55f21 = _0x4c815587.Label(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[9] { 192, 228, 242, 227, 197, 242, 255, 230, 246 }, 147), this._font, _0x69ab0399._0x870f6746(new byte[7] { 214, 210, 196, 213, 214, 165, 179 }, 133), new Vector2(0.30f, 0.893f), Vector2.zero, new Vector2(340f, 72f), _0xf2af3007.AccentAmber, 32f, 40f);
        _0x4c815587.Surface(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[8] { 37, 6, 10, 2, 42, 1, 0, 25 }, 105), this._roundPlate, new Vector2(0.70f, 0.893f), Vector2.zero, new Vector2(360f, 88f), _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.65f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.94f), _0x4c815587.Ppu(88f), 3f);
        this._0xe735d8c0 = _0x4c815587.Label(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[9] { 20, 55, 59, 51, 14, 57, 52, 45, 61 }, 88), this._font, _0x69ab0399._0x870f6746(new byte[10] { 219, 216, 212, 220, 210, 211, 183, 167, 184, 160 }, 151), new Vector2(0.70f, 0.893f), Vector2.zero, new Vector2(340f, 72f), _0xf2af3007.AccentCyan, 32f, 40f);
        Button _0xdda8fd6c = _0x4c815587.IconAction(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[10] { 147, 176, 178, 186, 133, 176, 163, 182, 180, 165 }, 209), this._roundPlate, this._backIcon, new Vector2(0.105f, 0.952f), Vector2.zero, 108f, _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.8f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.96f), _0xf2af3007.TextPrimary);
        _0xdda8fd6c.onClick.AddListener(() => this._0x92b5baa7());
        Button _0xfa5899e8 = _0x4c815587.IconAction(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[11] { 150, 167, 179, 181, 163, 146, 167, 180, 161, 163, 178 }, 198), this._roundPlate, this._pauseIcon, new Vector2(0.895f, 0.952f), Vector2.zero, 108f, _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.8f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.96f), _0xf2af3007.TextPrimary);
        _0xfa5899e8.onClick.AddListener(() => this._0xb708f12b());
        // Permanent gesture hint (C.6): names the gesture AND the result, visible all run.
        _0x4c815587.Plate(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[9] { 32, 1, 6, 28, 56, 4, 9, 28, 13 }, 104), this._roundPlate, new Vector2(0.5f, 0.086f), Vector2.zero, new Vector2(1060f, 104f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.72f), _0x4c815587.Ppu(104f), false);
        _0x4c815587.Label(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[8] { 209, 240, 247, 237, 205, 252, 225, 237 }, 153), this._font, _0x69ab0399._0x870f6746(new byte[34] { 121, 108, 125, 13, 121, 122, 98, 13, 99, 104, 100, 106, 101, 111, 98, 120, 127, 13, 126, 122, 100, 121, 110, 101, 104, 126, 13, 121, 98, 13, 126, 122, 108, 125 }, 45), new Vector2(0.5f, 0.086f), Vector2.zero, new Vector2(1010f, 84f), _0xf2af3007.TextPrimary, 32f, 42f);
        this._0x6593ad5c = _0x4c815587.Stretch(this._0x460d432e, _0x69ab0399._0x870f6746(new byte[16] { 250, 205, 203, 205, 193, 222, 205, 218, 250, 205, 201, 204, 199, 221, 220, 219 }, 168));
    }

    public void _0x579157cd(_0x7a0263c9 _0x0c40ab3e)
    {
        if (_0x0c40ab3e == null || this._0x6593ad5c == null)
        {
            return;
        }

        for (int _0xcb5af356 = 0; _0xcb5af356 < _0x644b9457.Channels; _0xcb5af356++)
        {
            Vector3 _0x5077feb5 = new Vector3(_0x0c40ab3e._0xb3c9a131(_0xcb5af356), _0x0c40ab3e._0x9e31d205 - (_0x0c40ab3e._0x341f1518 * 0.92f), 0f);
            Vector2 _0xa2cba6c1 = _0x92093ef6.Project(this._0x6593ad5c, _0x5077feb5);
            TextMeshProUGUI _0xeff47c38 = _0x4c815587.Label(this._0x6593ad5c, _0x69ab0399._0x870f6746(new byte[7] { 134, 177, 181, 176, 187, 161, 160 }, 212), this._font, _0x69ab0399._0x870f6746(new byte[2] { 0, 21 }, 48), new Vector2(0.5f, 0.5f), _0xa2cba6c1, new Vector2(140f, 56f), _0xf2af3007.TextMuted, 28f, 34f);
            this._0x285729f4[_0xcb5af356] = _0xeff47c38;
        }
    }

    private readonly TextMeshProUGUI[] _0x285729f4 = new TextMeshProUGUI[_0x644b9457.Channels];
    public void _0xb90192ef(int _0x8e79eb83)
    {
        _0x3ee0bdf3.SetText(this._0xf2f55f21, _0x69ab0399._0x870f6746(new byte[6] { 26, 30, 8, 25, 26, 105 }, 73) + _0x8e79eb83);
    }

    private void _0xb708f12b()
    {
        if (this._director != null)
        {
            this._director._0x6698abae();
        }
    }

    private TextMeshProUGUI _0xf2f55f21;
    private RectTransform _0x460d432e;
}

internal static class _0x69ab0399
{
    internal static string _0x870f6746(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}