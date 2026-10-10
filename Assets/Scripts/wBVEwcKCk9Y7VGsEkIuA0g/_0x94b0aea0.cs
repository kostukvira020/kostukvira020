using DG.Tweening;
using UnityEngine;

/// <summary>
/// Runs one grid: the flow never stops, the player only ever exchanges two neighbouring
/// deflectors, and every receiver either fills with its own colour or slowly poisons.
///
/// BALANCE (C.5). Contamination is 1.0 unit/s PER RECEIVER — never per incoming flow — so a
/// completely passive run survives 120 / 1.0 = 120 s on every level, twice the 60 s floor and
/// far past the review capture window. The fastest possible win is 100 / 3.2 = 31 s and the
/// generator guarantees at least two wrong receivers at the start, so no round can resolve
/// itself before the reviewer sees the board.
/// </summary>
public sealed class _0x94b0aea0 : MonoBehaviour
{
    private const float ContamCapacity = 120f;
    private void _0xe752ee56(string _0xe18bac00)
    {
        if (this._0x3e0e886a == PhaseFinished || _0x0067139d.Instance == null)
        {
            return;
        }

        this._0x3e0e886a = PhaseFinished;
        this._0x74c2e64d();
        if (this._input != null)
        {
            this._input.enabled = false;
        }

        if (this._field != null)
        {
            this._field._0xa097bb94();
        }

        _0x941938ef _0xe4fcea0c = _0x0067139d.Instance._0x88bf3b82(_0x56576ecc._0x2cde3fea.LOSE);
        _0x5241fa6a.Arm(_0xe4fcea0c);
        if (this._popDresser != null)
        {
            this._popDresser._0x2cab56bf(_0xe18bac00, _0x99c3880c._0x0a54fb90(new byte[7] { 135, 132, 136, 128, 142, 143, 235 }, 203) + this._0x6ddedfb5 + _0x99c3880c._0x0a54fb90(new byte[11] { 139, 228, 237, 139, 156, 161, 236, 249, 226, 239, 139 }, 171) + (this._0xf56a87f7 + 1));
        }

        DOVirtual.DelayedCall(0.7f, () => this._0x0b8aa6f0()).SetLink(this.gameObject);
    }

    private _0x1b49e039 _0x25eef07f;
    private int _0xfd195aa0;
    [SerializeField]
    private _0x5241fa6a _popDresser;
    private void _0xb38dc99f()
    {
        if (this._popDresser == null || _0x0067139d.Instance == null)
        {
            return;
        }

        _0x941938ef _0x6c0766c1 = _0x0067139d.Instance._0x88bf3b82(_0x56576ecc._0x2cde3fea.WIN);
        _0x941938ef _0xf6d4c80c = _0x0067139d.Instance._0x88bf3b82(_0x56576ecc._0x2cde3fea.LOSE);
        _0x941938ef _0x13ccf451 = _0x0067139d.Instance._0x88bf3b82(_0x56576ecc._0x2cde3fea.PAUSE);
        if (_0x6c0766c1 == null || _0xf6d4c80c == null || _0x13ccf451 == null)
        {
            return;
        }

        if (!_0x6c0766c1.gameObject.activeInHierarchy || !_0xf6d4c80c.gameObject.activeInHierarchy || !_0x13ccf451.gameObject.activeInHierarchy)
        {
            return;
        }

        this._popDresser._0x59acd72f(_0x6c0766c1, _0xf6d4c80c, _0x13ccf451);
        this._0xea8cc6c9 = true;
    }

    private void _0x41441929(int _0x39a88d13, int _0x432d1c3c)
    {
        this._0x74c2e64d();
        this._0x2d582969 = _0x39a88d13;
        this._0x8f9f7eeb = _0x432d1c3c;
        _0xe5f2edcd _0x388272cf = this._field._0x2d09c85a(_0x39a88d13, _0x432d1c3c);
        if (_0x388272cf != null)
        {
            _0x388272cf._0x5d36c5af(true);
        }
    }

    private void _0x29e83e7f(int _0x7526a71c)
    {
        _0x4667b7b4.SelectLevel(_0x7526a71c);
        if (_0x0067139d.Instance != null)
        {
            _0x0067139d.Instance._0x66e2dc88();
        }

        if (_0x58a96848.Instance != null)
        {
            _0x58a96848.Instance._0x1784a8c9(true);
            _0x58a96848.Instance._0x1d00d384(_0x56576ecc._0x3578949a.SCENE_1);
        }
    }

