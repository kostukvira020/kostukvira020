using UnityEngine;

/// <summary>
/// World point -> local point inside a UGUI rect. Every readout in this game is UGUI
/// (C.16: a world TextMeshPro measures its size in points, not world units, and reads a
/// tenth of the intended size), so the receiver percentages are placed through here instead
/// of being parented to the sprites.
/// </summary>
public static class _0x92093ef6
{
    public static Vector2 Project(RectTransform _0x70ad56bb, Vector3 _0x33c6462b)
    {
        if (_0x70ad56bb == null)
        {
            return Vector2.zero;
        }

        Canvas _0x556ec629 = _0x70ad56bb.GetComponentInParent<Canvas>();
        Camera _0x8e929316 = _0x556ec629 != null ? _0x556ec629.worldCamera : null;
        Camera _0x961f3466 = Camera.main;
        Vector2 _0xc4fb9c7e = _0x961f3466 != null ? (Vector2)_0x961f3466.WorldToScreenPoint(_0x33c6462b) : (Vector2)_0x33c6462b;
        Vector2 _0xade70b3a;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_0x70ad56bb, _0xc4fb9c7e, _0x8e929316, out _0xade70b3a);
        return _0xade70b3a;
    }
}