using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

/// <summary>
/// Taps are resolved ARITHMETICALLY from the same camera numbers that draw the board, so no
/// collider and no Physics2D exist anywhere in this game.
///
/// The template's InputController ships its touch helpers as PRIVATE members in this tarball,
/// so EnhancedTouch is read directly — still the new Input System, never legacy UnityEngine.Input.
/// </summary>
public sealed class _0x54ed284c : MonoBehaviour
{
    [SerializeField]
    private _0x94b0aea0 _director;
    private void Update()
    {
        if (this._director == null)
        {
            return;
        }

        if (_0x58a96848.Instance == null || !_0x58a96848.Instance._0x42ac3830)
        {
            return;
        }

        Camera _0xa849bf2a = Camera.main;
        if (_0xa849bf2a == null)
        {
            return;
        }

        if (this._0x78d70871 == Time.frameCount)
        {
            return;
        }

        foreach (Touch _0x9d3d5381 in Touch.activeTouches)
        {
            if (!_0x9d3d5381.ended)
            {
                continue;
            }

            this._0x78d70871 = Time.frameCount;
            Vector3 _0x2d584b91 = _0xa849bf2a.ScreenToWorldPoint(new Vector3(_0x9d3d5381.screenPosition.x, _0x9d3d5381.screenPosition.y, 0f));
            this._director._0x1ce9f21e(new Vector2(_0x2d584b91.x, _0x2d584b91.y));
            return;
        }
    }

    private int _0x78d70871 = -1;
    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }
}