using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x56576ecc;

public class _0x5bd4077c : MonoBehaviour
{
    private void _0x9262f845(int _0x8b663b63)
    {
        this._0x66ef41fb(_0x8b663b63);
        this._0x92e23e46(_0x8b663b63);
        this.CurrentPanelIndex = _0x8b663b63;
        this.Panels[_0x8b663b63]._0xcbad5226();
    }

    public void _0x1c0e34af(int _0x902c2573)
    {
        this._0x66ef41fb(_0x902c2573);
        this._0x92e23e46(_0x902c2573);
        this.CurrentPanelIndex = _0x902c2573;
        this.Panels[_0x902c2573].Show();
    }

    public void _0x2572bc2d()
    {
        this.LastPanelIndexes.RemoveAll(_0xf7d1bb00 => _0xf7d1bb00 == this.CurrentPanelIndex);
        int _0x99c604c3 = this.LastPanelIndexes.Last();
        this._0x92e23e46(_0x99c604c3);
        this._0x1e1f86a1(_0x99c604c3);
        this.CurrentPanelIndex = _0x99c604c3;
        this.Panels[_0x99c604c3].Show();
    }

    public int CurrentPanelIndex;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public float ScaleDuration = 0.4f;
    private void _0x92e23e46(int _0x507389e7)
    {
        if (_0x507389e7 == _0x7463064a.SPLASH)
            _0x5d8952ef.Instance._0x3d30debb();
        if (_0x58a96848.Instance._0x5653853e == _0x3578949a.SCENE_0)
        {
        }
    }

    public bool IsShowSplashOnStart = true;
    private void _0xa446f314()
    {
        this._0x9262f845(_0x7463064a.SPLASH);
        if (_0x58a96848.Instance._0x5653853e == _0x3578949a.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x5d8952ef.Instance.DefaultAnimationTime);
        }
    }

    public void _0x3da07a0b(int _0xb06b1333)
    {
        if (_0xb06b1333 == _0x7463064a.SPLASH && _0x58a96848.Instance._0x5653853e != _0x3578949a.SCENE_0)
            _0x5d8952ef.Instance._0x026c9cea();
        if (_0x58a96848.Instance._0x5653853e != _0x3578949a.SCENE_0)
        {
            if (_0xb06b1333 == _0x7463064a.SPLASH || _0xb06b1333 == _0x7463064a.TUTORIAL0)
                _0x58a96848.Instance._0x1784a8c9(false);
            else if (_0xb06b1333 == _0x7463064a.DEFAULT)
                _0x58a96848.Instance._0x1784a8c9(true);
        }
    }

    private _0x29eaf145 _0x14d17e58(int _0x49367f26)
    {
        return this.Panels[_0x49367f26];
    }

    private void _0x1e1f86a1(int _0xbd3482c2)
    {
        this.LastPanelIndexes.Add(_0xbd3482c2);
        this.CurrentPanelIndex = _0xbd3482c2;
        for (int _0xfca73cea = 0; _0xfca73cea < this.Panels.Count; _0xfca73cea++)
            if (_0xfca73cea != _0xbd3482c2 && this.Panels[_0xfca73cea] != null)
                this.Panels[_0xfca73cea]._0x326ee02e();
    }

    public static _0x5bd4077c Instance;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5bd4077c>();
    }

    public float StaticBlurMaterialInitialValue;
    private void Start()
    {
        this._0xa446f314();
    }

    private void _0x66ef41fb(int _0x8fcd83e8)
    {
        this.LastPanelIndexes.Add(_0x8fcd83e8);
        this.CurrentPanelIndex = _0x8fcd83e8;
        for (int _0xb63bdce2 = 0; _0xb63bdce2 < this.Panels.Count; _0xb63bdce2++)
            if (_0xb63bdce2 != _0x8fcd83e8 && this.Panels[_0xb63bdce2] != null)
                this.Panels[_0xb63bdce2]._0x326ee02e();
    }

    private void SwitchSplash()
    {
        if (_0x77ebfb7d.Instance.IsTutorialEnabled && !_0x58a96848._0xba396e18._0x20496c73)
            this._0x1c0e34af(_0x7463064a.TUTORIAL0);
        else
            this._0x1c0e34af(_0x7463064a.DEFAULT);
    }

    public List<_0x29eaf145> Panels;
}