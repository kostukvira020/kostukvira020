using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x29eaf145 : MonoBehaviour
{
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xeb6aeb9f();
    }

    public Ease Ease = Ease.OutSine;
    private void _0xeb6aeb9f()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7ba73f11 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7ba73f11, true);
            _0x7ba73f11.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private bool _0xc327c301 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x876c2b72()
    {
        if (this.OuterBackground != null)
        {
            Image _0x4d846805 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x4d846805, true);
            _0x4d846805.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public TMP_Text HeaderText;
    public GameObject OuterBackground;
    private void _0xe94a4b35()
    {
        if (this.OuterBackground != null)
        {
            Image _0x01862d17 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x01862d17, true);
            _0x01862d17.DOFade(1f, 0f);
        }
    }

    public float ScaleDuration = 0.4f;
    public GameObject Content;
    private void _0x39fae6e0()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc40b2a84 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc40b2a84, true);
            _0xc40b2a84.DOFade(0f, this.ScaleDuration);
        }
    }

    public void _0x326ee02e()
    {
        this._0x39fae6e0();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public void _0xcbad5226()
    {
        this._0xe94a4b35();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x5bd4077c.Instance._0x3da07a0b(_0x5bd4077c.Instance.CurrentPanelIndex);
    }

    public TMP_Text MainText;
    public bool IsScaledDownOnAwake = true;
    public void Show()
    {
        this._0x876c2b72();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x5bd4077c.Instance._0x3da07a0b(_0x5bd4077c.Instance.CurrentPanelIndex);
            });
        }
    }
}