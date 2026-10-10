using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xab658c25 : MonoBehaviour
{
    public void _0x1b623dd8()
    {
        if (_0x77ebfb7d.Instance.IsOnlyWinGameEndEnabled)
            this._0xe9136a6a();
        if (!this.IsGameEnd)
        {
            this._0xb9e274df();
            _0x58a96848.IsAfterLevelComplete = false;
            _0x58a96848.IsAfterLevelFailed = true;
            _0x941938ef _0x006a3745 = _0x0067139d.Instance._0x88bf3b82(_0x56576ecc._0x2cde3fea.LOSE).GetComponent<_0x941938ef>();
            if (_0x77ebfb7d.Instance.IsCheckScoreEnabled)
                _0x006a3745.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb70040f3}";
            else
                _0x006a3745.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x006a3745.ContentAdditionalText.text = $"{0}";
            _0x56576ecc._0xad3b7799._0xcf449560 += 0;
            _0x0067139d.Instance._0x176fb661(_0x56576ecc._0x2cde3fea.LOSE);
        }
    }

    private void _0x59feecea()
    {
        this.TimerText.ForEach(_0x1fdccacf => _0x1fdccacf.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xf2b34f8c._0x21600b4e(new byte[6] { 125, 125, 76, 42, 99, 99 }, 16)));
    }

    private int _0x6d07ad5c => this.ScoreCurrent;

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x76b35606;
        this.CurrentGameIndex = _0x58a96848.Instance._0x5653853e;
        foreach (Button _0xd3a1b04c in this.HomeButtons)
            _0xd3a1b04c.onClick.AddListener(() =>
            {
                this._0xbd321f5a();
            });
        foreach (Button _0xdd5aefd0 in this.PauseButtons)
            _0xdd5aefd0.onClick.AddListener(() =>
            {
                _0x58a96848.Instance._0x1784a8c9(false);
                _0x0067139d.Instance._0x176fb661(_0x56576ecc._0x2cde3fea.PAUSE);
            });
        this._0x343738b4();
        this.LevelNumberText.ForEach(_0x1fdccacf => _0x1fdccacf.text = $"LVL {_0x58a96848._0xba396e18._0xa40600fd + 1}");
        if (_0x77ebfb7d.Instance.IsTimerEnabled)
        {
            this._0x59feecea();
            this.StartCoroutine(this._0x8c498bec());
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    public int CustomTimeInitial = 30;
    private void _0xd968d467()
    {
        if (this.ScoreCurrent >= this._0xb70040f3)
            this._0xe9136a6a();
        else
            this._0x1b623dd8();
    }

    private IEnumerator _0x8c498bec()
    {
        this._0x59feecea();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x58a96848.Instance._0x5653853e == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x58a96848.Instance._0x42ac3830)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x59feecea();
            }
        }

        if (!this.IsGameEnd)
            this._0x1b623dd8();
    }

    public List<TMP_Text> TimerText = new();
    private static _0xab658c25 _0x503381e0;
    public void _0x60d3702e(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x343738b4();
            this._0xa3deabcf();
        }
    }

    [HideInInspector]
    public int TimeLeft;
    [HideInInspector]
    public int ScoreCurrent;
    public List<TMP_Text> LevelNumberText = new();
    public void _0xbd321f5a()
    {
        _0x58a96848.Instance._0x1784a8c9(true);
        _0x58a96848.Instance._0x1d00d384(_0x56576ecc._0x3578949a.SCENE_0);
    }

    public List<Button> HomeButtons = new();
    private void _0xa3deabcf()
    {
        if (this.ScoreCurrent > _0x58a96848._0xba396e18._0x25ab9538)
            _0x58a96848._0xba396e18._0x25ab9538 = this.ScoreCurrent;
        if (_0x77ebfb7d.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xb70040f3)
                this._0xe9136a6a();
    }

    private int _0x76b35606 => this.CustomTimeInitial + _0x58a96848._0xba396e18._0xa40600fd * 10;

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0xe9136a6a()
    {
        if (!this.IsGameEnd)
        {
            this._0xb9e274df();
            _0x58a96848.IsAfterLevelComplete = true;
            _0x58a96848.IsAfterLevelFailed = false;
            _0x941938ef _0x937514f0 = _0x0067139d.Instance._0x88bf3b82(_0x56576ecc._0x2cde3fea.WIN).GetComponent<_0x941938ef>();
            if (_0x77ebfb7d.Instance.IsCheckScoreEnabled)
                _0x937514f0.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb70040f3}";
            else
                _0x937514f0.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x77ebfb7d.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x56576ecc._0xad3b7799._0xcf449560)
                    _0x56576ecc._0xad3b7799._0xcf449560 = this.ScoreCurrent;
                _0x937514f0.ContentAdditionalText.text = $"{_0x56576ecc._0xad3b7799._0xcf449560}";
            }
            else
            {
                _0x937514f0.ContentAdditionalText.text = $"{this._0x6d07ad5c}";
                _0x56576ecc._0xad3b7799._0xcf449560 += this._0x6d07ad5c;
            }

            if (_0x77ebfb7d.Instance.IsLevelIncrementOnWin)
                ++_0x58a96848._0xba396e18._0xa40600fd;
            _0x0067139d.Instance._0x176fb661(_0x56576ecc._0x2cde3fea.WIN);
        }
    }

    public List<Button> PauseButtons = new();
    public List<TMP_Text> ScoreText = new();
    private void _0x343738b4()
    {
        if (_0x77ebfb7d.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x1fdccacf => _0x1fdccacf.text = $"{this.ScoreCurrent}/{this._0xb70040f3}");
        else
            this.ScoreText.ForEach(_0x1fdccacf => _0x1fdccacf.text = $"{this.ScoreCurrent}");
    }

    private void Awake()
    {
        _0x503381e0 = this.gameObject.GetComponent<_0xab658c25>();
    }

    public int CustomTargetScore = 10;
    private int _0xb70040f3 => this.CustomTargetScore + _0x58a96848._0xba396e18._0xa40600fd * 10;

    private void _0xb9e274df()
    {
        this.IsGameEnd = true;
        _0x58a96848.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> SubtitleText = new();
}

internal static class _0xf2b34f8c
{
    internal static string _0x21600b4e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}