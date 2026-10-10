using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Grid picker: twelve tiles, each showing its number, the SHAPE of that grid (which channels
/// cross), its swap budget and the stars earned. Locked tiles refuse the tap but shake, so the
/// refusal is visible (C.7). The empty-state label exists even though level 1 is always
/// unlocked — a list that can be empty must never render as a blank area (rule G).
/// </summary>
public sealed class _0x71cd593f : MonoBehaviour
{
    [SerializeField]
    private Sprite _closeIcon;
    [SerializeField]
    private _0xb399c1a4 _gate;
    private const float TileHeight = 270f;
    public GameObject _0xa6bccf07
    {
        get
        {
            return this._0x20e5a611;
        }
    }

    private void _0x872968a8()
    {
        if (this._gate != null)
        {
            this._gate._0x4117a0e9();
        }
    }

    private GameObject _0x20e5a611;
    public Transform _0xbb94af5c
    {
        get
        {
            return this._0x0631997d;
        }
    }

    [SerializeField]
    private Sprite _lockIcon;
    public void _0x1ac6782b(RectTransform _0xb842d28d)
    {
        RectTransform _0x4016735d = _0x4c815587.Stretch(_0xb842d28d, _0xe93a5a37._0xc06ec74b(new byte[13] { 32, 9, 26, 9, 0, 31, 35, 26, 9, 30, 0, 13, 21 }, 108));
        this._0x20e5a611 = _0x4016735d.gameObject;
        _0x4c815587.Quad(_0x4016735d, _0xe93a5a37._0xc06ec74b(new byte[5] { 126, 69, 76, 73, 72 }, 45), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(4000f, 4000f), _0xf2af3007.WithAlpha(_0xf2af3007.Shade, 0.82f), true);
        RectTransform _0x42d4558d = _0x4c815587.Node(_0x4016735d, _0xe93a5a37._0xc06ec74b(new byte[4] { 77, 111, 124, 106 }, 14), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(1060f, 1480f));
        this._0x0631997d = _0x42d4558d;
        _0x4c815587.Surface(_0x42d4558d, _0xe93a5a37._0xc06ec74b(new byte[11] { 234, 200, 219, 205, 250, 220, 219, 207, 200, 202, 204 }, 169), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1060f, 1480f), _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.9f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.98f), _0x4c815587.Ppu(1060f), 6f);
        _0x4c815587.Label(_0x42d4558d, _0xe93a5a37._0xc06ec74b(new byte[5] { 126, 67, 94, 70, 79 }, 42), this._font, _0xe93a5a37._0xc06ec74b(new byte[13] { 101, 115, 122, 115, 117, 98, 22, 119, 22, 113, 100, 127, 114 }, 54), new Vector2(0.5f, 0.925f), Vector2.zero, new Vector2(700f, 110f), _0xf2af3007.AccentCyan, 40f, 56f);
        // Anchors are fractions of the 1060 x 1480 CARD, not of the screen: 3 columns at
        // +/-300 px and 4 rows at +/-435 / +/-145 px, so 270-px tiles never touch.
        float[] _0xe8a170bc = new float[]
        {
            0.217f,
            0.5f,
            0.783f
        };
        float[] _0x488d1bfd = new float[]
        {
            0.7939f,
            0.598f,
            0.402f,
            0.2061f
        };
        int _0x373d1727 = _0x4667b7b4.UnlockedLevel();
        int _0xd7bf470f = 0;
        for (int _0x9fdf201d = 0; _0x9fdf201d < _0x1b49e039.TotalLevels; _0x9fdf201d++)
        {
            int _0xddb85163 = _0x9fdf201d % 3;
            int _0xe9b8c36f = _0x9fdf201d / 3;
            if (_0xe9b8c36f >= _0x488d1bfd.Length)
            {
                break;
            }

            this._0xea012e1a[_0x9fdf201d] = this._0x22db696e(_0x42d4558d, _0x9fdf201d, _0xe8a170bc[_0xddb85163], _0x488d1bfd[_0xe9b8c36f], _0x9fdf201d <= _0x373d1727);
            _0xd7bf470f++;
        }

        if (_0xd7bf470f == 0)
        {
            _0x4c815587.Label(_0x42d4558d, _0xe93a5a37._0xc06ec74b(new byte[5] { 193, 233, 244, 240, 253 }, 132), this._font, _0xe93a5a37._0xc06ec74b(new byte[21] { 69, 68, 43, 76, 89, 66, 79, 88, 43, 94, 69, 71, 68, 72, 64, 78, 79, 43, 82, 78, 95 }, 11), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(880f, 110f), _0xf2af3007.TextMuted, 34f, 44f);
        }

        Button _0x0ec9d627 = _0x4c815587.IconAction(_0x42d4558d, _0xe93a5a37._0xc06ec74b(new byte[5] { 159, 176, 179, 175, 185 }, 220), this._roundPlate, this._closeIcon, new Vector2(0.905f, 0.945f), Vector2.zero, 104f, _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.85f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.98f), _0xf2af3007.TextPrimary);
        _0x0ec9d627.onClick.AddListener(() => this._0x872968a8());
    }

    private readonly RectTransform[] _0xea012e1a = new RectTransform[_0x1b49e039.TotalLevels];
    private const float TileSide = 270f;
    private void _0x0cc4b272(int _0x4feb71b6, bool _0xac0be33d)
    {
        if (!_0xac0be33d)
        {
            RectTransform _0xbcd8dd08 = _0x4feb71b6 >= 0 && _0x4feb71b6 < this._0xea012e1a.Length ? this._0xea012e1a[_0x4feb71b6] : null;
            if (_0xbcd8dd08 != null)
            {
                _0xbcd8dd08.DOShakeAnchorPos(0.25f, 12f, 14, 90f).SetLink(_0xbcd8dd08.gameObject);
            }

            return;
        }

        _0x4667b7b4.SelectLevel(_0x4feb71b6);
        if (_0x58a96848.Instance != null)
        {
            _0x58a96848.Instance._0x1d00d384(_0x56576ecc._0x3578949a.SCENE_1);
        }
    }

    private Transform _0x0631997d;
    [SerializeField]
    private Sprite _starIcon;
    private RectTransform _0x22db696e(Transform _0x0fae64b7, int _0xa2b562ef, float _0x389fe191, float _0x5d0ce56e, bool _0xe7163336)
    {
        RectTransform _0xbf9657a9 = _0x4c815587.Node(_0x0fae64b7, _0xe93a5a37._0xc06ec74b(new byte[4] { 144, 165, 190, 179 }, 215), new Vector2(_0x389fe191, _0x5d0ce56e), Vector2.zero, new Vector2(TileSide, TileHeight));
        Color _0xf828a098 = _0xe7163336 ? _0xf2af3007.AccentCyan : _0xf2af3007.TextMuted;
        float _0x0212e84f = _0xe7163336 ? 0.85f : 0.4f;
        Image _0x5718a159 = _0x4c815587.Plate(_0xbf9657a9, _0xe93a5a37._0xc06ec74b(new byte[4] { 41, 14, 12, 10 }, 111), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(TileSide, TileHeight), _0xf2af3007.WithAlpha(_0xf828a098, _0x0212e84f), _0x4c815587.Ppu(TileSide), true);
        Image _0xfce82c68 = _0x4c815587.Plate(_0xbf9657a9, _0xe93a5a37._0xc06ec74b(new byte[4] { 2, 47, 36, 57 }, 64), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(TileSide - 10f, TileHeight - 10f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface2, _0xe7163336 ? 0.96f : 0.55f), _0x4c815587.Ppu(TileSide), false);
        _0xfce82c68.raycastTarget = false;
        _0x4c815587.Label(_0xbf9657a9, _0xe93a5a37._0xc06ec74b(new byte[6] { 245, 206, 214, 217, 222, 201 }, 187), this._font, (_0xa2b562ef + 1).ToString(), new Vector2(0.5f, 0.80f), Vector2.zero, new Vector2(190f, 72f), _0xe7163336 ? _0xf2af3007.TextPrimary : _0xf2af3007.TextMuted, 42f, 58f);
        // The grid's SHAPE: the channels this level crosses are lit, the rest stay dim.
        int _0xe07dc7e6 = _0x1b49e039.RowsFor(_0xa2b562ef);
        int _0x830bcb2c = _0x1b49e039.ColoursFor(_0xa2b562ef);
        for (int _0x53a7fb98 = 0; _0x53a7fb98 < _0x644b9457.Channels; _0x53a7fb98++)
        {
            bool _0xc237ca0e = ((_0x53a7fb98 + _0xa2b562ef) % _0x644b9457.Channels) < (_0xe07dc7e6 + _0x830bcb2c);
            _0x4c815587.Quad(_0xbf9657a9, _0xe93a5a37._0xc06ec74b(new byte[6] { 232, 207, 201, 212, 208, 222 }, 187), new Vector2(0.5f, 0.555f), new Vector2((_0x53a7fb98 - 3) * 24f, 0f), new Vector2(7f, _0xc237ca0e ? 60f : 38f), _0xc237ca0e ? _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.9f) : _0xf2af3007.WithAlpha(_0xf2af3007.Line, 0.45f), false);
        }

        _0x4c815587.Label(_0xbf9657a9, _0xe93a5a37._0xc06ec74b(new byte[6] { 93, 106, 123, 120, 122, 107 }, 31), this._font, (_0x1b49e039.ScrambleFor(_0xa2b562ef) + 3) + _0xe93a5a37._0xc06ec74b(new byte[6] { 103, 20, 16, 6, 23, 20 }, 71), new Vector2(0.5f, 0.325f), Vector2.zero, new Vector2(240f, 50f), _0xf2af3007.TextMuted, 28f, 32f);
        int _0x52d7afe8 = _0x4667b7b4.Stars(_0xa2b562ef);
        for (int _0x45a1a47e = 0; _0x45a1a47e < 3; _0x45a1a47e++)
        {
            _0x4c815587.Picture(_0xbf9657a9, _0xe93a5a37._0xc06ec74b(new byte[4] { 208, 247, 226, 241 }, 131), this._starIcon, new Vector2(0.5f, 0.135f), new Vector2((_0x45a1a47e - 1) * 52f, 0f), new Vector2(44f, 44f), _0x45a1a47e < _0x52d7afe8 ? _0xf2af3007.AccentAmber : _0xf2af3007.Surface2);
        }

        if (!_0xe7163336)
        {
            _0x4c815587.Picture(_0xbf9657a9, _0xe93a5a37._0xc06ec74b(new byte[4] { 235, 200, 196, 204 }, 167), this._lockIcon, new Vector2(0.5f, 0.555f), Vector2.zero, new Vector2(80f, 80f), _0xf2af3007.WithAlpha(_0xf2af3007.TextMuted, 0.9f));
        }

        Button _0x4ae8c92b = _0xbf9657a9.gameObject.AddComponent<Button>();
        _0x4ae8c92b.targetGraphic = _0x5718a159;
        int _0x09b3df38 = _0xa2b562ef;
        bool _0xcc0365bf = _0xe7163336;
        _0x4ae8c92b.onClick.AddListener(() => this._0x0cc4b272(_0x09b3df38, _0xcc0365bf));
        return _0xbf9657a9;
    }

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _roundPlate;
}

internal static class _0xe93a5a37
{
    internal static string _0xc06ec74b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}