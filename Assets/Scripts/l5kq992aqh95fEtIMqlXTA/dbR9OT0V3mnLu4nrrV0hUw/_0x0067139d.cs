using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x56576ecc;

public class _0x0067139d : MonoBehaviour
{
    private void _0x48fc6628()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0x026fe466()
    {
        this.LastPopIndexes.RemoveAll(_0xf7d1bb00 => _0xf7d1bb00 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x66e2dc88();
        else
            this._0x176fb661(this.LastPopIndexes.Last());
    }

    public int CurrentPopIndex;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x0067139d>();
    }

    public float ScaleDuration = 0.4f;
    public void _0x66e2dc88()
    {
        this.LastPopIndexes.Clear();
        this._0x7ec2ef0a();
        foreach (GameObject _0xbb1e12fc in this.GameObjectsToHide)
            if (_0xbb1e12fc != null)
                _0xbb1e12fc.SetActive(true);
        this._0xe39291d1();
    }

    public _0x941938ef _0x88bf3b82(int _0x98d3f399)
    {
        return this.Pops[_0x98d3f399];
    }

    public List<_0x941938ef> Pops;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x941938ef _0xa1610c94 in this.Pops)
            if (_0xa1610c94 != null)
                _0xa1610c94.gameObject.SetActive(true);
    }

    private void _0xe39291d1()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public GameObject BlurBackground;
    public static _0x0067139d Instance;
    public List<int> LastPopIndexes = new();
    public List<GameObject> GameObjectsToHide;
    private void _0x7ec2ef0a(bool _0xd600d958 = false)
    {
        for (int _0x0bf5fadd = 0; _0x0bf5fadd < this.Pops.Count; ++_0x0bf5fadd)
            if (this.Pops[_0x0bf5fadd] != null && !(_0x0bf5fadd == this.CurrentPopIndex && _0xd600d958))
                this.Pops[_0x0bf5fadd]._0xba07df0c();
    }

    public void _0x176fb661(int _0xc43c9110)
    {
        this.CurrentPopIndex = _0xc43c9110;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x7ec2ef0a(true);
        this._0x48fc6628();
        this.Pops[_0xc43c9110].Show();
        foreach (GameObject _0xfed2624c in this.GameObjectsToHide)
            _0xfed2624c.SetActive(false);
    }
}