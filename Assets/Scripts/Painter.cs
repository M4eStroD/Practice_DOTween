using DG.Tweening;
using UnityEngine;

public class Painter : Data
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color; 

    protected override void Awake()
    {
        _material.DOColor(_color, Duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
