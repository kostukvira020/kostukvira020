using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xa8a90661 : MonoBehaviour
{
    private void OnEnable()
    {
        if (this._0x9cd98fdd == null)
            this._0x9cd98fdd = _0x94f4450f => this._0x8d039df7(_0x94f4450f);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x9cd98fdd);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x8d039df7(Object _0x009a4da6)
    {
        TMP_Text _0xba2adc61 = _0x009a4da6 as TMP_Text;
        if (_0xba2adc61 != null)
            this._0xa8b05979.Add(_0xba2adc61);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x66210f87)
    {
        return 0.2126f * Linear(_0x66210f87.r) + 0.7152f * Linear(_0x66210f87.g) + 0.0722f * Linear(_0x66210f87.b);
    }

    private static void Fix(TMP_Text _0x14bcfc14)
    {
        if (_0x14bcfc14 == null || !_0x14bcfc14.isActiveAndEnabled)
            return;
        Material _0xaa2fd784 = _0x14bcfc14.fontSharedMaterial;
        if (_0xaa2fd784 == null || !_0xaa2fd784.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xaa2fd784.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xaa2fd784.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x3233e0b6 = _0x14bcfc14.color;
        if (_0x3233e0b6.a <= 0f)
            return;
        Color _0x19ed2368 = _0xaa2fd784.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x3233e0b6, _0x19ed2368) >= MinRatio)
            return;
        Color _0x6429e818 = Luminance(_0x19ed2368) < 0.5f ? Color.white : Color.black;
        Color _0x279d31c1;
        if (Ratio(_0x6429e818, _0x19ed2368) < TargetRatio)
        {
            _0x279d31c1 = _0x6429e818;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x6be199ab = 0f;
            float _0x3f408ec0 = 1f;
            for (int _0xe423d915 = 0; _0xe423d915 < 20; _0xe423d915++)
            {
                float _0xb4b007ca = (_0x6be199ab + _0x3f408ec0) * 0.5f;
                if (Ratio(Color.Lerp(_0x3233e0b6, _0x6429e818, _0xb4b007ca), _0x19ed2368) >= TargetRatio)
                    _0x3f408ec0 = _0xb4b007ca;
                else
                    _0x6be199ab = _0xb4b007ca;
            }

            _0x279d31c1 = Color.Lerp(_0x3233e0b6, _0x6429e818, _0x3f408ec0);
        }

        _0x279d31c1.a = _0x3233e0b6.a;
        _0x14bcfc14.color = _0x279d31c1;
    }

    private static _0xa8a90661 _0x60f57cc7;
    private readonly List<TMP_Text> _0x1d38ca7a = new List<TMP_Text>();
    private static float Ratio(Color _0x43a983c6, Color _0x31fd7346)
    {
        float _0xc44c44a8 = Luminance(_0x43a983c6);
        float _0x5597321a = Luminance(_0x31fd7346);
        return (Mathf.Max(_0xc44c44a8, _0x5597321a) + 0.05f) / (Mathf.Min(_0xc44c44a8, _0x5597321a) + 0.05f);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x60f57cc7 != null)
            return;
        GameObject _0x9f795e83 = new GameObject(_0x89a9a395._0x0b5ca6e9(new byte[16] { 19, 42, 55, 4, 40, 41, 51, 53, 38, 52, 51, 0, 50, 38, 53, 35 }, 71));
        _0x9f795e83.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x9f795e83);
        _0x60f57cc7 = _0x9f795e83.AddComponent<_0xa8a90661>();
    }

    private static float Linear(float _0x4108ea9f)
    {
        _0x4108ea9f = Mathf.Clamp01(_0x4108ea9f);
        return _0x4108ea9f <= 0.03928f ? _0x4108ea9f / 12.92f : Mathf.Pow((_0x4108ea9f + 0.055f) / 1.055f, 2.4f);
    }

    private const float MinOutlineWidth = 0.01f;
    private void LateUpdate()
    {
        if (this._0xa8b05979.Count == 0)
            return;
        this._0x1d38ca7a.Clear();
        this._0x1d38ca7a.AddRange(this._0xa8b05979);
        this._0xa8b05979.Clear();
        for (int _0xf556a23d = 0; _0xf556a23d < this._0x1d38ca7a.Count; _0xf556a23d++)
            Fix(this._0x1d38ca7a[_0xf556a23d]);
    }

    private void OnDisable()
    {
        if (this._0x9cd98fdd != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x9cd98fdd);
    }

    private readonly HashSet<TMP_Text> _0xa8b05979 = new HashSet<TMP_Text>();
    private const float MinRatio = 4.5f;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x9cd98fdd;
    private const float TargetRatio = 7f;
}

internal static class _0x89a9a395
{
    internal static string _0x0b5ca6e9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}