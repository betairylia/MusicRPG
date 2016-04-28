using UnityEngine;
using System.Collections;

public class QuadHighlighter : IBeatReciever
{
    public float m_beatProcess;
    public AnimationCurve colorCurve;
    public Color darkColor, lightColor;
    public Material mat;

    // Use this for initialization
	void Start ()
    {
        //mat = GetComponent<Material>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        mat.SetColor("quadColor", Color.Lerp(darkColor, lightColor, colorCurve.Evaluate(m_beatProcess)));
	}

    public override void updateBeat(int beatCount, float beatProcess)
    {
        base.updateBeat(beatCount, beatProcess);

        m_beatProcess = beatProcess;
    }
}
