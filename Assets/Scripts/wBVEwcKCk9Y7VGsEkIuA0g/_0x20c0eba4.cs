using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the menu panel: the abstract mark (one node on seven light channels — no letters,
/// no app name anywhere), the objective line, a living preview of the network, and the three
/// ways in. The START target is the TEMPLATE's own scene-loading button, found by its DRIVER
/// type rather than by name; this only draws its face, so the scene is never loaded twice.
/// </summary>
public sealed class _0x20c0eba4 : MonoBehaviour
{
    private const int Rays = 7;
    private _0x29eaf145 _0x364f4369()
    {
        _0x5bd4077c _0x095f8086 = _0x5bd4077c.Instance;
        if (_0x095f8086 == null || _0x095f8086.Panels == null)
        {
            return null;
        }

        int _0x75f2cdf0 = _0x56576ecc._0x7463064a.DEFAULT;
        return _0x75f2cdf0 < 0 || _0x75f2cdf0 >= _0x095f8086.Panels.Count ? null : _0x095f8086.Panels[_0x75f2cdf0];
    }

    [SerializeField]
    private Sprite _roundPlate;
    [SerializeField]
    private Sprite _shaftSprite;
    private RectTransform _0xcb5f0a27;
    private void _0xf1928c5e(RectTransform _0xe13fb90e, float _0xe6e1424a)
    {
        if (_0xe13fb90e == null)
        {
            return;
        }

        Vector2 _0x9101ddf2 = _0xe13fb90e.anchoredPosition;
        _0xe13fb90e.anchoredPosition = new Vector2(_0x9101ddf2.x, _0x9101ddf2.y - 60f);
        _0xe13fb90e.DOAnchorPosY(_0x9101ddf2.y, 0.35f).SetEase(Ease.OutCubic).SetDelay(_0xe6e1424a).SetLink(_0xe13fb90e.gameObject);
    }

    private void _0xfe917f75()
    {
        int _0x23c161b0 = _0x4667b7b4.SelectedLevel() + 1;
        int _0xf56dc77b = _0x4667b7b4.BestOverall();
        _0x4c815587.Label(this._0xcb5f0a27, _0x6dde2a03._0xc73fb1d2(new byte[8] { 253, 223, 194, 202, 223, 200, 222, 222 }, 173), this._font, _0x6dde2a03._0xc73fb1d2(new byte[5] { 194, 215, 204, 193, 165 }, 133) + _0x23c161b0 + _0x6dde2a03._0xc73fb1d2(new byte[4] { 89, 54, 63, 89 }, 121) + _0x1b49e039.TotalLevels + _0x6dde2a03._0xc73fb1d2(new byte[12] { 117, 117, 117, 120, 117, 117, 117, 23, 16, 6, 1, 117 }, 85) + _0xf56dc77b + _0x6dde2a03._0xc73fb1d2(new byte[1] { 182 }, 147), new Vector2(0.5f, 0.062f), Vector2.zero, new Vector2(900f, 76f), _0xf2af3007.TextMuted, 30f, 38f);
    }

    [SerializeField]
    private _0x9e348b6e _howTo;
    private void _0xe6992b0d()
    {
        Button _0x2b16a691 = _0x4c815587.Action(this._0xcb5f0a27, _0x6dde2a03._0xc73fb1d2(new byte[12] { 111, 70, 85, 70, 79, 80, 98, 64, 87, 74, 76, 77 }, 35), this._roundPlate, this._font, _0x6dde2a03._0xc73fb1d2(new byte[6] { 243, 250, 233, 250, 243, 236 }, 191), new Vector2(0.5f, 0.206f), Vector2.zero, new Vector2(520f, 128f), _0xf2af3007.WithAlpha(_0xf2af3007.AccentAmber, 0.8f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.96f), _0xf2af3007.TextPrimary, 42f);
        _0x2b16a691.onClick.AddListener(() => this._0x08b0ff6f());
        this._0xf1928c5e(_0x2b16a691.transform as RectTransform, 0.06f);
        Button _0x1b85ea21 = _0x4c815587.Action(this._0xcb5f0a27, _0x6dde2a03._0xc73fb1d2(new byte[11] { 0, 39, 63, 28, 39, 9, 43, 60, 33, 39, 38 }, 72), this._roundPlate, this._font, _0x6dde2a03._0xc73fb1d2(new byte[11] { 23, 16, 8, 127, 11, 16, 127, 15, 19, 30, 6 }, 95), new Vector2(0.5f, 0.130f), Vector2.zero, new Vector2(520f, 120f), _0xf2af3007.WithAlpha(_0xf2af3007.TextMuted, 0.7f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.96f), _0xf2af3007.TextPrimary, 36f);
        _0x1b85ea21.onClick.AddListener(() => this._0x78ef76f0());
        this._0xf1928c5e(_0x1b85ea21.transform as RectTransform, 0.12f);
    }

    [SerializeField]
    private _0xb399c1a4 _gate;
    private void Start()
    {
        _0x29eaf145 _0x5faeab10 = this._0x364f4369();
        if (_0x5faeab10 == null || _0x5faeab10.Content == null)
        {
            return;
        }

        this._0xcb5f0a27 = (RectTransform)_0x5faeab10.Content.transform;
        this._0x2f1954e1();
        this._0x6eda4334();
        this._0xb7c63acb();
        this._0x1eba9003();
        this._0xb24a849d();
        this._0xe6992b0d();
        this._0xfe917f75();
        if (this._howTo != null)
        {
            this._howTo._0xe0615b38(this._0xcb5f0a27);
        }

        if (this._levels != null)
        {
            this._levels._0x1ac6782b(this._0xcb5f0a27);
        }

        if (this._gate != null)
        {
            this._gate._0xb433fab7(this._howTo != null ? this._howTo._0x0367ac18 : null, this._howTo != null ? this._howTo._0x9720c835 : null, this._levels != null ? this._levels._0xa6bccf07 : null, this._levels != null ? this._levels._0xbb94af5c : null);
        }
    }

    private const int PreviewStrokes = 7;
    [SerializeField]
    private _0x71cd593f _levels;
    private void _0x6eda4334()
    {
        RectTransform _0x4e21d969 = _0x4c815587.Node(this._0xcb5f0a27, _0x6dde2a03._0xc73fb1d2(new byte[6] { 133, 173, 162, 172, 165, 173 }, 192), new Vector2(0.5f, 0.800f), Vector2.zero, new Vector2(520f, 520f));
        RectTransform _0x209b74b1 = _0x4c815587.Node(_0x4e21d969, _0x6dde2a03._0xc73fb1d2(new byte[4] { 74, 121, 97, 107 }, 24), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(10f, 10f));
        for (int _0x88a31349 = 0; _0x88a31349 < Rays; _0x88a31349++)
        {
            RectTransform _0x8e213e47 = _0x4c815587.Node(_0x209b74b1, _0x6dde2a03._0xc73fb1d2(new byte[3] { 156, 175, 183 }, 206), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(12f, 230f));
            _0x8e213e47.pivot = new Vector2(0.5f, 0f);
            _0x8e213e47.anchoredPosition = Vector2.zero;
            _0x8e213e47.localRotation = Quaternion.Euler(0f, 0f, _0x88a31349 * (360f / Rays));
            Image _0x4c47d616 = _0x8e213e47.gameObject.AddComponent<Image>();
            _0x4c47d616.color = _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.35f);
            _0x4c47d616.raycastTarget = false;
            _0x4c47d616.DOFade(1f, 0.55f).SetLoops(-1, LoopType.Yoyo).SetDelay(_0x88a31349 * 0.09f).SetLink(_0x4c47d616.gameObject);
        }

        _0x209b74b1.DOLocalRotate(new Vector3(0f, 0f, 360f), 26f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).SetLink(_0x209b74b1.gameObject);
        Image _0x114e2dfb = _0x4c815587.Picture(_0x4e21d969, _0x6dde2a03._0xc73fb1d2(new byte[4] { 51, 31, 2, 21 }, 112), this._nodeCore, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(280f, 280f), Color.white);
        _0x114e2dfb.transform.localScale = Vector3.one * 0.86f;
        _0x114e2dfb.transform.DOScale(1f, 0.45f).SetEase(Ease.OutBack).SetLink(_0x114e2dfb.gameObject);
        _0x114e2dfb.transform.DOScale(1.06f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetDelay(0.5f).SetLink(_0x114e2dfb.gameObject);
    }

    private void _0x78ef76f0()
    {
        if (this._gate != null)
        {
            this._gate._0x5508fa4c();
        }
    }

    private void _0x08b0ff6f()
    {
        if (this._gate != null)
        {
            this._gate._0xd2b7da59();
        }
    }

    /// <summary>
    /// §G.3: the scene already carries a LoadSceneButton pointing at SCENE_1, with every one of
    /// its own graphics switched off. Its rect is resized in the scene file; here it only gets a
    /// visible face, added as its CHILD so the click still reaches the template's own Button.
    /// </summary>
    private void _0xb24a849d()
    {
        _0x0cc9cf21 _0xad2be2ee = this._0xcb5f0a27.GetComponentInChildren<_0x0cc9cf21>(true);
        if (_0xad2be2ee == null)
        {
            return;
        }

        RectTransform _0xe7512cd8 = _0xad2be2ee.transform as RectTransform;
        if (_0xe7512cd8 == null)
        {
            return;
        }

        Vector2 _0xb8b77651 = _0xe7512cd8.sizeDelta;
        if (_0xb8b77651.x < 1f || _0xb8b77651.y < 1f)
        {
            _0xb8b77651 = new Vector2(760f, 168f);
        }

        Image _0x3120e504 = _0x4c815587.Plate(_0xe7512cd8, _0x6dde2a03._0xc73fb1d2(new byte[8] { 132, 163, 182, 165, 163, 133, 190, 186 }, 215), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, _0xb8b77651, _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.95f), _0x4c815587.Ppu(_0xb8b77651.y), true);
        _0x3120e504.rectTransform.anchorMin = Vector2.zero;
        _0x3120e504.rectTransform.anchorMax = Vector2.one;
        _0x3120e504.rectTransform.offsetMin = Vector2.zero;
        _0x3120e504.rectTransform.offsetMax = Vector2.zero;
        Image _0x269df337 = _0x4c815587.Plate(_0xe7512cd8, _0x6dde2a03._0xc73fb1d2(new byte[9] { 85, 114, 103, 116, 114, 68, 105, 98, 127 }, 6), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, _0xb8b77651, _0xf2af3007.WithAlpha(_0xf2af3007.Surface2, 0.98f), _0x4c815587.Ppu(_0xb8b77651.y), false);
        _0x269df337.rectTransform.anchorMin = Vector2.zero;
        _0x269df337.rectTransform.anchorMax = Vector2.one;
        _0x269df337.rectTransform.offsetMin = new Vector2(6f, 6f);
        _0x269df337.rectTransform.offsetMax = new Vector2(-6f, -6f);
        TextMeshProUGUI _0x7f903788 = _0x4c815587.Label(_0xe7512cd8, _0x6dde2a03._0xc73fb1d2(new byte[12] { 175, 136, 157, 142, 136, 191, 157, 140, 136, 149, 147, 146 }, 252), this._font, _0x6dde2a03._0xc73fb1d2(new byte[5] { 6, 1, 20, 7, 1 }, 85), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xb8b77651.x - 60f, _0xb8b77651.y - 36f), _0xf2af3007.TextPrimary, 44f, 60f);
        _0x7f903788.rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        _0x7f903788.rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        _0xe7512cd8.localScale = Vector3.one;
        _0xe7512cd8.SetAsLastSibling();
        _0x3120e504.DOFade(0.65f, 1.3f).SetLoops(-1, LoopType.Yoyo).SetLink(_0x3120e504.gameObject);
    }

    [SerializeField]
    private Sprite _nodeCore;
    [SerializeField]
    private TMP_FontAsset _font;
    /// <summary>
    /// The menu scene is destroyed when a grid is opened. Endless tweens that outlive their
    /// targets throw inside DOTween's update and freeze EVERY tween in the next scene, including
    /// the template's panel transition (ANDROID-3776). SetLink already ties each tween to its
    /// object; this kill is the second guard.
    /// </summary>
    private void OnDestroy()
    {
        if (this._0xcb5f0a27 == null)
        {
            return;
        }

        foreach (Component _0x59ca52d3 in this._0xcb5f0a27.GetComponentsInChildren<Component>(true))
        {
            if (_0x59ca52d3 != null)
            {
                DOTween.Kill(_0x59ca52d3);
            }
        }
    }

    /// <summary>HUD corner brackets and a faint seven-stroke grid, drawn FIRST so everything
    /// else lands on top of it (C.13).</summary>
    private void _0x2f1954e1()
    {
        RectTransform _0x8660049c = _0x4c815587.Stretch(this._0xcb5f0a27, _0x6dde2a03._0xc73fb1d2(new byte[12] { 23, 63, 52, 47, 24, 59, 57, 49, 62, 40, 53, 42 }, 90));
        for (int _0xec45685d = 0; _0xec45685d < 4; _0xec45685d++)
        {
            float _0x1e0d58ef = (_0xec45685d % 2) == 0 ? 0.085f : 0.915f;
            float _0x1d6db6d5 = _0xec45685d < 2 ? 0.95f : 0.05f;
            _0x4c815587.Quad(_0x8660049c, _0x6dde2a03._0xc73fb1d2(new byte[8] { 186, 138, 153, 155, 147, 157, 140, 176 }, 248), new Vector2(_0x1e0d58ef, _0x1d6db6d5), Vector2.zero, new Vector2(150f, 8f), _0xf2af3007.WithAlpha(_0xf2af3007.Line, 0.45f), false);
            _0x4c815587.Quad(_0x8660049c, _0x6dde2a03._0xc73fb1d2(new byte[8] { 140, 188, 175, 173, 165, 171, 186, 152 }, 206), new Vector2(_0x1e0d58ef, _0x1d6db6d5), new Vector2(((_0xec45685d % 2) == 0 ? -71f : 71f), (_0xec45685d < 2 ? -71f : 71f)), new Vector2(8f, 150f), _0xf2af3007.WithAlpha(_0xf2af3007.Line, 0.45f), false);
        }

        for (int _0x5e0c42fc = 0; _0x5e0c42fc < PreviewStrokes; _0x5e0c42fc++)
        {
            _0x4c815587.Quad(_0x8660049c, _0x6dde2a03._0xc73fb1d2(new byte[10] { 66, 119, 108, 97, 86, 113, 119, 106, 110, 96 }, 5), new Vector2(0.5f, 0.5f), new Vector2((_0x5e0c42fc - 3) * 150f, 0f), new Vector2(4f, 1500f), _0xf2af3007.WithAlpha(_0xf2af3007.AccentCyan, 0.07f), false);
        }
    }

    /// <summary>The live network preview the brief asks for: seven lines, three nodes, beads.</summary>
    private void _0x1eba9003()
    {
        RectTransform _0x80f6b8d4 = _0x4c815587.Node(this._0xcb5f0a27, _0x6dde2a03._0xc73fb1d2(new byte[13] { 30, 46, 37, 40, 32, 40, 29, 63, 40, 59, 36, 40, 58 }, 77), new Vector2(0.5f, 0.500f), Vector2.zero, new Vector2(980f, 240f));
        _0x4c815587.Plate(_0x80f6b8d4, _0x6dde2a03._0xc73fb1d2(new byte[12] { 74, 104, 127, 108, 115, 127, 109, 74, 118, 123, 110, 127 }, 26), this._roundPlate, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(980f, 240f), _0xf2af3007.WithAlpha(_0xf2af3007.Surface, 0.55f), _0x4c815587.Ppu(240f), false);
        for (int _0x92d5c00e = 0; _0x92d5c00e < PreviewStrokes; _0x92d5c00e++)
        {
            float _0xbf1173b8 = (_0x92d5c00e - 3) * 128f;
            _0x4c815587.Quad(_0x80f6b8d4, _0x6dde2a03._0xc73fb1d2(new byte[4] { 16, 53, 50, 57 }, 92), new Vector2(0.5f, 0.5f), new Vector2(_0xbf1173b8, 0f), new Vector2(8f, 180f), _0xf2af3007.WithAlpha(_0xf2af3007.Line, 0.55f), false);
        }

        Color[] _0x5af09ccc = _0xf2af3007.FlowColours();
        for (int _0xc9ca83e8 = 0; _0xc9ca83e8 < 3; _0xc9ca83e8++)
        {
            float _0x6651909a = (_0xc9ca83e8 - 1) * 256f;
            _0x4c815587.Picture(_0x80f6b8d4, _0x6dde2a03._0xc73fb1d2(new byte[4] { 174, 143, 132, 133 }, 224), this._switchSprite, new Vector2(0.5f, 0.5f), new Vector2(_0x6651909a, 0f), new Vector2(76f, 76f), _0x5af09ccc[(_0xc9ca83e8 + 1) % _0x5af09ccc.Length]);
        }

        for (int _0x7893986d = 0; _0x7893986d < 4; _0x7893986d++)
        {
            float _0xd1ba3856 = (_0x7893986d - 2) * 128f;
            Image _0x0b3cdfd1 = _0x4c815587.Picture(_0x80f6b8d4, _0x6dde2a03._0xc73fb1d2(new byte[4] { 169, 142, 138, 143 }, 235), this._pulseSprite, new Vector2(0.5f, 0.5f), new Vector2(_0xd1ba3856, 90f), new Vector2(44f, 44f), _0x5af09ccc[_0x7893986d % _0x5af09ccc.Length]);
            _0x0b3cdfd1.rectTransform.DOAnchorPosY(-90f, 1.6f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).SetDelay(_0x7893986d * 0.22f).SetLink(_0x0b3cdfd1.gameObject);
        }
    }

    [SerializeField]
    private Sprite _pulseSprite;
    [SerializeField]
    private Sprite _switchSprite;
    private void _0xb7c63acb()
    {
        TextMeshProUGUI _0x323a0dfd = _0x4c815587.Label(this._0xcb5f0a27, _0x6dde2a03._0xc73fb1d2(new byte[9] { 105, 68, 76, 67, 69, 82, 79, 80, 67 }, 38), this._font, _0x6dde2a03._0xc73fb1d2(new byte[40] { 194, 223, 197, 196, 213, 176, 213, 198, 213, 194, 201, 176, 211, 216, 209, 222, 222, 213, 220, 154, 221, 209, 196, 211, 216, 176, 213, 198, 213, 194, 201, 176, 194, 213, 211, 213, 217, 198, 213, 194 }, 144), new Vector2(0.5f, 0.618f), Vector2.zero, new Vector2(1040f, 130f), _0xf2af3007.TextPrimary, 34f, 46f);
        CanvasGroup _0x6b05aecb = _0x323a0dfd.gameObject.AddComponent<CanvasGroup>();
        _0x6b05aecb.alpha = 0f;
        _0x6b05aecb.DOFade(1f, 0.3f).SetDelay(0.08f).SetLink(_0x6b05aecb.gameObject);
    }
}

internal static class _0x6dde2a03
{
    internal static string _0xc73fb1d2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}