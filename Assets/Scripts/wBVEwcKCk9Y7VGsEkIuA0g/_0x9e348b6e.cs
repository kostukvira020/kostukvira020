using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The learn-to-play overlay: three rows, each a little diagram on the left and its sentence
/// on the right.
///
/// C.25 geometry — the diagram gutter and the text column never share an x band:
///   gutter centre 150, gutter width 200  -> gutter right edge 250
///   text left     250 + 46 = 296, text width 640  -> text right edge 936 <  =  9 6 0 ///The  text  is  placed  by  the  CENTRE  of  its  own  column ( 2 9 6 + 3 2 0  =  6 1 6 ) , which  is  the  only  ///way  a  left-aligned  label ' s  rect  actually  stays  out  of  the  gutter. 
/// </summary>
public sealed class _0x9e348b6e : MonoBehaviour
{
    [SerializeField]
    private Sprite _switchSprite;
    public void _0xe0615b38(RectTransform _0xb80d4bcb)
    {
        RectTransform _0x9e992388 = _0x4c815587.Stretch(_0xb80d4bcb, _0x6cf43dd0._0xb6625048(new byte[12] { 129, 166, 190, 157, 166, 134, 191, 172, 187, 165, 168, 176 }, 201));
        this._0x11b0b53b = _0x9e992388.gameObject;
        _0x4c815587.Quad(_0x9e992388, _0x6cf43dd0._0xb6625048(new byte[5] { 125, 70, 79, 74, 75 }, 46), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(4000f, 4000f), _0xf2af3007.WithAlpha(_0xf2af3007.Shade, 0.82f), true);
        RectTransform _0x3ccf599b = _0x4c815587.Node(_0x9e992388, _0x6cf43dd0._0xb6625048(new byte[4] { 41, 11, 24, 14 }, 106), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(1060f, 1520f));
        this._0x246cb341 = _0x3ccf599b;
        _0x4c815587.Surface(_0x3ccf599b, _0x6cf43dd0._0xb6625048(new byte[11] { 99, 65, 82, 68, 115, 85, 82, 70, 65, 67, 69 }, 32), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1060f, 1520f), _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.9f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.98f), _0x4c815587.Ppu(1060f), 6f);
        _0x4c815587.Label(_0x3ccf599b, _0x6cf43dd0._0xb6625048(new byte[5] { 225, 220, 193, 217, 208 }, 181), this._font, _0x6cf43dd0._0xb6625048(new byte[12] { 218, 221, 197, 178, 219, 198, 178, 197, 221, 192, 217, 193 }, 146), new Vector2(0.5f, 0.925f), Vector2.zero, new Vector2(700f, 110f), _0xf2af3007.AccentCyan, 40f, 56f);
        this._0xb245c744(_0x3ccf599b, 0, 0.745f, _0x6cf43dd0._0xb6625048(new byte[43] { 72, 67, 72, 95, 74, 84, 45, 95, 88, 67, 94, 45, 73, 66, 90, 67, 45, 76, 65, 65, 7, 94, 72, 91, 72, 67, 45, 78, 69, 76, 67, 67, 72, 65, 94, 45, 76, 89, 45, 66, 67, 78, 72 }, 13));
        this._0xb245c744(_0x3ccf599b, 1, 0.565f, _0x6cf43dd0._0xb6625048(new byte[39] { 64, 85, 68, 52, 64, 67, 91, 52, 90, 81, 93, 83, 92, 86, 91, 65, 70, 52, 71, 67, 93, 64, 87, 92, 81, 71, 30, 64, 91, 52, 71, 67, 85, 68, 52, 64, 92, 81, 89 }, 20));
        this._0xb245c744(_0x3ccf599b, 2, 0.385f, _0x6cf43dd0._0xb6625048(new byte[55] { 205, 206, 206, 207, 171, 206, 221, 206, 217, 210, 171, 217, 206, 200, 206, 194, 221, 206, 217, 171, 194, 223, 216, 171, 196, 220, 197, 129, 200, 196, 199, 196, 222, 217, 171, 201, 206, 205, 196, 217, 206, 171, 216, 220, 202, 219, 216, 171, 217, 222, 197, 171, 196, 222, 223 }, 139));
        Button _0x5a42425c = _0x4c815587.Action(_0x3ccf599b, _0x6cf43dd0._0xb6625048(new byte[8] { 149, 174, 141, 164, 183, 164, 173, 178 }, 193), this._roundPlate, this._font, _0x6cf43dd0._0xb6625048(new byte[12] { 49, 39, 46, 39, 33, 54, 66, 46, 39, 52, 39, 46 }, 98), new Vector2(0.5f, 0.155f), Vector2.zero, new Vector2(620f, 148f), _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.85f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface2, 0.98f), _0xf2af3007.TextPrimary, 46f);
        _0x5a42425c.onClick.AddListener(() => this._0x6f91c23e());
        Button _0xed10dbc8 = _0x4c815587.IconAction(_0x3ccf599b, _0x6cf43dd0._0xb6625048(new byte[5] { 68, 107, 104, 116, 98 }, 7), this._roundPlate, this._closeIcon, new Vector2(0.905f, 0.945f), Vector2.zero, 104f, _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.85f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.98f), _0xf2af3007.TextPrimary);
        _0xed10dbc8.onClick.AddListener(() => this._0xab1eaaf8());
    }

    private void _0x47c7a482(Transform _0x75baa479)
    {
        _0x4c815587.Picture(_0x75baa479, _0x6cf43dd0._0xb6625048(new byte[5] { 74, 113, 120, 127, 109 }, 25), this._shaftSprite, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(46f, 170f), _0xf2af3007.WithAlpha(_0xf2af3007.Line, 0.8f));
        _0x4c815587.Picture(_0x75baa479, _0x6cf43dd0._0xb6625048(new byte[4] { 65, 102, 98, 103 }, 3), this._pulseSprite, new Vector2(0.5f, 0.5f), new Vector2(0f, 24f), new Vector2(56f, 56f), _0xf2af3007.AccentCyan);
    }

    private void _0x094ee483(Transform _0x097f8735)
    {
        _0x4c815587.Picture(_0x097f8735, _0x6cf43dd0._0xb6625048(new byte[6] { 9, 58, 44, 44, 58, 51 }, 95), this._receiverSprite, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(110f, 110f), _0xf2af3007.AccentAmber);
    }

    [SerializeField]
    private Sprite _pulseSprite;
    private void _0xab1eaaf8()
    {
        if (this._gate != null)
        {
            this._gate._0x4117a0e9();
        }
    }

    private void _0x2b1d516b(Transform _0x0738e990)
    {
        _0x4c815587.Picture(_0x0738e990, _0x6cf43dd0._0xb6625048(new byte[7] { 197, 225, 255, 226, 245, 254, 215 }, 150), this._switchSprite, new Vector2(0.5f, 0.5f), new Vector2(-48f, 0f), new Vector2(84f, 84f), _0xf2af3007.AccentCyan);
        _0x4c815587.Picture(_0x0738e990, _0x6cf43dd0._0xb6625048(new byte[7] { 223, 251, 229, 248, 239, 228, 206 }, 140), this._switchSprite, new Vector2(0.5f, 0.5f), new Vector2(48f, 0f), new Vector2(84f, 84f), _0xf2af3007.AccentAmber);
    }

    [SerializeField]
    private _0xb399c1a4 _gate;
    [SerializeField]
    private Sprite _closeIcon;
    private const float GutterWidth = 200f;
    public Transform _0x9720c835
    {
        get
        {
            return this._0x246cb341;
        }
    }

    [SerializeField]
    private Sprite _receiverSprite;
    private const float TextWidth = 640f;
    private Transform _0x246cb341;
    private void _0x6f91c23e()
    {
        if (this._gate != null)
        {
            this._gate._0xd2b7da59();
        }
    }

    [SerializeField]
    private Sprite _roundPlate;
    [SerializeField]
    private TMP_FontAsset _font;
    public GameObject _0x0367ac18
    {
        get
        {
            return this._0x11b0b53b;
        }
    }

    private void _0xb245c744(Transform _0x28729dec, int _0x8d241301, float _0x176dc231, string _0xadecdd98)
    {
        RectTransform _0xfaa64ec8 = _0x4c815587.Node(_0x28729dec, _0x6cf43dd0._0xb6625048(new byte[4] { 57, 30, 15, 26 }, 106), new Vector2(0.5f, _0x176dc231), Vector2.zero, new Vector2(RowWidth, RowHeight));
        _0x4c815587.Plate(_0xfaa64ec8, _0x6cf43dd0._0xb6625048(new byte[8] { 140, 177, 169, 142, 178, 191, 170, 187 }, 222), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(RowWidth, RowHeight), _0xf2af3007.WithAlpha(_0xf2af3007.Surface2, 0.6f), _0x4c815587.Ppu(RowHeight), false);
        float _0xbd192201 = GutterCentre - (RowWidth * 0.5f);
        RectTransform _0xbeedb029 = _0x4c815587.Node(_0xfaa64ec8, _0x6cf43dd0._0xb6625048(new byte[7] { 112, 93, 85, 83, 70, 85, 89 }, 52), new Vector2(0.5f, 0.5f), new Vector2(_0xbd192201, 0f), new Vector2(GutterWidth, RowHeight - 40f));
        if (_0x8d241301 == 0)
        {
            this._0x47c7a482(_0xbeedb029);
        }
        else if (_0x8d241301 == 1)
        {
            this._0x2b1d516b(_0xbeedb029);
        }
        else
        {
            this._0x094ee483(_0xbeedb029);
        }

        float _0xdf15ba84 = (TextLeft + (TextWidth * 0.5f)) - (RowWidth * 0.5f);
        TextMeshProUGUI _0xf4d1246d = _0x4c815587.Label(_0xfaa64ec8, _0x6cf43dd0._0xb6625048(new byte[4] { 245, 217, 198, 207 }, 182), this._font, _0xadecdd98, new Vector2(0.5f, 0.5f), new Vector2(_0xdf15ba84, 0f), new Vector2(TextWidth, RowHeight - 60f), _0xf2af3007.TextPrimary, 30f, 38f);
        _0xf4d1246d.alignment = TextAlignmentOptions.Left;
    }

    private const float RowHeight = 260f;
    private const float RowWidth = 1000f;
    [SerializeField]
    private Sprite _shaftSprite;
    private GameObject _0x11b0b53b;
    private const float GutterCentre = 150f;
    private const float TextLeft = 296f;
}

internal static class _0x6cf43dd0
{
    internal static string _0xb6625048(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}