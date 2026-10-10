using DG.Tweening;
using UnityEngine;

/// <summary>
/// Builds and maintains the world half of the game scene: emitters, channel shafts, the rows
/// of deflector tokens, the receivers and the beads of energy running between them.
///
/// EVERY dimension is derived from the scene camera (C.0) — nothing here is a guessed world
/// literal — and every sorting order comes from the named constants below, all inside the
/// -19..-1 corridor so no sprite can ever draw over a pop.
/// </summary>
public sealed class _0x7a0263c9 : MonoBehaviour
{
    private _0x67292414 _0x85cae235;
    [SerializeField]
    private _0xcaeab3ce _pulsePrefab;
    private readonly _0xe5f2edcd[] _0x7b22d579 = new _0xe5f2edcd[_0x644b9457.Channels * 4];
    private Color _0x0de6b9cf(int _0xb5beab24, int _0xaf7683d4, Color[] _0x1776078b)
    {
        for (int _0xde179579 = 0; _0xde179579 < _0x644b9457.Channels; _0xde179579++)
        {
            if (this._0x85cae235._0xc977bac9(_0xde179579, _0xb5beab24) == _0xaf7683d4)
            {
                return _0x1776078b[this._0x808a21f0.SourceColour[_0xde179579] % _0x1776078b.Length];
            }
        }

        return _0xf2af3007.TextMuted;
    }

    public void _0x1c03d5fe(int _0x68b7be19, Color _0x9a4a7653)
    {
        _0x2d306f33 _0x61d1d437 = this._0x3aafbcbd(_0x68b7be19);
        if (_0x61d1d437 != null)
        {
            _0x61d1d437._0x961ef4ed(_0x9a4a7653);
        }
    }

    private const float PulseSpeed = 2.3f;
    public float _0xb3c9a131(int _0xa9495975)
    {
        return this._0xebb3bd16 + (this._0x51585d29 * (_0xa9495975 + 0.5f));
    }

    private void _0x7f9b4224(float _0x84097696)
    {
        float _0x92fec08e = this._0xd8fbe613 * TopFraction;
        float _0x7986444f = this._0xd8fbe613 * RunFraction;
        GameObject _0x17924e98 = new GameObject(_0x33cb5afa._0x7ef462a0(new byte[14] { 215, 248, 244, 253, 245, 211, 240, 242, 250, 225, 253, 240, 229, 244 }, 145));
        _0x17924e98.transform.SetParent(this._0xaf70ac79, false);
        _0x17924e98.transform.localPosition = new Vector3(0f, _0x92fec08e - (_0x7986444f * 0.5f), 0f);
        SpriteRenderer _0xdc7609d1 = _0x17924e98.AddComponent<SpriteRenderer>();
        _0xdc7609d1.drawMode = SpriteDrawMode.Sliced;
        _0xdc7609d1.sprite = this._shaftPrefab != null ? this._shaftPrefab.sprite : null;
        _0xdc7609d1.size = new Vector2(_0x84097696 * 1.05f, _0x7986444f * 1.08f);
        _0xdc7609d1.color = _0xf2af3007.WithAlpha(_0xf2af3007.Line, 0.12f);
        _0xdc7609d1.sortingOrder = OrderBackplate;
    }

    private const int PulsesPerChannel = 3;
    [SerializeField]
    private SpriteRenderer _shaftPrefab;
    private const float BoardWidthFraction = 0.88f;
    private const int OrderShaft = -16;
    public int _0xecf0a284(float _0xc5bd4f5b)
    {
        int _0xa2c41e4b = Mathf.FloorToInt((_0xc5bd4f5b - this._0xebb3bd16) / this._0x51585d29);
        return _0xa2c41e4b < 0 || _0xa2c41e4b > _0x644b9457.Channels - 1 ? -1 : _0xa2c41e4b;
    }

    private readonly _0x2d306f33[] _0xc90d1b79 = new _0x2d306f33[_0x644b9457.Channels];
    private float _0xebb3bd16;
    public void _0xa097bb94()
    {
        for (int _0x72d7624b = 0; _0x72d7624b < this._0x176c8842.Length; _0x72d7624b++)
        {
            if (this._0x176c8842[_0x72d7624b] != null)
            {
                this._0x176c8842[_0x72d7624b].Stop();
            }
        }
    }