    private int _0x6ddedfb5;
    private readonly float[] _0x0436613e = new float[_0x644b9457.Channels];
    /// <summary>
    /// Nothing calls SetPhysicsRun(true) when a pop closes by any route but ours, so the run
    /// would stay frozen and the board dead. Re-arm it once no dimmer is up.
    /// </summary>
    private void _0xc290dbed()
    {
        if (this._0x3e0e886a != PhaseRouting || _0x58a96848.Instance == null || _0x58a96848.Instance._0x42ac3830)
        {
            return;
        }

        if (_0x5bd4077c.Instance == null || _0x5bd4077c.Instance.CurrentPanelIndex != _0x56576ecc._0x7463064a.DEFAULT)
        {
            return;
        }

        _0x0067139d _0x4afb33f3 = _0x0067139d.Instance;
        if (_0x4afb33f3 == null || _0x4afb33f3.BlurBackground == null || _0x4afb33f3.BlurBackground.activeInHierarchy)
        {
            return;
        }

        _0x58a96848.Instance._0x1784a8c9(true);
    }

    private const int PhaseBooting = 0;
    private const float RoundBackstopSec = 150f;
    private const float ContamRate = 1.0f;
    private Transform _0x1d1a94b8;
    private void _0x3e8c730d(float _0xd5456be2)
    {
        Color[] _0xa5c4fb24 = _0xf2af3007.FlowColours();
        for (int _0xf7446abd = 0; _0xf7446abd < _0x644b9457.Channels; _0xf7446abd++)
        {
            if (this._0x428f4b74[_0xf7446abd])
            {
                continue;
            }

            bool _0x5796a9de = false;
            bool _0xd681d4b6 = false;
            for (int _0xbdd41c71 = 0; _0xbdd41c71 < _0x644b9457.Channels; _0xbdd41c71++)
            {
                if (this._0x84f63b01._0xfab3d94d(_0xbdd41c71) != _0xf7446abd)
                {
                    continue;
                }

                if (this._0x13edc9e4.SourceColour[_0xbdd41c71] == this._0x13edc9e4.TargetColour[_0xf7446abd])
                {
                    _0x5796a9de = true;
                }
                else
                {
                    _0xd681d4b6 = true;
                }
            }

            if (_0x5796a9de)
            {
                this._0x90889bcc[_0xf7446abd] += this._0x13edc9e4.FillRate * _0xd5456be2;
            }

            if (_0xd681d4b6)
            {
                // ONE rate per receiver, whatever the number of wrong flows pouring in.
                this._0x0436613e[_0xf7446abd] += ContamRate * _0xd5456be2;
            }

            _0x2d306f33 _0x5d69951e = this._field != null ? this._field._0x3aafbcbd(_0xf7446abd) : null;
            Color _0x3fa8c01a = _0xa5c4fb24[this._0x13edc9e4.TargetColour[_0xf7446abd] % _0xa5c4fb24.Length];
            if (_0x5d69951e != null)
            {
                _0x5d69951e._0x16bc3ce6(this._0x90889bcc[_0xf7446abd] / ReceiverTarget, _0x3fa8c01a);
                _0x5d69951e._0x78c8506d(this._0x0436613e[_0xf7446abd] / ContamCapacity);
            }

            if (this._hud != null)
            {
                int _0x08f2eb04 = Mathf.Clamp(Mathf.RoundToInt(this._0x90889bcc[_0xf7446abd] / ReceiverTarget * 100f), 0, 99);
                bool _0x67326062 = this._0x0436613e[_0xf7446abd] > 1f;
                this._hud._0x0c285c9f(_0xf7446abd, _0x08f2eb04 + _0x99c3880c._0x0a54fb90(new byte[1] { 196 }, 225), _0x67326062 ? _0xf2af3007.AccentRose : _0xf2af3007.TextMuted);
            }

            if (this._0x0436613e[_0xf7446abd] >= ContamCapacity)
            {
                this._0x80494cef = _0xf7446abd + 1;
                this._0xe752ee56(_0x99c3880c._0x0a54fb90(new byte[9] { 147, 132, 130, 132, 136, 151, 132, 147, 225 }, 193) + this._0x80494cef + _0x99c3880c._0x0a54fb90(new byte[11] { 16, 127, 102, 117, 98, 118, 121, 124, 124, 117, 116 }, 48));
                return;
            }

            if (this._0x90889bcc[_0xf7446abd] < ReceiverTarget)
            {
                continue;
            }

            this._0x428f4b74[_0xf7446abd] = true;
            this._0x6ddedfb5++;
            this._0x0436613e[_0xf7446abd] = 0f;
            if (this._field != null)
            {
                this._field._0x1c03d5fe(_0xf7446abd, _0x3fa8c01a);
            }

            if (this._hud != null)
            {
                this._hud._0x69836b6b(this._0x6ddedfb5);
                this._hud._0x0c285c9f(_0xf7446abd, _0x99c3880c._0x0a54fb90(new byte[4] { 147, 144, 156, 148 }, 223), _0xf2af3007.AccentAmber);
            }
        }
    }

