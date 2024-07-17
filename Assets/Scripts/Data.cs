using UnityEngine;

public abstract class Data : MonoBehaviour
{
    [SerializeField] protected Vector3 Transform;
    [SerializeField] protected float Duration;

    protected abstract void Awake();
}