    public float _0xa2ab1010(int _0x857d588c)
    {
        float _0x6b14b929 = this._0xd8fbe613 * TopFraction;
        float _0x622ff9b7 = this._0xd8fbe613 * RunFraction;
        return _0x6b14b929 - (_0x622ff9b7 * (_0x857d588c + 1f) / (this._0x586fe22e + 1f));
    }

    private void _0xd480f370()
    {
        float _0x15d5369d = this._0xd8fbe613 * TopFraction;
        float _0x9b1970b5 = this._0xd8fbe613 * RunFraction;
        for (int _0x30992b67 = 0; _0x30992b67 < _0x644b9457.Channels; _0x30992b67++)
        {
            SpriteRenderer _0x512a6ea7 = Instantiate(this._shaftPrefab, this._0xaf70ac79);
            _0x512a6ea7.transform.localPosition = new Vector3(this._0xb3c9a131(_0x30992b67), _0x15d5369d - (_0x9b1970b5 * 0.5f), 0f);
            _0x512a6ea7.transform.localScale = Vector3.one;
            _0x512a6ea7.size = new Vector2(this._0x51585d29 * 0.62f, _0x9b1970b5);
            _0x512a6ea7.color = _0xf2af3007.WithAlpha(_0xf2af3007.Line, 0.32f);
            _0x512a6ea7.sortingOrder = OrderShaft;
        }
    }

    private float _0x586fe22e;
    public float _0x114bf664
    {
        get
        {
            return this._0x67a185ae;
        }
    }

    private float _0x38d5071c;
    private const float ReceiverFraction = -0.490f;
    private readonly _0xcaeab3ce[] _0x176c8842 = new _0xcaeab3ce[_0x644b9457.Channels * PulsesPerChannel];
    private void _0x2a766c90(Color[] _0x7247809e)
    {
        float _0x9ecf552a = this._0xd8fbe613 * TopFraction;
        float _0xa7defd5a = this._0xd8fbe613 * RunFraction;
        float _0x3ac3bfd1 = _0xa7defd5a / PulseSpeed / PulsesPerChannel;
        for (int _0xa634a26b = 0; _0xa634a26b < _0x644b9457.Channels; _0xa634a26b++)
        {
            Vector3[] _0x6e100f66 = new Vector3[this._0x808a21f0.Rows + 2];
            _0x6e100f66[0] = new Vector3(this._0xb3c9a131(_0xa634a26b), _0x9ecf552a, 0f);
            for (int _0x175975a2 = 0; _0x175975a2 < this._0x808a21f0.Rows; _0x175975a2++)
            {
                _0x6e100f66[_0x175975a2 + 1] = new Vector3(this._0xb3c9a131(this._0x85cae235._0xc977bac9(_0xa634a26b, _0x175975a2 + 1)), this._0xa2ab1010(_0x175975a2), 0f);
            }

            _0x6e100f66[this._0x808a21f0.Rows + 1] = new Vector3(this._0xb3c9a131(this._0x85cae235._0xfab3d94d(_0xa634a26b)), _0x9ecf552a - _0xa7defd5a, 0f);
            Color _0x73e8efb3 = _0x7247809e[this._0x808a21f0.SourceColour[_0xa634a26b] % _0x7247809e.Length];
            for (int _0x85f9b8a1 = 0; _0x85f9b8a1 < PulsesPerChannel; _0x85f9b8a1++)
            {
                _0xcaeab3ce _0xae0c7f4e = this._0x176c8842[(_0xa634a26b * PulsesPerChannel) + _0x85f9b8a1];
                if (_0xae0c7f4e != null)
                {
                    _0xae0c7f4e._0x772a331e(_0x73e8efb3);
                    _0xae0c7f4e._0x6ee404ee(_0x6e100f66, PulseSpeed, _0x85f9b8a1 * _0x3ac3bfd1);
                }
            }
        }
    }

