using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x2ef1673c : MonoBehaviour
{
    private static void OrientationChanged()
    {
        _0xbedbc69c = Screen.orientation;
        _0x944cafe9.x = Screen.width;
        _0x944cafe9.y = Screen.height;
        _0xabf27191.Invoke();
    }

    private void _0xdcef63a2()
    {
        if (this._0xbc2c671c == null)
            return;
        Rect _0xe52e0714 = Screen.safeArea;
        Vector2 _0xd2b48171 = _0xe52e0714.position;
        Vector2 _0x01a6c9e0 = _0xe52e0714.position + _0xe52e0714.size;
        _0xd2b48171.x /= this._0x57ab61bf.pixelRect.width;
        _0xd2b48171.y /= this._0x57ab61bf.pixelRect.height;
        _0x01a6c9e0.x /= this._0x57ab61bf.pixelRect.width;
        _0x01a6c9e0.y /= this._0x57ab61bf.pixelRect.height;
        this._0xbc2c671c.anchorMin = _0xd2b48171;
        this._0xbc2c671c.anchorMax = _0x01a6c9e0;
    }

    private RectTransform _0xbc2c671c;
    private static void SafeAreaChanged()
    {
        _0x9c22e300 = Screen.safeArea;
        for (int _0x12958230 = 0; _0x12958230 < _0xf09b17d1.Count; _0x12958230++)
            _0xf09b17d1[_0x12958230]._0xdcef63a2();
    }

    private static bool _0x1de8ba5f;
    private static ScreenOrientation _0xbedbc69c = ScreenOrientation.LandscapeLeft;
    private Canvas _0x57ab61bf;
    private RectTransform _0x44ae3cfe;
    private static UnityEvent _0xabf27191 = new();
    private static readonly List<_0x2ef1673c> _0xf09b17d1 = new();
    private static Vector2 _0x944cafe9 = Vector2.zero;
    private static void ResolutionChanged()
    {
        _0x944cafe9.x = Screen.width;
        _0x944cafe9.y = Screen.height;
        _0xabf27191.Invoke();
    }

    private static Rect _0x9c22e300 = Rect.zero;
    private void Update()
    {
        if (_0xf09b17d1[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xbedbc69c)
            OrientationChanged();
        if (Screen.safeArea != _0x9c22e300)
            SafeAreaChanged();
        if (Screen.width != _0x944cafe9.x || Screen.height != _0x944cafe9.y)
            ResolutionChanged();
    }

    private void Awake()
    {
        if (!_0xf09b17d1.Contains(this))
            _0xf09b17d1.Add(this);
        this._0x57ab61bf = this.GetComponent<Canvas>();
        this._0x44ae3cfe = this.GetComponent<RectTransform>();
        this._0xbc2c671c = this.transform.Find(_0xa4d49420._0x492a8c4b(new byte[8] { 205, 255, 248, 251, 223, 236, 251, 255 }, 158)) as RectTransform;
        if (!_0x1de8ba5f)
        {
            _0xbedbc69c = Screen.orientation;
            _0x944cafe9.x = Screen.width;
            _0x944cafe9.y = Screen.height;
            _0x9c22e300 = Screen.safeArea;
            _0x1de8ba5f = true;
        }

        this._0xdcef63a2();
    }

    private void OnDestroy()
    {
        if (_0xf09b17d1 != null && _0xf09b17d1.Contains(this))
            _0xf09b17d1.Remove(this);
    }
}

internal static class _0xa4d49420
{
    internal static string _0x492a8c4b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}