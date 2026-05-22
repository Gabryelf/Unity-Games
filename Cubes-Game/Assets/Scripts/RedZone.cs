using System.Collections;
using System.Collections.Generic;
using UnityEngine ;

public class RedZone : MonoBehaviour {
    public GameObject losePanel;

    [SerializeField] private GameObject imPanelInfoZone;
    public bool isFirstEnter;

    private void Start()
    {
        isFirstEnter = PlayerPrefs.GetInt("isFirstEnter") == 1 ? true : false;
        if (!isFirstEnter)
        {
            StartCoroutine(TimeRotate());
            
        }
    }

    private void OnTriggerStay (Collider other) {
      Cube cube = other.GetComponent <Cube> () ;
      if (cube != null) {
         if (!cube.IsMainCube && cube.CubeRigidbody.linearVelocity.magnitude < .1f) {
                //Debug.Log ("Gameover") ;
                losePanel.SetActive(true);
         }
      }
   }

    private IEnumerator TimeRotate()
    {
        imPanelInfoZone.SetActive(true);
        yield return new WaitForSeconds(5);
        imPanelInfoZone.SetActive(false);
        isFirstEnter = true;
        PlayerPrefs.SetInt("isFirstEnter", isFirstEnter ? 1 : 0);


    }
}