    private const int OrderBackplate = -18;
    private readonly SpriteRenderer[] _0xaa8448f5 = new SpriteRenderer[_0x644b9457.Channels];
    private float _0x67a185ae;
    private const int OrderEmitter = -9;
    [SerializeField]
    private _0x2d306f33 _receiverPrefab;
    private const float EmitterFraction = 0.660f;
    [SerializeField]
    private Sprite _emitterSprite;
    public _0xe5f2edcd _0x2d09c85a(int _0x4c45db22, int _0x07046de6)
    {
        int _0x58c27dce = (_0x4c45db22 * _0x644b9457.Channels) + _0x07046de6;
        return _0x58c27dce < 0 || _0x58c27dce >= this._0x7b22d579.Length ? null : this._0x7b22d579[_0x58c27dce];
    }

    private void _0xb2d22709()
    {
        for (int _0x0553ed97 = 0; _0x0553ed97 < this._0x808a21f0.Rows; _0x0553ed97++)
        {
            for (int _0xb36fc0a2 = 0; _0xb36fc0a2 < _0x644b9457.Channels; _0xb36fc0a2++)
            {
                _0xe5f2edcd _0xcbd6d8e4 = Instantiate(this._tokenPrefab, this._0xaf70ac79);
                _0xcbd6d8e4._0xe57a5dc4(_0x0553ed97, _0xb36fc0a2, new Vector3(this._0xb3c9a131(_0xb36fc0a2), this._0xa2ab1010(_0x0553ed97), 0f), this._0x38d5071c);
                this._0xefcd3d3d(_0xcbd6d8e4.gameObject);
                this._0x7b22d579[(_0x0553ed97 * _0x644b9457.Channels) + _0xb36fc0a2] = _0xcbd6d8e4;
            }
        }
    }

    private _0x644b9457 _0x808a21f0;
    public _0x2d306f33 _0x3aafbcbd(int _0xb15533c5)
    {
        return _0xb15533c5 < 0 || _0xb15533c5 >= this._0xc90d1b79.Length ? null : this._0xc90d1b79[_0xb15533c5];
    }

    private float _0xd8fbe613;
    /// <summary>
    /// Prefabs ship with the right orders already; re-stamping keeps every spawned sprite
    /// provably inside the corridor even if a prefab is edited later.
    /// </summary>
    private void _0xefcd3d3d(GameObject _0x5a60f770)
    {
        SpriteRenderer[] _0xb714a742 = _0x5a60f770.GetComponentsInChildren<SpriteRenderer>(true);
        for (int _0x7e84f851 = 0; _0x7e84f851 < _0xb714a742.Length; _0x7e84f851++)
        {
            int _0x9948e7a3 = _0xb714a742[_0x7e84f851].sortingOrder;
            if (_0x9948e7a3 >= 0 || _0x9948e7a3 <= -20)
            {
                _0xb714a742[_0x7e84f851].sortingOrder = OrderFallback;
            }
        }
    }

    private const float TopFraction = 0.600f;
    public float _0x9e31d205
    {
        get
        {
            return this._0xd8fbe613 * ReceiverFraction;
        }
    }

    public int _0xaaf98cb9(float _0x49a332bd)
    {
        float _0xe71f8ef0 = this._0x38d5071c * 0.9f;
        for (int _0x60d6610a = 0; _0x60d6610a < this._0x808a21f0.Rows; _0x60d6610a++)
        {
            if (Mathf.Abs(_0x49a332bd - this._0xa2ab1010(_0x60d6610a)) <= _0xe71f8ef0)
            {
                return _0x60d6610a;
            }
        }

        return -1;
    }

