using DG.Tweening;
using UnityEngine;

/// <summary>
/// One receiver at the bottom of a channel: the vessel, the rising column of its own colour,
/// the contamination ring that grows when a foreign flow pours in, and the lock burst.
/// The fill grows through SpriteRenderer.size.y, which is why its sprite carries a
/// vertical-only 9-slice border.
/// </summary>
public sealed class _0x2d306f33 : MonoBehaviour
{
    private float _0xeddefc85;
    public bool _0x51989387
    {
        get
        {
            return this._0xe62a705f;
        }
    }

    /// <summary>fraction 0..1 of the contamination budget already spent.</summary>
    public void _0x78c8506d(float _0x8e241b3c)
    {
        if (this._alarm == null)
        {
            return;
        }

        float _0x34c4b5df = Mathf.Clamp01(_0x8e241b3c);
        this._alarm.color = _0xf2af3007.WithAlpha(_0xf2af3007.AccentRose, _0x34c4b5df * 0.95f);
        if (_0x34c4b5df > 0.05f && !this._0xe62a705f)
        {
            float _0xb8d9ce30 = this._0xcfca30ed * (0.02f + (_0x34c4b5df * 0.08f));
            if (!DOTween.IsTweening(this.transform))
            {
                this.transform.DOShakePosition(0.5f, _0xb8d9ce30, 12, 90f, false, false).SetLoops(-1).SetLink(this.gameObject);
            }
        }
        else
        {
            DOTween.Kill(this.transform);
            this.transform.localPosition = this._0x698e0d8c;
        }
    }

    [SerializeField]
    private SpriteRenderer _alarm;
    private bool _0xe62a705f;
    [SerializeField]
    private SpriteRenderer _vessel;
    public void _0xc84301b4(Color _0xd95ac009)
    {
        if (this._vessel != null)
        {
            this._vessel.color = _0xd95ac009;
        }
    }

    public float _0x6510a934
    {
        get
        {
            return this._0x625f387e;
        }
    }

    [SerializeField]
    private SpriteRenderer _fill;
    public void _0x9de67e2f(Vector3 _0x4cf56520, float width)
    {
        this._0xcfca30ed = width;
        this._0xeddefc85 = width * 1.5f;
        this._0x625f387e = _0x4cf56520.y - (this._0xeddefc85 * 0.5f);
        this._0x698e0d8c = _0x4cf56520;
        this.transform.localPosition = _0x4cf56520;
        this.transform.localScale = Vector3.one;
        if (this._vessel != null)
        {
            this._vessel.size = new Vector2(this._0xcfca30ed, this._0xcfca30ed);
        }

        if (this._alarm != null)
        {
            this._alarm.size = new Vector2(this._0xcfca30ed * 1.25f, this._0xcfca30ed * 1.25f);
            this._alarm.color = _0xf2af3007.WithAlpha(_0xf2af3007.AccentRose, 0f);
        }

        if (this._burst != null)
        {
            this._burst.size = new Vector2(this._0xcfca30ed * 1.7f, this._0xcfca30ed * 1.7f);
            this._burst.color = _0xf2af3007.WithAlpha(_0xf2af3007.AccentAmber, 0f);
            this._burst.enabled = false;
        }

        this._0x16bc3ce6(0f, _0xf2af3007.AccentCyan);
        this._0x78c8506d(0f);
    }

    /// <summary>fraction 0..1 of the vessel filled with its OWN colour.</summary>
    public void _0x16bc3ce6(float _0x6c31a615, Color _0x4b38288c)
    {
        if (this._fill == null)
        {
            return;
        }

        float _0xa51791d0 = Mathf.Clamp01(_0x6c31a615);
        float _0x8fdfc129 = this._0xcfca30ed * 1.15f * _0xa51791d0;
        bool _0x577e8432 = _0x8fdfc129 > this._0xcfca30ed * 0.40f;
        this._fill.enabled = _0x577e8432;
        if (!_0x577e8432)
        {
            return;
        }

        this._fill.color = _0x4b38288c;
        this._fill.size = new Vector2(this._0xcfca30ed * 0.66f, _0x8fdfc129);
        Vector3 _0x2afa6202 = this._fill.transform.localPosition;
        _0x2afa6202.y = (-this._0xcfca30ed * 0.5f) + (_0x8fdfc129 * 0.5f);
        this._fill.transform.localPosition = _0x2afa6202;
    }

    private float _0x625f387e;
    private float _0xcfca30ed;
    private Vector3 _0x698e0d8c;
    public void _0x961ef4ed(Color _0xb2f5b9a0)
    {
        if (this._0xe62a705f)
        {
            return;
        }

        this._0xe62a705f = true;
        DOTween.Kill(this.transform);
        this.transform.localPosition = this._0x698e0d8c;
        this._0x78c8506d(0f);
        if (this._vessel != null)
        {
            this._vessel.color = _0xb2f5b9a0;
        }

        if (this._burst == null)
        {
            return;
        }

        this._burst.enabled = true;
        this._burst.color = _0xf2af3007.WithAlpha(_0xb2f5b9a0, 1f);
        this._burst.size = new Vector2(this._0xcfca30ed * 0.4f, this._0xcfca30ed * 0.4f);
        DOTween.To(() => this._burst.size, _0x1c1cf50c => this._burst.size = _0x1c1cf50c, new Vector2(this._0xcfca30ed * 2.1f, this._0xcfca30ed * 2.1f), 0.42f).SetEase(Ease.OutQuad).SetLink(this._burst.gameObject);
        this._burst.DOFade(0f, 0.42f).SetLink(this._burst.gameObject);
    }

    [SerializeField]
    private SpriteRenderer _burst;
}