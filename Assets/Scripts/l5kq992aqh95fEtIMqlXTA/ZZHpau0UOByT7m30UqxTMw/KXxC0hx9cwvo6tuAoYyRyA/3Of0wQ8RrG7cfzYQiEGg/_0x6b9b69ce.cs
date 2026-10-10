using UnityEngine;
using UnityEngine.UI;

public class _0x6b9b69ce : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public bool IsHideAllPops;
    public int PopToShowIndex;
    public Button Button;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x0067139d.Instance._0x026fe466();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x0067139d.Instance._0x66e2dc88());
        else
            this.Button.onClick.AddListener(() => _0x0067139d.Instance._0x176fb661(this.PopToShowIndex));
    }
}