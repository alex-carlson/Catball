using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SimpleBlit : MonoBehaviour
{
    public Material TransitionMaterial;

	void Start(){
		StartCoroutine (newScene (1, 1, 1));
	}

    void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        if (TransitionMaterial != null)
            Graphics.Blit(src, dst, TransitionMaterial);
    }

	public IEnumerator newScene(float alphaStart, float alphaFinish, float time){
		float elapsedTime = 0;

		Camera.main.GetComponent<SimpleBlit> ().TransitionMaterial.SetFloat ("_Cutoff", alphaStart);

		while (elapsedTime < time) {
			Camera.main.GetComponent<SimpleBlit> ().TransitionMaterial.SetFloat ("_Cutoff", 1f - elapsedTime);
			elapsedTime += Time.deltaTime/2;
			yield return new WaitForEndOfFrame();
		}
	}
}
