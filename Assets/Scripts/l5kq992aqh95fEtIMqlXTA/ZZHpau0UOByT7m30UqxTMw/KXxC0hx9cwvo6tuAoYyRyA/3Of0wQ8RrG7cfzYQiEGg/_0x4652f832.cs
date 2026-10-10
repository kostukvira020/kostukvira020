using UnityEngine;
using UnityEngine.UI;

public class _0x4652f832 : MonoBehaviour
{
    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x58a96848.Instance._0x1784a8c9(this.IsPhysicsRunOnClick));
    }
}