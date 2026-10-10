using TMPro;
using UnityEngine;
using static _0x56576ecc;

public class _0x6b4e97c9 : MonoBehaviour
{
    public void _0xecce7a85()
    {
        this.MoneyCountText.text = _0xad3b7799._0xcf449560.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xebc2dd15;
            if (this.gameObject.TryGetComponent(out _0xebc2dd15))
                this.MoneyCountText = _0xebc2dd15;
        }

        this._0xecce7a85();
    }

    public TMP_Text MoneyCountText;
}