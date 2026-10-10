using DG.Tweening;
using UnityEngine;

/// <summary>
/// One bead of energy sliding down a channel. It follows the resolved route, so when a swap
/// re-routes a flow the bead visibly leaves sideways at the deflector that moved.
/// </summary>
public sealed class _0xcaeab3ce : MonoBehaviour
{
    private void OnDestroy()
    {
        this.Stop();
    }

    /// <summary>
    /// waypoints run top to bottom; speed is in world units per second so every channel moves
    /// at the same visible pace whatever the aspect.
    /// </summary>
    public void _0x6ee404ee(Vector3[] _0xbf56c690, float _0x67e91c6b, float _0xbed453a4)
    {
        this.Stop();
        if (_0xbf56c690 == null || _0xbf56c690.Length < 2 || _0x67e91c6b <= 0f)
        {
            return;
        }

        this.transform.localPosition = _0xbf56c690[0];
        this._0x8d5209d1 = DOTween.Sequence().SetLink(this.gameObject);
        for (int _0x4229627c = 1; _0x4229627c < _0xbf56c690.Length; _0x4229627c++)
        {
            float _0x4f8d84bd = Vector3.Distance(_0xbf56c690[_0x4229627c - 1], _0xbf56c690[_0x4229627c]) / _0x67e91c6b;
            this._0x8d5209d1.Append(this.transform.DOLocalMove(_0xbf56c690[_0x4229627c], _0x4f8d84bd).SetEase(Ease.Linear));
        }

        this._0x8d5209d1.SetDelay(_0xbed453a4);
        this._0x8d5209d1.SetLoops(-1, LoopType.Restart).SetLink(this.gameObject);
    }

    private Sequence _0x8d5209d1;
    public void Stop()
    {
        if (this._0x8d5209d1 != null)
        {
            this._0x8d5209d1.Kill();
            this._0x8d5209d1 = null;
        }

        DOTween.Kill(this.transform);
    }

    public void _0x09ba7ac0(float _0x431ff997, Color _0xff1fe9ee)
    {
        this.transform.localScale = Vector3.one;
        if (this._body == null)
        {
            return;
        }

        this._body.size = new Vector2(_0x431ff997, _0x431ff997);
        this._body.color = _0xff1fe9ee;
    }

    public void _0x772a331e(Color _0xb5df7549)
    {
        if (this._body != null)
        {
            this._body.color = _0xb5df7549;
        }
    }

    [SerializeField]
    private SpriteRenderer _body;
}