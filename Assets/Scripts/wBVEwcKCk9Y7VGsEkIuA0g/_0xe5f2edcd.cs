using DG.Tweening;
using UnityEngine;

/// <summary>
/// One deflector token: hexagonal socket, the glyph that says where the flow leaves, and a
/// selection ring. Sizing goes through SpriteRenderer.size (the renderers are Sliced), never
/// through localScale, so the gate's "size and scale fight each other" rule holds and the
/// token keeps the square aspect of its 512x512 art.
/// </summary>
public sealed class _0xe5f2edcd : MonoBehaviour
{
    /// <summary>Arc towards the partner's slot — the exchange has to be readable, not instant.</summary>
    public void _0xc3b0f156(Vector3 _0xfd1e4808, float _0xfd147182, float _0xa9bf1f9b)
    {
        this._0x0ba24880 = _0xfd1e4808.y;
        DOTween.Kill(this.transform);
        Vector3[] _0x7a3234ab = new Vector3[]
        {
            new Vector3((this.transform.localPosition.x + _0xfd1e4808.x) * 0.5f, _0xfd1e4808.y + _0xfd147182, _0xfd1e4808.z),
            _0xfd1e4808
        };
        this.transform.DOLocalPath(_0x7a3234ab, _0xa9bf1f9b, PathType.CatmullRom).SetEase(Ease.InOutCubic).SetLink(this.gameObject);
    }

    private int _0xc928dede;
    private int _0x97b5b989;
    public int _0xc868c683
    {
        get
        {
            return this._0xc928dede;
        }
    }

    private float _0x18e42979;
    /// <summary>Logical slot only — called after a swap so the arc tween is not cut short.</summary>
    public void _0xadf5460a(int _0x0e0e2f98, int _0x6158a139)
    {
        this._0x97b5b989 = _0x0e0e2f98;
        this._0xc928dede = _0x6158a139;
    }

    public void _0x5d36c5af(bool _0x30946e12)
    {
        if (this._ring != null)
        {
            this._ring.enabled = _0x30946e12;
            DOTween.Kill(this._ring);
            if (_0x30946e12)
            {
                this._ring.color = _0xf2af3007.WithAlpha(_0xf2af3007.AccentAmber, 0f);
                this._ring.DOFade(1f, 0.12f).SetLink(this._ring.gameObject);
            }
        }

        DOTween.Kill(this.transform);
        Vector3 _0x0e033402 = this.transform.localPosition;
        _0x0e033402.y = _0x30946e12 ? this._0x0ba24880 + (this._0x18e42979 * 0.1f) : this._0x0ba24880;
        this.transform.DOLocalMoveY(_0x0e033402.y, 0.12f).SetLink(this.gameObject);
    }

    public void _0xc3539418(float _0x6a6a9e51)
    {
        if (this._socket != null)
        {
            this._socket.size = new Vector2(this._0x18e42979 * _0x6a6a9e51, this._0x18e42979 * _0x6a6a9e51);
        }

        if (this._glyph != null)
        {
            this._glyph.size = new Vector2(this._0x18e42979 * 0.82f * _0x6a6a9e51, this._0x18e42979 * 0.82f * _0x6a6a9e51);
        }

        if (this._ring != null)
        {
            this._ring.size = new Vector2(this._0x18e42979 * 1.22f * _0x6a6a9e51, this._0x18e42979 * 1.22f * _0x6a6a9e51);
        }
    }

    [SerializeField]
    private SpriteRenderer _glyph;
    public int _0xd2b7f67a
    {
        get
        {
            return this._0x97b5b989;
        }
    }

    public void _0xfef7869f(int _0x4d7e1d42, Color _0x403ab6b5, Color _0x62113893)
    {
        if (this._socket != null)
        {
            this._socket.color = _0x403ab6b5;
        }

        if (this._glyph == null)
        {
            return;
        }

        this._glyph.sprite = _0x4d7e1d42 == _0x644b9457.Straight ? this._straightGlyph : this._divertGlyph;
        this._glyph.flipX = _0x4d7e1d42 == _0x644b9457.DivertLeft;
        this._glyph.color = _0x62113893;
    }

    public void _0x4cd25d71()
    {
        DOTween.Kill(this._glyph);
        if (this._glyph != null)
        {
            this._glyph.DOFade(0.45f, 0.1f).SetLoops(2, LoopType.Yoyo).SetLink(this._glyph.gameObject);
        }
    }

    [SerializeField]
    private SpriteRenderer _ring;
    [SerializeField]
    private Sprite _straightGlyph;
    private float _0x0ba24880;
    public void _0xe57a5dc4(int _0xdcc0ecfc, int _0xb956fd90, Vector3 _0xd6d5bfa2, float _0x44e45ee4)
    {
        this._0x97b5b989 = _0xdcc0ecfc;
        this._0xc928dede = _0xb956fd90;
        this._0x18e42979 = _0x44e45ee4;
        this._0x0ba24880 = _0xd6d5bfa2.y;
        this.transform.localPosition = _0xd6d5bfa2;
        this.transform.localScale = Vector3.one;
        this._0xc3539418(1f);
        if (this._ring != null)
        {
            this._ring.enabled = false;
            this._ring.color = _0xf2af3007.WithAlpha(_0xf2af3007.AccentAmber, 0f);
        }
    }

    [SerializeField]
    private Sprite _divertGlyph;
    [SerializeField]
    private SpriteRenderer _socket;
}