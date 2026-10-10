using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three template pops (WIN 7 / LOSE 8 / PAUSE 6) with this game's own card.
///
/// Two template traps are defused here:
///  * Pop.Awake leaves Content INACTIVE, and a TextMeshProUGUI added to a dead hierarchy has
///    no font and throws when its material is read — so Content is woken BEFORE anything is
///    built into it;
///  * Pop.Show kills the hide tween with complete:true, which fires the old OnComplete and
///    switches the body straight back off — so the tween is killed without completing and the
///    scale is reset before ShowPop is called.
/// Every template child of the card is switched off, which also removes the template's
/// spriteless close button (the famous white square).
/// </summary>
public sealed class _0x5241fa6a : MonoBehaviour
{
    private readonly TextMeshProUGUI[] _0xe354128e = new TextMeshProUGUI[3];
    public bool _0xbcb4dfec(int _0x85ad1d9c)
    {
        return _0x85ad1d9c >= 0 && _0x85ad1d9c < this._0x8a2c38a5.Length && this._0x8a2c38a5[_0x85ad1d9c];
    }

    [SerializeField]
    private Sprite _markIcon;
    public const int KindWin = 0;
    [SerializeField]
    private Sprite _closeIcon;
    private readonly TextMeshProUGUI[] _0xa9a6dc4d = new TextMeshProUGUI[3];
    private void _0x06f647a3(int _0x28bd82a8, int _0x02961e84)
    {
        Image[] _0x500640b9 = this._0x5b760e7e[_0x28bd82a8];
        if (_0x500640b9 == null)
        {
            return;
        }

        for (int _0xe9ff29d9 = 0; _0xe9ff29d9 < _0x500640b9.Length; _0xe9ff29d9++)
        {
            if (_0x500640b9[_0xe9ff29d9] == null)
            {
                continue;
            }

            bool _0x68783bee = _0xe9ff29d9 < _0x02961e84;
            _0x500640b9[_0xe9ff29d9].color = _0x68783bee ? _0xf2af3007.AccentAmber : _0xf2af3007.Surface2;
            if (!_0x68783bee)
            {
                continue;
            }

            _0x500640b9[_0xe9ff29d9].transform.localScale = Vector3.zero;
            _0x500640b9[_0xe9ff29d9].transform.DOScale(1f, 0.32f).SetEase(Ease.OutBack).SetDelay(0.12f * _0xe9ff29d9).SetLink(_0x500640b9[_0xe9ff29d9].gameObject);
        }
    }

    [SerializeField]
    private _0x94b0aea0 _director;
    public const int KindPause = 2;
    private void _0xd9930aa4()
    {
        if (this._director != null)
        {
            this._director._0x1e9c448b();
        }
    }

    /// <summary>Kill the hide tween WITHOUT completing it, then reset scale (see the class note).</summary>
    public static void Arm(_0x941938ef _0xb9cbac73)
    {
        if (_0xb9cbac73 == null || _0xb9cbac73.Content == null)
        {
            return;
        }

        DOTween.Kill(_0xb9cbac73.Content.transform);
        _0xb9cbac73.Content.transform.localScale = Vector3.zero;
        _0xb9cbac73.Content.SetActive(true);
    }

    public void _0x6baca82d(string _0xfb31058a, string _0x32efd99d, int _0xe7561199)
    {
        _0x3ee0bdf3.SetText(this._0xe354128e[KindWin], _0xfb31058a);
        _0x3ee0bdf3.SetText(this._0x7f8bd720[KindWin], _0x32efd99d);
        this._0x06f647a3(KindWin, _0xe7561199);
    }

    public void _0xb58cc678(string _0xb49d46f6, string _0x08963919)
    {
        _0x3ee0bdf3.SetText(this._0xe354128e[KindPause], _0xb49d46f6);
        _0x3ee0bdf3.SetText(this._0x7f8bd720[KindPause], _0x08963919);
    }

    private void _0x5e079a22()
    {
        if (this._director != null)
        {
            this._director._0x5b2708db();
        }
    }