    private int _0x2d582969 = -1;
    [SerializeField]
    private _0x54ed284c _input;
    private _0x29eaf145 _0x804d15ec()
    {
        _0x5bd4077c _0xe56377ab = _0x5bd4077c.Instance;
        if (_0xe56377ab == null || _0xe56377ab.Panels == null)
        {
            return null;
        }

        int _0x194e65ce = _0x56576ecc._0x7463064a.DEFAULT;
        return _0x194e65ce < 0 || _0x194e65ce >= _0xe56377ab.Panels.Count ? null : _0xe56377ab.Panels[_0x194e65ce];
    }

    public void _0x5b2708db()
    {
        if (_0x58a96848.Instance == null)
        {
            return;
        }

        _0x58a96848.Instance._0x1784a8c9(true);
        _0x58a96848.Instance._0x1d00d384(_0x56576ecc._0x3578949a.SCENE_0);
    }

    [SerializeField]
    private _0xeb0d5652 _hud;
    private int _0x80494cef;
    private int _0x8f9f7eeb = -1;
    /// <summary>
    /// The template parents its own HUD (TopPanel and friends) under this panel's body. This
    /// game draws its own, so every pre-existing child is switched off — one consistent set of
    /// controls instead of template + generated side by side (§H, C.2).
    /// </summary>
    private void _0x2a9c2f38()
    {
        if (this._0x1d1a94b8 == null)
        {
            return;
        }

        for (int _0xe2e89091 = 0; _0xe2e89091 < this._0x1d1a94b8.childCount; _0xe2e89091++)
        {
            Transform _0xd7e3d406 = this._0x1d1a94b8.GetChild(_0xe2e89091);
            if (_0xd7e3d406 == null)
            {
                continue;
            }

            if (_0xd7e3d406.GetComponentInChildren<_0x941938ef>(true) != null)
            {
                continue;
            }

            if (this._hud != null && this._hud._0xff467224(_0xd7e3d406))
            {
                continue;
            }

            _0xd7e3d406.gameObject.SetActive(false);
        }
    }

    private void _0x0b8aa6f0()
    {
        if (_0x0067139d.Instance != null)
        {
            _0x0067139d.Instance._0x176fb661(_0x56576ecc._0x2cde3fea.LOSE);
        }
    }

    private void _0x35439301(int _0x82a2a9bb, int _0x65bec807)
    {
        if (this._0xe9c09ffd() <= 0)
        {
            // Out of budget is not the end of the round (C.5) — the flow keeps running, so the
            // refusal has to be VISIBLE instead (C.7).
            _0xe5f2edcd _0x8d6ff36c = this._field._0x2d09c85a(_0x82a2a9bb, _0x65bec807);
            if (_0x8d6ff36c != null)
            {
                _0x8d6ff36c._0x4cd25d71();
            }

            this._0x74c2e64d();
            return;
        }

        this._0x74c2e64d();
        this._0x13edc9e4._0xf1c388f5(_0x82a2a9bb, _0x65bec807);
        this._field._0x1c1d3c15(_0x82a2a9bb, _0x65bec807);
        this._0xfd195aa0++;
        this._field._0x8608a5dd();
        if (this._hud != null)
        {
            this._hud._0xb90192ef(this._0xe9c09ffd());
        }
    }

    private int _0xf56a87f7;
    private readonly bool[] _0x428f4b74 = new bool[_0x644b9457.Channels];
    private void _0x74c2e64d()
    {
        if (this._0x2d582969 >= 0 && this._field != null)
        {
            _0xe5f2edcd _0x1c69f0f4 = this._field._0x2d09c85a(this._0x2d582969, this._0x8f9f7eeb);
            if (_0x1c69f0f4 != null)
            {
                _0x1c69f0f4._0x5d36c5af(false);
            }
        }

        this._0x2d582969 = -1;
        this._0x8f9f7eeb = -1;
    }