    private void _0xb068f0f0()
    {
        Color[] _0x74130bce = _0xf2af3007.FlowColours();
        float _0x4592fede = this._0x9e31d205;
        for (int _0xcad8fd2f = 0; _0xcad8fd2f < _0x644b9457.Channels; _0xcad8fd2f++)
        {
            _0x2d306f33 _0xf37da9a2 = Instantiate(this._receiverPrefab, this._0xaf70ac79);
            _0xf37da9a2._0x9de67e2f(new Vector3(this._0xb3c9a131(_0xcad8fd2f), _0x4592fede, 0f), this._0x51585d29 * 0.86f);
            _0xf37da9a2._0xc84301b4(_0xf2af3007.WithAlpha(_0x74130bce[this._0x808a21f0.TargetColour[_0xcad8fd2f] % _0x74130bce.Length], 0.92f));
            this._0xefcd3d3d(_0xf37da9a2.gameObject);
            this._0xc90d1b79[_0xcad8fd2f] = _0xf37da9a2;
        }
    }

    private const int OrderFallback = -12;
    /// <summary>Re-read the grid: glyph art, flow tints, bead routes.</summary>
    public void _0x8608a5dd()
    {
        this._0x85cae235._0xcd91fdf8(this._0x808a21f0);
        Color[] _0xa4ee6eef = _0xf2af3007.FlowColours();
        for (int _0x90cdac1d = 0; _0x90cdac1d < _0x644b9457.Channels; _0x90cdac1d++)
        {
            SpriteRenderer _0x6c2f31cb = this._0xaa8448f5[_0x90cdac1d];
            if (_0x6c2f31cb != null)
            {
                Color _0x613a8de7 = _0xa4ee6eef[this._0x808a21f0.SourceColour[_0x90cdac1d] % _0xa4ee6eef.Length];
                _0x6c2f31cb.color = _0xf2af3007.WithAlpha(_0x613a8de7, _0x6c2f31cb.color.a);
            }
        }

        for (int _0x56d18727 = 0; _0x56d18727 < this._0x808a21f0.Rows; _0x56d18727++)
        {
            for (int _0xef6e1745 = 0; _0xef6e1745 < _0x644b9457.Channels; _0xef6e1745++)
            {
                _0xe5f2edcd _0xfcc7e953 = this._0x2d09c85a(_0x56d18727, _0xef6e1745);
                if (_0xfcc7e953 != null)
                {
                    _0xfcc7e953._0xfef7869f(this._0x808a21f0._0xc88631c2(_0x56d18727, _0xef6e1745), _0xf2af3007.WithAlpha(_0xf2af3007.Surface2, 0.95f), this._0x0de6b9cf(_0x56d18727, _0xef6e1745, _0xa4ee6eef));
                }
            }
        }

        this._0x2a766c90(_0xa4ee6eef);
    }

    private const float RunFraction = 0.98f;
    public void _0xb077fe1b(_0x644b9457 _0x9ab21196, _0x67292414 _0x062404f8)
    {
        this._0x808a21f0 = _0x9ab21196;
        this._0x85cae235 = _0x062404f8;
        this._0x586fe22e = _0x9ab21196.Rows;
        Camera _0xe012ee93 = Camera.main;
        this._0xd8fbe613 = _0xe012ee93 != null ? _0xe012ee93.orthographicSize : 5f;
        float _0x1f93d986 = _0xe012ee93 != null ? _0xe012ee93.aspect : 0.45f;
        this._0x67a185ae = this._0xd8fbe613 * _0x1f93d986;
        float _0x7b809a30 = 2f * this._0x67a185ae * BoardWidthFraction;
        this._0xebb3bd16 = -_0x7b809a30 * 0.5f;
        this._0x51585d29 = _0x7b809a30 / _0x644b9457.Channels;
        this._0x38d5071c = this._0x51585d29 * 0.74f;
        this._0xaf70ac79 = this.transform;
        this._0x7f9b4224(_0x7b809a30);
        this._0xd480f370();
        this._0xa2b89df2();
        this._0xb068f0f0();
        this._0xb2d22709();
        this._0x5116855d();
        this._0x8608a5dd();
    }

    public float _0x01633f1f
    {
        get
        {
            return this._0xd8fbe613;
        }
    }

