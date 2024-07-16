using DG.Tweening;

public class Scale : Data
{
    protected override void Update()
    {
        transform.DOScale(Transform, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
