using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x94ba350d : MonoBehaviour
{
    private Touch? _0xb00f268f(Bounds _0x6a692714)
    {
        if (!_0x58a96848.Instance._0x42ac3830)
            return null;
        foreach (Touch _0x8c52b067 in Touch.activeTouches)
            if (!_0x8c52b067.ended)
            {
                Vector3 _0xd500204a = Camera.main.ScreenToWorldPoint(_0x8c52b067.screenPosition);
                Vector3 _0x0d32c8cb = new(_0xd500204a.x, _0xd500204a.y, _0x6a692714.center.z);
                if (_0x6a692714.Contains(_0x0d32c8cb) && this._0x6d9db8b4(_0x8c52b067))
                    return _0x8c52b067;
            }

        return null;
    }

    private bool _0x6d9db8b4(Touch? _0x8dd59864)
    {
        if (!_0x8dd59864.HasValue)
            return false;
        Vector3 _0x848eafe4 = Camera.main.ScreenToWorldPoint(_0x8dd59864.Value.screenPosition);
        Vector3 _0x40a31f8c = _0x848eafe4;
        _0x40a31f8c.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x40a31f8c))
            return true;
        _0x8dd59864 = null;
        return false;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xdabffae6 = this.gameObject.GetComponent<_0x94ba350d>();
    }

    private Touch? _0xdc837ee0(Bounds _0x0683560b)
    {
        if (!_0x58a96848.Instance._0x42ac3830)
            return null;
        foreach (Touch _0x8bd593d5 in Touch.activeTouches)
            if (_0x8bd593d5.ended)
            {
                Vector3 _0x8dc7422e = Camera.main.ScreenToWorldPoint(_0x8bd593d5.screenPosition);
                Vector3 _0xede9175a = new(_0x8dc7422e.x, _0x8dc7422e.y, _0x0683560b.center.z);
                if (_0x0683560b.Contains(_0xede9175a) && this._0x6d9db8b4(_0x8bd593d5))
                    return _0x8bd593d5;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private void _0xf9737f57(Touch? _0x95eb90c8)
    {
        if (!_0x58a96848.Instance._0x42ac3830)
        {
            _0x95eb90c8 = null;
            return;
        }

        int _0xbbf3a4d1 = _0x95eb90c8.Value.touchId;
        _0x95eb90c8 = Touch.activeTouches.FirstOrDefault(_0x3d7f97ab => _0x3d7f97ab.touchId == _0xbbf3a4d1);
        if (!this._0x6d9db8b4(_0x95eb90c8.Value))
            _0x95eb90c8 = null;
    }

    private static _0x94ba350d _0xdabffae6;
    private bool _0x06a3624f(Touch? _0x73bdcc94, Bounds _0x43a7026f, TouchPhase _0x052de829)
    {
        if (!_0x58a96848.Instance._0x42ac3830)
        {
            _0x73bdcc94 = null;
            return false;
        }

        if (_0x73bdcc94 != null)
            if (_0x73bdcc94.Value.phase == _0x052de829)
            {
                Vector3 _0x93cd0ca6 = Camera.main.ScreenToWorldPoint(_0x73bdcc94.Value.screenPosition);
                Vector3 _0xaa29ff8d = new(_0x93cd0ca6.x, _0x93cd0ca6.y, _0x43a7026f.center.z);
                if (_0x43a7026f.Contains(_0xaa29ff8d) && this._0x6d9db8b4(_0x73bdcc94.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0xc309f1d2(Bounds _0x1043a600, TouchPhase _0xef9e96e3)
    {
        if (!_0x58a96848.Instance._0x42ac3830)
            return null;
        foreach (Touch _0xb551c012 in Touch.activeTouches)
            if (_0xb551c012.phase == _0xef9e96e3)
            {
                Vector3 _0xdf76c104 = Camera.main.ScreenToWorldPoint(_0xb551c012.screenPosition);
                Vector3 _0xbcc4b720 = new(_0xdf76c104.x, _0xdf76c104.y, _0x1043a600.center.z);
                if (_0x1043a600.Contains(_0xbcc4b720) && this._0x6d9db8b4(_0xb551c012))
                    return _0xb551c012;
            }

        return null;
    }

    private Touch? _0xf1f8c520()
    {
        if (!_0x58a96848.Instance._0x42ac3830)
            return null;
        foreach (Touch _0xd5390216 in Touch.activeTouches)
            if (!_0xd5390216.ended)
                if (this._0x6d9db8b4(_0xd5390216))
                    return _0xd5390216;
        return null;
    }

    private Touch? _0xbf53a503()
    {
        if (!_0x58a96848.Instance._0x42ac3830)
            return null;
        foreach (Touch _0xc43c961e in Touch.activeTouches)
            if (_0xc43c961e.ended)
                if (this._0x6d9db8b4(_0xc43c961e))
                    return _0xc43c961e;
        return null;
    }
}