    private int _0xe9c09ffd()
    {
        int _0x9affc277 = this._0x13edc9e4.MoveLimit - this._0xfd195aa0;
        return _0x9affc277 < 0 ? 0 : _0x9affc277;
    }

    public void _0x7cbf7dda()
    {
        if (_0x0067139d.Instance != null)
        {
            _0x0067139d.Instance._0x66e2dc88();
        }

        this._0x2a9c2f38();
        if (_0x58a96848.Instance != null && this._0x3e0e886a == PhaseRouting)
        {
            _0x58a96848.Instance._0x1784a8c9(true);
        }
    }

    private void Update()
    {
        if (!this._0xea8cc6c9)
        {
            this._0xb38dc99f();
        }

        this._0xc290dbed();
        if (this._0x3e0e886a != PhaseRouting || _0x58a96848.Instance == null || !_0x58a96848.Instance._0x42ac3830)
        {
            return;
        }

        float dt = Time.deltaTime;
        this._0xe555cbc2 += dt;
        this._0x3e8c730d(dt);
        if (this._0x6ddedfb5 >= _0x644b9457.Channels)
        {
            this._0xa2b6cdd3();
            return;
        }

        if (this._0xe555cbc2 >= RoundBackstopSec)
        {
            this._0xe752ee56(_0x99c3880c._0x0a54fb90(new byte[14] { 34, 40, 43, 51, 68, 48, 45, 41, 33, 32, 68, 43, 49, 48 }, 100));
        }
    }

    [SerializeField]
    private _0x61dfe555 _sweeper;
    public void _0x1e9c448b()
    {
        this._0x29e83e7f(this._0xf56a87f7);
    }

    [SerializeField]
    private _0x7a0263c9 _field;
    private _0x67292414 _0x84f63b01;
    private readonly float[] _0x90889bcc = new float[_0x644b9457.Channels];
    private const int PhaseRouting = 1;
    public void _0x6698abae()
    {
        if (this._0x3e0e886a != PhaseRouting || _0x0067139d.Instance == null)
        {
            return;
        }

        if (_0x58a96848.Instance != null)
        {
            _0x58a96848.Instance._0x1784a8c9(false);
        }

        _0x941938ef _0xec7aa9ab = _0x0067139d.Instance._0x88bf3b82(_0x56576ecc._0x2cde3fea.PAUSE);
        _0x5241fa6a.Arm(_0xec7aa9ab);
        if (this._popDresser != null)
        {
            this._popDresser._0xb58cc678(_0x99c3880c._0x0a54fb90(new byte[17] { 42, 39, 39, 75, 40, 35, 42, 37, 37, 46, 39, 56, 75, 35, 46, 39, 47 }, 107), _0x99c3880c._0x0a54fb90(new byte[11] { 106, 110, 120, 105, 106, 25, 117, 124, 127, 109, 25 }, 57) + this._0xe9c09ffd() + _0x99c3880c._0x0a54fb90(new byte[8] { 215, 145, 146, 158, 150, 152, 153, 253 }, 221) + this._0x6ddedfb5 + _0x99c3880c._0x0a54fb90(new byte[5] { 241, 158, 151, 241, 230 }, 209));
        }

        _0x0067139d.Instance._0x176fb661(_0x56576ecc._0x2cde3fea.PAUSE);
    }

    private bool _0xea8cc6c9;
    private void Start()
    {
        this._0x3e0e886a = PhaseBooting;
        this._0x25eef07f = new _0x1b49e039();
        this._0xf56a87f7 = _0x4667b7b4.SelectedLevel();
        _0x29eaf145 _0x650d0458 = this._0x804d15ec();
        if (_0x650d0458 != null && _0x650d0458.Content != null)
        {
            this._0x1d1a94b8 = _0x650d0458.Content.transform;
            this._0x2a9c2f38();
        }

        this._0x13edc9e4 = this._0x25eef07f._0x09d51a76(this._0xf56a87f7, _0x4667b7b4.NextAttempt(this._0xf56a87f7));
        this._0x84f63b01 = new _0x67292414(4);
        if (this._field != null)
        {
            this._field._0xb077fe1b(this._0x13edc9e4, this._0x84f63b01);
        }

        if (this._hud != null && this._0x1d1a94b8 != null)
        {
            this._hud._0x3ef905a2((RectTransform)this._0x1d1a94b8);
            this._hud._0x579157cd(this._field);
            this._hud._0x8509887c(this._0xf56a87f7 + 1);
            this._hud._0xb90192ef(this._0x13edc9e4.MoveLimit);
            this._hud._0x69836b6b(0);
        }

        if (this._sweeper != null)
        {
            this._sweeper._0x53f000da();
        }

        this._0x3e0e886a = PhaseRouting;
    }

