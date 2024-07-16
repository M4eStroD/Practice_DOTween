using DG.Tweening;
using UnityEngine;

public class Paint : Data
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color; 

    protected override void Update()
    {
        _material.DOColor(_color, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
