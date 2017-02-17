using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager: MonoBehaviour {

	public void ComecarBtn(string ComecarJogo)
    {
        SceneManager.LoadScene(ComecarJogo);
    }

    public void SairBtn()
    {
        Application.Quit();
    }
}