    public void _0xe1f841b1()
    {
        int _0x1b56d332 = this._0xf56a87f7 + 1;
        if (_0x1b56d332 > _0x1b49e039.TotalLevels - 1)
        {
            _0x1b56d332 = 0;
        }

        this._0x29e83e7f(_0x1b56d332);
    }

    /// <summary>World-space tap, already filtered to this frame by the input router.</summary>
    public void _0x1ce9f21e(Vector2 _0x10368338)
    {
        if (this._0x3e0e886a != PhaseRouting || this._field == null)
        {
            return;
        }

        int _0xcd43a11b = this._field._0xecf0a284(_0x10368338.x);
        int _0x11c28f90 = this._field._0xaaf98cb9(_0x10368338.y);
        if (_0xcd43a11b < 0 || _0x11c28f90 < 0)
        {
            this._0x74c2e64d();
            return;
        }

        if (this._0x2d582969 < 0)
        {
            this._0x41441929(_0x11c28f90, _0xcd43a11b);
            return;
        }

        if (_0x11c28f90 == this._0x2d582969 && Mathf.Abs(_0xcd43a11b - this._0x8f9f7eeb) == 1)
        {
            this._0x35439301(_0x11c28f90, Mathf.Min(_0xcd43a11b, this._0x8f9f7eeb));
            return;
        }

        this._0x41441929(_0x11c28f90, _0xcd43a11b);
    }

    private float _0xe555cbc2;
    private void _0xa2b6cdd3()
    {
        if (this._0x3e0e886a == PhaseFinished || _0x0067139d.Instance == null)
        {
            return;
        }

        this._0x3e0e886a = PhaseFinished;
        this._0x74c2e64d();
        if (this._input != null)
        {
            this._input.enabled = false;
        }

        if (this._field != null)
        {
            this._field._0xa097bb94();
        }

        int _0xf5784c45 = this._0x13edc9e4.MoveLimit - this._0x13edc9e4.ScrambleDepth;
        int _0x7ee27dd3 = _0xf5784c45 <= 0 ? 100 : Mathf.RoundToInt(100f * (this._0x13edc9e4.MoveLimit - this._0xfd195aa0) / _0xf5784c45);
        _0x7ee27dd3 = Mathf.Clamp(_0x7ee27dd3, 20, 100);
        int _0x7bebc81c = _0x4667b7b4.StarsFor(_0x7ee27dd3);
        _0x4667b7b4.RecordEfficiency(this._0xf56a87f7, _0x7ee27dd3);
        _0x4667b7b4.Unlock(this._0xf56a87f7 + 1);
        _0x941938ef _0x3184d47c = _0x0067139d.Instance._0x88bf3b82(_0x56576ecc._0x2cde3fea.WIN);
        _0x5241fa6a.Arm(_0x3184d47c);
        if (this._popDresser != null)
        {
            this._popDresser._0x6baca82d(_0x99c3880c._0x0a54fb90(new byte[11] { 32, 35, 35, 44, 38, 44, 32, 43, 38, 60, 69 }, 101) + _0x7ee27dd3 + _0x99c3880c._0x0a54fb90(new byte[1] { 225 }, 196), _0x99c3880c._0x0a54fb90(new byte[11] { 158, 154, 140, 157, 158, 237, 129, 136, 139, 153, 237 }, 205) + this._0xe9c09ffd() + _0x99c3880c._0x0a54fb90(new byte[6] { 117, 56, 45, 54, 59, 95 }, 127) + (this._0xf56a87f7 + 1) + _0x99c3880c._0x0a54fb90(new byte[4] { 106, 5, 12, 106 }, 74) + _0x1b49e039.TotalLevels, _0x7bebc81c);
        }

        DOVirtual.DelayedCall(0.9f, () => this._0x46e1d1a3()).SetLink(this.gameObject);
    }

    private const float ReceiverTarget = 100f;
    private int _0x3e0e886a;
    private _0x644b9457 _0x13edc9e4;
    private void _0x46e1d1a3()
    {
        if (_0x0067139d.Instance != null)
        {
            _0x0067139d.Instance._0x176fb661(_0x56576ecc._0x2cde3fea.WIN);
        }
    }

    private const int PhaseFinished = 2;
}

internal static class _0x99c3880c
{
    internal static string _0x0a54fb90(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}