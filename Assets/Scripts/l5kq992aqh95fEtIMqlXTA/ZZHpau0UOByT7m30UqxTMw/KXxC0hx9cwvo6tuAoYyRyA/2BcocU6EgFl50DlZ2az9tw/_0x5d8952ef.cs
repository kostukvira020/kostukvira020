using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x5d8952ef : MonoBehaviour
{
    public void _0x026c9cea()
    {
        this._0x3d30debb();
        bool _0x5ad19aa6 = _0x8758d89b;
        this._0x8ff26402 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x322142b4 => this.AnimationSlider.value = _0x322142b4, _0x5ad19aa6 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x8758d89b = !_0x8758d89b;
    }

    public Slider AnimationSlider;
    public void _0x991b3d12()
    {
        this._0x8ff26402?.Play();
    }

    public static _0x5d8952ef Instance;
    public float FirstAnimationTime = 10.0f;
    public void _0xa7d5d502()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x8ff26402?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x8758d89b = false;
    }

    public GameObject Background;
    public GameObject Content;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5d8952ef>();
    }

    public float DefaultAnimationTime = 0.4f;
    private void _0xe7754407()
    {
        this.AnimationSlider.value = 0.05f;
        _0x8758d89b = !_0x8758d89b;
        this._0x8ff26402 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x322142b4 => this.AnimationSlider.value = _0x322142b4, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xbd87a78f._0xba8b03bb?._0xd88aa1c9();
        });
    }

    private static bool _0x8758d89b = false;
    public float SecondPassSliderValue = 0.5f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x56576ecc._0x3578949a.SCENE_0 && !_0x8758d89b)
        {
            this._0xe7754407();
        }
        else
        {
            this._0x026c9cea();
        }
    }

    private Sequence _0x8ff26402;
    public GameObject Error;
    public void _0x701812b3()
    {
        this._0x8ff26402?.Pause();
    }

    public void _0x3d30debb()
    {
        this._0x8ff26402?.Kill();
        this.AnimationSlider.value = _0x8758d89b ? this.SecondPassSliderValue : 0.05f;
    }
}