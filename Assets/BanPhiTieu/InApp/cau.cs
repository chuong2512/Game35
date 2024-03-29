using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using RObo;
using Sirenix.OdinInspector;
using UnityEngine;

public class cau : Singleton<cau>
{
    public LineRenderer lineRenderer;

    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
    }

    public void Reset()
    {
        Transform transform1;
        (transform1 = transform).DOKill();
        transform1.position = pos;
        transform1.rotation = Quaternion.identity;
        SetLine(0, false);
    }

    [Button]
    public void SetLine(float y, bool rotate = false)
    {
        transform.position = pos;

        lineRenderer.SetPositions(new[] {Vector3.zero, Vector3.up * y});

        if (rotate)
        {
            Rotate(y);
        }
    }

    private void Rotate(float y)
    {
        transform.DORotate(Vector3.back * 90, 1f).SetEase(Ease.Linear)
            .OnComplete(() => { GoDiChuyen.Instance.Move(y); });
    }
}