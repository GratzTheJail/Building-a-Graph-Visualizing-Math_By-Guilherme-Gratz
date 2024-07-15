using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    private Transform pointPrefab;

    [SerializeField, Range(10, 1000)]
    int resolution = 100;

    Transform[] points;
    private void Awake()
    {
        float step = 2f / resolution;
        Vector3 scale = Vector3.one * step;
        points = new Transform[resolution];

        for(int i = 0; i < points.Length; i++) { 
            float x = -1 + (i + 0.5f) * step;

            points[i] = Instantiate(pointPrefab);
            points[i].parent = gameObject.transform;
            points[i].localPosition = new Vector3 (x, 0, 0);
            points[i].localScale = scale;
        }
    }

    private void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            float x     = points[i].position.x;
            float x0    = x + Time.time;
            float y     = Mathf.Sin(x0 * x0 / 0.5f) / x0;

            //change the current point's y value to the y set above
            points[i].localPosition = points[i].localPosition + new Vector3(0, -points[i].localPosition.y + y, 0);
        }

    }
}
