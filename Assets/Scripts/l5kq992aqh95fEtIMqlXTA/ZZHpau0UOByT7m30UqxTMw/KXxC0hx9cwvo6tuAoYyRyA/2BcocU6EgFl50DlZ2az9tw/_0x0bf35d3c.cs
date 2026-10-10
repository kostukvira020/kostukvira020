using UnityEngine;
using UnityEngine.UI;

public class _0x0bf35d3c : MonoBehaviour
{
    public bool IsTutorialEndPanel;
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x5bd4077c.Instance._0x1c0e34af(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x58a96848.Instance._0xc5d3983e());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x5bd4077c.Instance._0x1c0e34af(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x5bd4077c.Instance._0x1c0e34af(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x58a96848.Instance._0xc5d3983e());
        }
    }

    public Button TutorialEndButton;
}