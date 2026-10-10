using DG.Tweening;
using UnityEngine;

/// <summary>
/// Shows and hides the two menu overlays. Both roots are objects this codegen created
/// itself and holds by reference (C.2) — nothing here touches a template object, so there is
/// no modification Unity can silently drop.
/// </summary>
public sealed class _0xb399c1a4 : MonoBehaviour
{
    public void _0x5508fa4c()
    {
        this._0x5973c46b(this._0x5e7124e8, this._0xe545090f, true);
        this._0x5973c46b(this._0x39eadc3d, this._0x5cbdafce, false);
    }

    private Transform _0xe545090f;
    private GameObject _0x5e7124e8;
    public void _0xb433fab7(GameObject _0x3829e9d0, Transform _0x8dca9b9b, GameObject _0xc19443c3, Transform _0xb4644638)
    {
        this._0x5e7124e8 = _0x3829e9d0;
        this._0xe545090f = _0x8dca9b9b;
        this._0x39eadc3d = _0xc19443c3;
        this._0x5cbdafce = _0xb4644638;
        this._0x4117a0e9();
    }

    private Transform _0x5cbdafce;
    public void _0x4117a0e9()
    {
        this._0x5973c46b(this._0x5e7124e8, this._0xe545090f, false);
        this._0x5973c46b(this._0x39eadc3d, this._0x5cbdafce, false);
    }

    public void _0xd2b7da59()
    {
        this._0x5973c46b(this._0x5e7124e8, this._0xe545090f, false);
        this._0x5973c46b(this._0x39eadc3d, this._0x5cbdafce, true);
    }

    private GameObject _0x39eadc3d;
    private void _0x5973c46b(GameObject _0x5dde5b6b, Transform _0x770b2dfb, bool _0x869cf58d)
    {
        if (_0x5dde5b6b == null)
        {
            return;
        }

        _0x5dde5b6b.SetActive(_0x869cf58d);
        if (_0x770b2dfb == null || !_0x869cf58d)
        {
            return;
        }

        DOTween.Kill(_0x770b2dfb);
        _0x770b2dfb.localScale = new Vector3(0.92f, 0.92f, 1f);
        _0x770b2dfb.DOScale(1f, 0.22f).SetEase(Ease.OutBack).SetLink(_0x770b2dfb.gameObject);
    }
}