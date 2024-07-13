using Unity.VisualScripting;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    private Transform pointPrefab;

    [SerializeField, Range(10, 1000)]
    int resolution = 100;

    Transform point;
    private void Awake()
    {
        float step = 2f / resolution;
        Vector3 scale = Vector3.one * step;

        for(int i = 0; i < resolution; i++) { 
            float x = -1 + (i + 0.5f) * step;
            float y = Mathf.Sin(x * x/0.5f)/x ;

            point = Instantiate(pointPrefab);
            point.parent = gameObject.transform;
            point.localPosition = new Vector3 (x, y, 0);
            point.localScale = scale;
        }
    }
}
