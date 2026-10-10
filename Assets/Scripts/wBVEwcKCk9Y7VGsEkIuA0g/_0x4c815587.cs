using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The only place this game builds UGUI. Keeping it in one factory is what makes the
/// HUD/SCI-FI look identical on the menu, the overlays and the pops: one rounded plate
/// sprite, one ring recipe, one label recipe.
/// Draw order is hierarchy order (C.13), so every helper adds its background FIRST and
/// returns the rect callers append text to afterwards.
/// </summary>
public static class _0x4c815587
{
    /// <summary>Rounded 9-slice plate. Lower ppu = rounder corners.</summary>
    public static Image Plate(Transform _0x4454c52a, string _0xc9144b4d, Sprite _0x181b709e, Vector2 _0xd4db4d66, Vector2 _0x086f4ec9, Vector2 _0x7599ba8e, Color _0x73f3571e, float _0x51020008, bool _0xc4e5dd4e)
    {
        RectTransform _0x51ec19cd = Node(_0x4454c52a, _0xc9144b4d, _0xd4db4d66, _0x086f4ec9, _0x7599ba8e);
        Image _0x6bea8cb3 = _0x51ec19cd.gameObject.AddComponent<Image>();
        _0x6bea8cb3.sprite = _0x181b709e;
        _0x6bea8cb3.type = Image.Type.Sliced;
        _0x6bea8cb3.pixelsPerUnitMultiplier = _0x51020008;
        _0x6bea8cb3.color = _0x73f3571e;
        _0x6bea8cb3.raycastTarget = _0xc4e5dd4e;
        return _0x6bea8cb3;
    }

