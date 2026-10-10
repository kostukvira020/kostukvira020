using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x941938ef : MonoBehaviour
{
    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentHeaderText;
    public float scaleDuration = 0.4f;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private bool _0xbbf67a46 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public bool IsOnlyYScale;
    public static void HideAllPops()
    {
        _0x0067139d.Instance._0x66e2dc88();
    }

    public Image ContentImage;
    public Ease ease = Ease.OutSine;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public TMP_Text ContentMainText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x99445f9f();
    }

    public bool IsScaledDownOnAwake = true;
    public void _0xba07df0c()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private void _0x99445f9f()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public GameObject Content;
}