    [SerializeField]
    private TMP_FontAsset _font;
    public const int KindLose = 1;
    public void _0x59acd72f(_0x941938ef _0xd7a7e58c, _0x941938ef _0xe966a05e, _0x941938ef _0x01fafff8)
    {
        this._0x2ea979e3(KindWin, _0xd7a7e58c, _0xf2af3007.AccentCyan, _0xbb97f86c._0x0ad8c0f3(new byte[21] { 248, 235, 248, 239, 228, 157, 239, 248, 254, 248, 244, 235, 248, 239, 157, 241, 242, 254, 246, 248, 249 }, 189), _0xbb97f86c._0x0ad8c0f3(new byte[9] { 146, 153, 132, 136, 252, 155, 142, 149, 152 }, 220));
        this._0x2ea979e3(KindLose, _0xe966a05e, _0xf2af3007.AccentRose, _0xbb97f86c._0x0ad8c0f3(new byte[14] { 111, 101, 102, 126, 9, 106, 102, 101, 101, 104, 121, 122, 108, 109 }, 41), _0xbb97f86c._0x0ad8c0f3(new byte[5] { 31, 8, 25, 31, 20 }, 77));
        this._0x2ea979e3(KindPause, _0x01fafff8, _0xf2af3007.AccentAmber, _0xbb97f86c._0x0ad8c0f3(new byte[9] { 193, 203, 200, 208, 167, 207, 194, 203, 195 }, 135), _0xbb97f86c._0x0ad8c0f3(new byte[6] { 183, 160, 182, 176, 168, 160 }, 229));
    }

    private readonly Image[][] _0x5b760e7e = new Image[3][];
    public void _0x2cab56bf(string _0x02097d65, string _0x3f17b946)
    {
        _0x3ee0bdf3.SetText(this._0xe354128e[KindLose], _0x02097d65);
        _0x3ee0bdf3.SetText(this._0x7f8bd720[KindLose], _0x3f17b946);
    }

    private void _0xce41d157()
    {
        if (this._director != null)
        {
            this._director._0x7cbf7dda();
        }
    }

