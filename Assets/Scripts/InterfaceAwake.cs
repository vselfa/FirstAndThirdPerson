using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class InterfaceAwake : MonoBehaviour {
   public void GoFirstPerson ()    {
        SceneManager.LoadScene ("FirstPerson");
    }

    public void GoThirdPerson ()    {
        SceneManager.LoadScene ("ThirdPerson");
    }
}

