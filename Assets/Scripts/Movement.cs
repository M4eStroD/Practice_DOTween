using DG.Tweening;

public class Movement : Data
{
    protected override void Update()
    {
        transform.DOMove(Transform, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
