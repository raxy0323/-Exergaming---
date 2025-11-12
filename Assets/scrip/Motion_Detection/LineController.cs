using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private LineRenderer _lineRenderer2;
    private LineRenderer _lineRenderer3;
    private LineRenderer _lineRenderer4;

    [SerializeField] private Transform[] _joinTransforms;

    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer2 = GetComponent<LineRenderer>();
        _lineRenderer3 = GetComponent<LineRenderer>();
        _lineRenderer4 = GetComponent<LineRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        _lineRenderer.positionCount = _joinTransforms.Length;
        for (int i = 0; i < _joinTransforms.Length ; i++)
        {
            _lineRenderer.SetPosition(i, _joinTransforms[i].position);
        }

    }
}
