using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class GoalPoint : MonoBehaviour

{
    public string nextLevel;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //SceneManager.LoadScene(nextLevel);
            panel.SetActive(true);
            panel.transform.Find("Stars").GetComponent<TextMeshProUGUI>().text = collision.gameObject.GetComponent<Rocket>().stars.ToString();
            panel.transform.Find("Time").GetComponent<TextMeshProUGUI>().text = ((int)collision.gameObject.GetComponent<Rocket>().elapsedTime).ToString();
            collision.gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
