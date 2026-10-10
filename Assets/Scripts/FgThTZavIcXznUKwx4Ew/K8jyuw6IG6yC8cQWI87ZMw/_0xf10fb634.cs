using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xf10fb634 : MonoBehaviour
{
    private static void ApplySafeAreaToAll()
    {
        for (int _0x0e34d3c3 = 0; _0x0e34d3c3 < _0x08a22e71.Count; _0x0e34d3c3++)
            _0x08a22e71[_0x0e34d3c3]._0x64ce59e6();
    }

    private static void OrientationChanged()
    {
        _0xad881eb1 = Screen.orientation;
        _0x6d0bae38.x = Screen.width;
        _0x6d0bae38.y = Screen.height;
        _0x2f1ffaf7 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x32055a1e.Invoke();
    }

    private static void ResolutionChanged()
    {
        _0x6d0bae38.x = Screen.width;
        _0x6d0bae38.y = Screen.height;
        _0x2f1ffaf7 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x32055a1e.Invoke();
    }

    private static UnityEvent _0x32055a1e = new();
    private static readonly List<_0xf10fb634> _0x08a22e71 = new();
    private static ScreenOrientation _0xad881eb1 = ScreenOrientation.LandscapeLeft;
    private void Start()
    {
    }

    private void Awake()
    {
        if (!_0x08a22e71.Contains(this))
            _0x08a22e71.Add(this);
        this._0x6a41fb6a = this.GetComponent<Canvas>();
        this._0x8abe7a03 = this.GetComponent<CanvasScaler>();
        if (this._0x8abe7a03 != null)
            this._0x7cf93c2d = this._0x8abe7a03.referenceResolution;
        this._0xd298778f = this.GetComponent<RectTransform>();
        this._0x1a6634b6 = this.transform.Find(_0x2fdf5b25._0xa2ebe43a(new byte[8] { 11, 57, 62, 61, 25, 42, 61, 57 }, 88)) as RectTransform;
        if (!_0x770f6801)
        {
            _0xad881eb1 = Screen.orientation;
            _0x6d0bae38.x = Screen.width;
            _0x6d0bae38.y = Screen.height;
            _0x2f1ffaf7 = Screen.safeArea;
            _0x770f6801 = true;
        }

        this._0x64ce59e6();
    }

    private CanvasScaler _0x8abe7a03;
    private Canvas _0x6a41fb6a;
    private void OnDestroy()
    {
        if (_0x08a22e71 != null && _0x08a22e71.Contains(this))
            _0x08a22e71.Remove(this);
    }

    private void Update()
    {
        if (_0x08a22e71.Count == 0 || _0x08a22e71[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xad881eb1)
            OrientationChanged();
        if (Screen.safeArea != _0x2f1ffaf7)
            SafeAreaChanged();
        if (Screen.width != _0x6d0bae38.x || Screen.height != _0x6d0bae38.y)
            ResolutionChanged();
    }

    private void _0x64ce59e6()
    {
        if (this._0x1a6634b6 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x84d1b103 = Screen.safeArea;
        Vector2 _0x7f927952 = _0x84d1b103.position;
        Vector2 _0xfe0c3d7b = _0x84d1b103.position + _0x84d1b103.size;
        _0x7f927952.x /= screenWidth;
        _0x7f927952.y /= screenHeight;
        _0xfe0c3d7b.x /= screenWidth;
        _0xfe0c3d7b.y /= screenHeight;
        this._0x1a6634b6.anchorMin = _0x7f927952;
        this._0x1a6634b6.anchorMax = _0xfe0c3d7b;
        this._0x1a6634b6.offsetMin = Vector2.zero;
        this._0x1a6634b6.offsetMax = Vector2.zero;
        if (this._0x8abe7a03 == null)
            return;
        Vector2 _0xbe79a56b = _0xfe0c3d7b - _0x7f927952;
        float _0x80fb4647 = 2f - _0xbe79a56b.x;
        float _0xff1cd701 = 2f - _0xbe79a56b.y;
        this._0x8abe7a03.referenceResolution = this._0x7cf93c2d * new Vector2(_0x80fb4647, _0xff1cd701);
    }

    private RectTransform _0x1a6634b6;
    private static Rect _0x2f1ffaf7 = Rect.zero;
    private RectTransform _0xd298778f;
    private Vector2 _0x7cf93c2d;
    private static void SafeAreaChanged()
    {
        _0x2f1ffaf7 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static bool _0x770f6801;
    private static Vector2 _0x6d0bae38 = Vector2.zero;
}

internal static class _0x2fdf5b25
{
    internal static string _0xa2ebe43a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}