    private readonly bool[] _0x8a2c38a5 = new bool[3];
    private readonly Image[] _0xe1fc4a8e = new Image[3];
    [SerializeField]
    private Sprite _starIcon;
    private void _0x2ea979e3(int _0x528cd1b7, _0x941938ef _0xa41ea8eb, Color _0xe9bc3589, string _0x70615f81, string _0x5fabbd43)
    {
        if (_0xa41ea8eb == null || _0xa41ea8eb.Content == null)
        {
            return;
        }

        Transform _0x8dbf5333 = _0xa41ea8eb.Content.transform;
        bool _0xa8687aa9 = _0xa41ea8eb.Content.activeSelf;
        _0xa41ea8eb.Content.SetActive(true);
        for (int _0x39f853b5 = _0x8dbf5333.childCount - 1; _0x39f853b5 >= 0; _0x39f853b5--)
        {
            _0x8dbf5333.GetChild(_0x39f853b5).gameObject.SetActive(false);
        }

        RectTransform _0x59147ba9 = _0x4c815587.Node(_0x8dbf5333, _0xbb97f86c._0x0ad8c0f3(new byte[8] { 116, 94, 93, 69, 113, 83, 64, 86 }, 50), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1000f, 1180f));
        _0x59147ba9.anchorMin = new Vector2(0.5f, 0.5f);
        _0x59147ba9.anchorMax = new Vector2(0.5f, 0.5f);
        _0x4c815587.Surface(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[11] { 219, 249, 234, 252, 203, 237, 234, 254, 249, 251, 253 }, 152), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1000f, 1180f), _0xf2af3007.WithAlpha(_0xe9bc3589, 0.9f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.97f), _0x4c815587.Ppu(1180f), 6f);
        this._0xe1fc4a8e[_0x528cd1b7] = _0x4c815587.Picture(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[4] { 37, 9, 26, 3 }, 104), this._markIcon, new Vector2(0.5f, 0.82f), Vector2.zero, new Vector2(220f, 220f), _0xe9bc3589);
        this._0xa9a6dc4d[_0x528cd1b7] = _0x4c815587.Label(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[6] { 82, 127, 123, 126, 127, 104 }, 26), this._font, _0x70615f81, new Vector2(0.5f, 0.655f), Vector2.zero, new Vector2(880f, 110f), _0xf2af3007.TextPrimary, 44f, 66f);
        this._0xe354128e[_0x528cd1b7] = _0x4c815587.Label(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[4] { 73, 100, 111, 114 }, 11), this._font, _0xbb97f86c._0x0ad8c0f3(new byte[1] { 214 }, 251), new Vector2(0.5f, 0.545f), Vector2.zero, new Vector2(880f, 96f), _0xe9bc3589, 36f, 52f);
        this._0x7f8bd720[_0x528cd1b7] = _0x4c815587.Label(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[6] { 131, 170, 170, 177, 160, 183 }, 197), this._font, _0xbb97f86c._0x0ad8c0f3(new byte[1] { 182 }, 155), new Vector2(0.5f, 0.435f), Vector2.zero, new Vector2(880f, 120f), _0xf2af3007.TextMuted, 30f, 38f);
        if (_0x528cd1b7 == KindWin)
        {
            Image[] _0xf1ed42ee = new Image[3];
            for (int _0x7c073a34 = 0; _0x7c073a34 < 3; _0x7c073a34++)
            {
                float _0xfb1c858d = 0.5f + ((_0x7c073a34 - 1) * 0.132f);
                _0xf1ed42ee[_0x7c073a34] = _0x4c815587.Picture(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[4] { 101, 66, 87, 68 }, 54), this._starIcon, new Vector2(_0xfb1c858d, 0.325f), Vector2.zero, new Vector2(112f, 112f), _0xf2af3007.Surface2);
            }

            this._0x5b760e7e[_0x528cd1b7] = _0xf1ed42ee;
        }

        Button _0xef45c868 = _0x4c815587.Action(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[7] { 155, 185, 162, 166, 170, 185, 178 }, 203), this._roundPlate, this._font, _0x5fabbd43, new Vector2(0.5f, 0.175f), Vector2.zero, new Vector2(700f, 150f), _0xf2af3007.WithAlpha(_0xe9bc3589, 0.85f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface2, 0.98f), _0xf2af3007.TextPrimary, 48f);
        Button _0x772f65fb = _0x4c815587.Action(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[9] { 203, 253, 251, 247, 246, 252, 249, 234, 225 }, 152), this._roundPlate, this._font, _0xbb97f86c._0x0ad8c0f3(new byte[4] { 25, 17, 26, 1 }, 84), new Vector2(0.5f, 0.072f), Vector2.zero, new Vector2(520f, 120f), _0xf2af3007.WithAlpha(_0xf2af3007.TextMuted, 0.6f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.98f), _0xf2af3007.TextPrimary, 38f);
        Button _0x5cb2cec5 = _0x4c815587.IconAction(_0x59147ba9, _0xbb97f86c._0x0ad8c0f3(new byte[5] { 127, 80, 83, 79, 89 }, 60), this._roundPlate, this._closeIcon, new Vector2(0.9f, 0.955f), Vector2.zero, 104f, _0xf2af3007.WithAlpha(_0xe9bc3589, 0.85f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.98f), _0xf2af3007.TextPrimary);
        if (_0x528cd1b7 == KindWin)
        {
            _0xef45c868.onClick.AddListener(() => this._0x6ca9c500());
            _0x5cb2cec5.onClick.AddListener(() => this._0x6ca9c500());
        }
        else if (_0x528cd1b7 == KindLose)
        {
            _0xef45c868.onClick.AddListener(() => this._0xd9930aa4());
            _0x5cb2cec5.onClick.AddListener(() => this._0xd9930aa4());
        }
        else
        {
            _0xef45c868.onClick.AddListener(() => this._0xce41d157());
            _0x5cb2cec5.onClick.AddListener(() => this._0xce41d157());
        }

        _0x772f65fb.onClick.AddListener(() => this._0x5e079a22());
        this._0x8a2c38a5[_0x528cd1b7] = true;
        _0xa41ea8eb.Content.SetActive(_0xa8687aa9);
    }

    private void _0x6ca9c500()
    {
        if (this._director != null)
        {
            this._director._0xe1f841b1();
        }
    }

    [SerializeField]
    private Sprite _roundPlate;
    private readonly TextMeshProUGUI[] _0x7f8bd720 = new TextMeshProUGUI[3];
}

internal static class _0xbb97f86c
{
    internal static string _0x0ad8c0f3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}