    /// <summary>Square icon button with no caption (close / back / pause).</summary>
    public static Button IconAction(Transform _0xc9ce7f48, string _0x1b6a7b40, Sprite _0xbd97ad59, Sprite _0xd3bef5da, Vector2 _0x57751989, Vector2 _0x231a0344, float _0xcf736687, Color _0xee9ed126, Color _0x76d9e99b, Color _0xfaf06434)
    {
        RectTransform _0x80b975d8 = Node(_0xc9ce7f48, _0x1b6a7b40, _0x57751989, _0x231a0344, new Vector2(_0xcf736687, _0xcf736687));
        Image _0x991da55a = _0x80b975d8.gameObject.AddComponent<Image>();
        _0x991da55a.sprite = _0xbd97ad59;
        _0x991da55a.type = Image.Type.Sliced;
        _0x991da55a.pixelsPerUnitMultiplier = Ppu(_0xcf736687);
        _0x991da55a.color = _0xee9ed126;
        _0x991da55a.raycastTarget = true;
        Image _0xa5e3f51e = Plate(_0x80b975d8, _0x816e0248._0x7e5e2c88(new byte[4] { 232, 197, 206, 211 }, 170), _0xbd97ad59, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xcf736687, _0xcf736687), _0x76d9e99b, Ppu(_0xcf736687), false);
        _0xa5e3f51e.rectTransform.anchorMin = Vector2.zero;
        _0xa5e3f51e.rectTransform.anchorMax = Vector2.one;
        _0xa5e3f51e.rectTransform.offsetMin = new Vector2(4f, 4f);
        _0xa5e3f51e.rectTransform.offsetMax = new Vector2(-4f, -4f);
        float _0xf6e612a3 = _0xcf736687 * 0.52f;
        RectTransform _0x3dd7038c = Node(_0x80b975d8, _0x816e0248._0x7e5e2c88(new byte[5] { 134, 173, 184, 177, 169 }, 193), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xf6e612a3, _0xf6e612a3));
        Image _0x2f9e15b4 = _0x3dd7038c.gameObject.AddComponent<Image>();
        _0x2f9e15b4.preserveAspect = true;
        _0x2f9e15b4.sprite = _0xd3bef5da;
        _0x2f9e15b4.color = _0xfaf06434;
        _0x2f9e15b4.raycastTarget = false;
        Button _0xdffb09fe = _0x80b975d8.gameObject.AddComponent<Button>();
        _0xdffb09fe.targetGraphic = _0x991da55a;
        ColorBlock _0x983b1211 = _0xdffb09fe.colors;
        _0x983b1211.normalColor = Color.white;
        _0x983b1211.highlightedColor = new Color(1f, 1f, 1f, 0.86f);
        _0x983b1211.pressedColor = new Color(0.78f, 0.9f, 0.92f, 1f);
        _0x983b1211.selectedColor = Color.white;
        _0x983b1211.disabledColor = new Color(0.55f, 0.6f, 0.72f, 0.5f);
        _0x983b1211.fadeDuration = 0.08f;
        _0xdffb09fe.colors = _0x983b1211;
        return _0xdffb09fe;
    }

    public static RectTransform Node(Transform _0x7c6a4ed9, string _0x4e365555, Vector2 _0x5bfbcecc, Vector2 _0x133082ab, Vector2 _0x663388c3)
    {
        GameObject _0x217fac4f = new GameObject(_0x4e365555, typeof(RectTransform));
        RectTransform _0x3591eea4 = _0x217fac4f.GetComponent<RectTransform>();
        _0x3591eea4.SetParent(_0x7c6a4ed9, false);
        _0x3591eea4.anchorMin = _0x5bfbcecc;
        _0x3591eea4.anchorMax = _0x5bfbcecc;
        _0x3591eea4.pivot = new Vector2(0.5f, 0.5f);
        _0x3591eea4.anchoredPosition = _0x133082ab;
        _0x3591eea4.sizeDelta = _0x663388c3;
        _0x3591eea4.localScale = Vector3.one;
        return _0x3591eea4;
    }

    public static RectTransform Stretch(Transform _0x942b47ab, string _0xc199bc77)
    {
        GameObject _0x9534f6bd = new GameObject(_0xc199bc77, typeof(RectTransform));
        RectTransform _0x8e7c3272 = _0x9534f6bd.GetComponent<RectTransform>();
        _0x8e7c3272.SetParent(_0x942b47ab, false);
        _0x8e7c3272.anchorMin = Vector2.zero;
        _0x8e7c3272.anchorMax = Vector2.one;
        _0x8e7c3272.pivot = new Vector2(0.5f, 0.5f);
        _0x8e7c3272.offsetMin = Vector2.zero;
        _0x8e7c3272.offsetMax = Vector2.zero;
        _0x8e7c3272.localScale = Vector3.one;
        return _0x8e7c3272;
    }

    /// <summary>
    /// A themed button: NEON surface, then the caption as the LAST child so the plate can
    /// never cover its own text (C.13 / E.1). The caller wires onClick with a lambda.
    /// </summary>
    public static Button Action(Transform _0xb8c2b961, string _0x42563a2e, Sprite _0x05d2b84e, TMP_FontAsset _0x38d64628, string _0x4f3bdbb6, Vector2 _0x458e0271, Vector2 _0x5934688e, Vector2 _0xd99c4a67, Color _0x97ce018f, Color _0x4170a06a, Color _0xb7a5e7b5, float _0x006fc8c4)
    {
        RectTransform _0x8be303bd = Node(_0xb8c2b961, _0x42563a2e, _0x458e0271, _0x5934688e, _0xd99c4a67);
        Image _0xadafa2e7 = _0x8be303bd.gameObject.AddComponent<Image>();
        _0xadafa2e7.sprite = _0x05d2b84e;
        _0xadafa2e7.type = Image.Type.Sliced;
        _0xadafa2e7.pixelsPerUnitMultiplier = Ppu(_0xd99c4a67.y);
        _0xadafa2e7.color = _0x97ce018f;
        _0xadafa2e7.raycastTarget = true;
        Image _0xc8b79a3b = Plate(_0x8be303bd, _0x816e0248._0x7e5e2c88(new byte[4] { 251, 214, 221, 192 }, 185), _0x05d2b84e, new Vector2(0.5f, 0.5f), Vector2.zero, _0xd99c4a67, _0x4170a06a, Ppu(_0xd99c4a67.y), false);
        _0xc8b79a3b.rectTransform.anchorMin = Vector2.zero;
        _0xc8b79a3b.rectTransform.anchorMax = Vector2.one;
        _0xc8b79a3b.rectTransform.offsetMin = new Vector2(5f, 5f);
        _0xc8b79a3b.rectTransform.offsetMax = new Vector2(-5f, -5f);
        TextMeshProUGUI _0x606a43e5 = Label(_0x8be303bd, _0x816e0248._0x7e5e2c88(new byte[7] { 26, 56, 41, 45, 48, 54, 55 }, 89), _0x38d64628, _0x4f3bdbb6, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xd99c4a67.x - 48f, _0xd99c4a67.y - 24f), _0xb7a5e7b5, _0x006fc8c4 * 0.62f, _0x006fc8c4);
        _0x606a43e5.rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        _0x606a43e5.rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        Button _0xfc18ce31 = _0x8be303bd.gameObject.AddComponent<Button>();
        _0xfc18ce31.targetGraphic = _0xadafa2e7;
        ColorBlock _0x56587648 = _0xfc18ce31.colors;
        _0x56587648.normalColor = Color.white;
        _0x56587648.highlightedColor = new Color(1f, 1f, 1f, 0.86f);
        _0x56587648.pressedColor = new Color(0.78f, 0.9f, 0.92f, 1f);
        _0x56587648.selectedColor = Color.white;
        _0x56587648.disabledColor = new Color(0.55f, 0.6f, 0.72f, 0.5f);
        _0x56587648.fadeDuration = 0.08f;
        _0xfc18ce31.colors = _0x56587648;
        return _0xfc18ce31;
    }

    /// <summary>
    /// Corner radius lever for the shared 9-slice plate. Its border is 127 px, so the drawn
    /// border is 127 / multiplier: picking the multiplier from the SHORTEST side is what keeps
    /// 2 x border below the rect and stops a short chip from collapsing into a crooked sliver.
    /// </summary>
    public static float Ppu(float _0x76112380)
    {
        float _0xbf1533fc = _0x76112380 * 0.36f;
        if (_0xbf1533fc > 42f)
        {
            _0xbf1533fc = 42f;
        }

        if (_0xbf1533fc < 12f)
        {
            _0xbf1533fc = 12f;
        }

        return 127f / _0xbf1533fc;
    }

    /// <summary>
    /// NEON surface: an accent ring with a dark body inset inside it. The ring is added
    /// first so the body draws on top of it, leaving only the rim visible.
    /// </summary>
    public static RectTransform Surface(Transform _0x124c7421, string _0xda606c83, Sprite _0x9b7e3d65, Vector2 _0xfb6fcf9a, Vector2 _0x34d5410b, Vector2 _0x9680e523, Color _0xc4a7d7ac, Color _0x69768cd9, float _0xa67c7e82, float _0x56d60f24)
    {
        RectTransform _0x3cc2fc55 = Node(_0x124c7421, _0xda606c83, _0xfb6fcf9a, _0x34d5410b, _0x9680e523);
        Image _0x4b9544c6 = Plate(_0x3cc2fc55, _0x816e0248._0x7e5e2c88(new byte[3] { 216, 227, 231 }, 138), _0x9b7e3d65, new Vector2(0.5f, 0.5f), Vector2.zero, _0x9680e523, _0xc4a7d7ac, _0xa67c7e82, false);
        _0x4b9544c6.rectTransform.anchorMin = Vector2.zero;
        _0x4b9544c6.rectTransform.anchorMax = Vector2.one;
        _0x4b9544c6.rectTransform.offsetMin = Vector2.zero;
        _0x4b9544c6.rectTransform.offsetMax = Vector2.zero;
        Image _0x28f07f59 = Plate(_0x3cc2fc55, _0x816e0248._0x7e5e2c88(new byte[4] { 255, 210, 217, 196 }, 189), _0x9b7e3d65, new Vector2(0.5f, 0.5f), Vector2.zero, _0x9680e523, _0x69768cd9, _0xa67c7e82, false);
        _0x28f07f59.rectTransform.anchorMin = Vector2.zero;
        _0x28f07f59.rectTransform.anchorMax = Vector2.one;
        _0x28f07f59.rectTransform.offsetMin = new Vector2(_0x56d60f24, _0x56d60f24);
        _0x28f07f59.rectTransform.offsetMax = new Vector2(-_0x56d60f24, -_0x56d60f24);
        return _0x3cc2fc55;
    }

    /// <summary>Free-standing picture (emblem, star, mark). Never stretched.</summary>
    public static Image Picture(Transform _0x87460841, string _0x7ab95e54, Sprite _0x421bc9c4, Vector2 _0x8b82974a, Vector2 _0x82d4addf, Vector2 _0x57d08015, Color _0xc909afd9)
    {
        RectTransform _0x4a7d9c29 = Node(_0x87460841, _0x7ab95e54, _0x8b82974a, _0x82d4addf, _0x57d08015);
        Image _0xfaac8a40 = _0x4a7d9c29.gameObject.AddComponent<Image>();
        _0xfaac8a40.preserveAspect = true;
        _0xfaac8a40.sprite = _0x421bc9c4;
        _0xfaac8a40.color = _0xc909afd9;
        _0xfaac8a40.raycastTarget = false;
        return _0xfaac8a40;
    }

    public static TextMeshProUGUI Label(Transform _0x52b13e60, string _0x1cc5a648, TMP_FontAsset _0xbc16ee8b, string _0x32e19b7e, Vector2 _0x0e66aec0, Vector2 _0xf2d11166, Vector2 _0xd1f57952, Color _0x4a7a9d0f, float _0xf9f6a777, float _0x9b05903c)
    {
        RectTransform _0x61c25cf0 = Node(_0x52b13e60, _0x1cc5a648, _0x0e66aec0, _0xf2d11166, _0xd1f57952);
        TextMeshProUGUI _0x1ecafb0a = _0x61c25cf0.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xbc16ee8b != null)
        {
            _0x1ecafb0a.font = _0xbc16ee8b;
        }

        _0x3ee0bdf3.Apply(_0x1ecafb0a, _0x32e19b7e, _0x4a7a9d0f, _0xf9f6a777, _0x9b05903c);
        return _0x1ecafb0a;
    }

    /// <summary>Flat tinted quad. No sprite, so nothing can dangle into a white box.</summary>
    public static Image Quad(Transform _0x593dfb94, string _0x16c2e5d1, Vector2 _0x8c2140de, Vector2 _0x2ec0a824, Vector2 _0x40eb2328, Color _0x69e342be, bool _0x9fe09f8f)
    {
        RectTransform _0x405b8242 = Node(_0x593dfb94, _0x16c2e5d1, _0x8c2140de, _0x2ec0a824, _0x40eb2328);
        Image _0xd2871c9f = _0x405b8242.gameObject.AddComponent<Image>();
        _0xd2871c9f.color = _0x69e342be;
        _0xd2871c9f.raycastTarget = _0x9fe09f8f;
        return _0xd2871c9f;
    }
}

internal static class _0x816e0248
{
    internal static string _0x7e5e2c88(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}