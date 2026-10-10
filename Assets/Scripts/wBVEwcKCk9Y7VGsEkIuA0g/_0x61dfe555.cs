using TMPro;
using UnityEngine;

/// <summary>
/// C.15: the template defines more panels than this game dresses, and the ones left over
/// still carry their "Lorem Ipsum" placeholder. Their TEXT is blanked at runtime; the panels
/// themselves stay alive because the controllers address them by index.
/// Panels are reached through the controller's public list, never by name.
/// </summary>
public sealed class _0x61dfe555 : MonoBehaviour
{
    private void _0xefa5cf76(_0x5bd4077c _0xb32ab47b, int _0xf87af35d)
    {
        if (_0xf87af35d < 0 || _0xf87af35d >= _0xb32ab47b.Panels.Count)
        {
            return;
        }

        _0x29eaf145 _0x7edd8ee8 = _0xb32ab47b.Panels[_0xf87af35d];
        if (_0x7edd8ee8 == null)
        {
            return;
        }

        TMP_Text[] _0xc3b85a2f = _0x7edd8ee8.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x52d67d94 = 0; _0x52d67d94 < _0xc3b85a2f.Length; _0x52d67d94++)
        {
            if (_0xc3b85a2f[_0x52d67d94] != null)
            {
                _0xc3b85a2f[_0x52d67d94].text = string.Empty;
            }
        }
    }

    public void _0x53f000da()
    {
        _0x5bd4077c _0xd0f3d8d4 = _0x5bd4077c.Instance;
        if (_0xd0f3d8d4 == null || _0xd0f3d8d4.Panels == null)
        {
            return;
        }

        this._0xefa5cf76(_0xd0f3d8d4, _0x56576ecc._0x7463064a.TUTORIAL0);
        this._0xefa5cf76(_0xd0f3d8d4, _0x56576ecc._0x7463064a.TUTORIAL1);
        this._0xefa5cf76(_0xd0f3d8d4, _0x56576ecc._0x7463064a.TUTORIAL2);
        this._0xefa5cf76(_0xd0f3d8d4, _0x56576ecc._0x7463064a.TUTORIAL3);
        this._0xefa5cf76(_0xd0f3d8d4, _0x56576ecc._0x7463064a.TUTORIAL4);
        this._0xefa5cf76(_0xd0f3d8d4, _0x56576ecc._0x7463064a.TUTORIAL5);
        this._0xefa5cf76(_0xd0f3d8d4, _0x56576ecc._0x7463064a.TUTORIAL6);
    }
}