    private void _0xa2b89df2()
    {
        float _0xe36f2d37 = this._0xd8fbe613 * EmitterFraction;
        for (int _0x2c78478f = 0; _0x2c78478f < _0x644b9457.Channels; _0x2c78478f++)
        {
            GameObject _0x909be916 = new GameObject(_0x33cb5afa._0x7ef462a0(new byte[7] { 177, 153, 157, 128, 128, 145, 134 }, 244));
            _0x909be916.transform.SetParent(this._0xaf70ac79, false);
            _0x909be916.transform.localPosition = new Vector3(this._0xb3c9a131(_0x2c78478f), _0xe36f2d37, 0f);
            SpriteRenderer _0xb38ffe6d = _0x909be916.AddComponent<SpriteRenderer>();
            _0xb38ffe6d.drawMode = SpriteDrawMode.Sliced;
            _0xb38ffe6d.sprite = this._emitterSprite;
            _0xb38ffe6d.size = new Vector2(this._0x51585d29 * 0.82f, this._0x51585d29 * 0.82f);
            _0xb38ffe6d.sortingOrder = OrderEmitter;
            this._0xaa8448f5[_0x2c78478f] = _0xb38ffe6d;
            _0xb38ffe6d.DOFade(0.7f, 0.9f).SetLoops(-1, LoopType.Yoyo).SetDelay(_0x2c78478f * 0.11f).SetLink(_0xb38ffe6d.gameObject);
        }
    }

    [SerializeField]
    private _0xe5f2edcd _tokenPrefab;
    private float _0x51585d29;
    public float _0x341f1518
    {
        get
        {
            return this._0x38d5071c;
        }
    }

    private void _0x5116855d()
    {
        for (int _0x4d2439cb = 0; _0x4d2439cb < _0x644b9457.Channels; _0x4d2439cb++)
        {
            for (int _0x39c1c504 = 0; _0x39c1c504 < PulsesPerChannel; _0x39c1c504++)
            {
                _0xcaeab3ce _0x15003352 = Instantiate(this._pulsePrefab, this._0xaf70ac79);
                _0x15003352._0x09ba7ac0(this._0x51585d29 * 0.42f, _0xf2af3007.AccentCyan);
                this._0xefcd3d3d(_0x15003352.gameObject);
                this._0x176c8842[(_0x4d2439cb * PulsesPerChannel) + _0x39c1c504] = _0x15003352;
            }
        }
    }

    private Transform _0xaf70ac79;
    /// <summary>
    /// The player's only move. Both tokens arc past each other, then the lookup table is
    /// swapped so row/column stays truthful without snapping anything back mid-tween.
    /// </summary>
    public void _0x1c1d3c15(int _0xcf2e79f8, int _0x34be5948)
    {
        int _0x7855bf46 = (_0xcf2e79f8 * _0x644b9457.Channels) + _0x34be5948;
        int _0xb5960edb = _0x7855bf46 + 1;
        _0xe5f2edcd _0x7aacf07f = this._0x7b22d579[_0x7855bf46];
        _0xe5f2edcd _0x6dd27171 = this._0x7b22d579[_0xb5960edb];
        if (_0x7aacf07f == null || _0x6dd27171 == null)
        {
            return;
        }

        float _0x13150637 = this._0xa2ab1010(_0xcf2e79f8);
        Vector3 _0x55cc9320 = new Vector3(this._0xb3c9a131(_0x34be5948), _0x13150637, 0f);
        Vector3 _0x0af49231 = new Vector3(this._0xb3c9a131(_0x34be5948 + 1), _0x13150637, 0f);
        _0x7aacf07f._0xc3b0f156(_0x0af49231, this._0x38d5071c * 0.55f, 0.26f);
        _0x6dd27171._0xc3b0f156(_0x55cc9320, -this._0x38d5071c * 0.55f, 0.26f);
        _0x7aacf07f._0xadf5460a(_0xcf2e79f8, _0x34be5948 + 1);
        _0x6dd27171._0xadf5460a(_0xcf2e79f8, _0x34be5948);
        this._0x7b22d579[_0x7855bf46] = _0x6dd27171;
        this._0x7b22d579[_0xb5960edb] = _0x7aacf07f;
    }
}

internal static class _0x33cb5afa
{
    internal static string _0x7ef462a0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}