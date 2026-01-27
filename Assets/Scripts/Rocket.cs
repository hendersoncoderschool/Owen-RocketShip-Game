using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Rocket : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public float turnSpeed;
    public ParticleSystem particles;
    public int stars;
    public TextMeshProUGUI starsUI;
    public float elapsedTime;
    public TextMeshProUGUI timeUI;
    public bool canShoot;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
        stars = 0;
        elapsedTime = 0f;
    }
    
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            GameObject bullet = Instantiate(projectilePrefab, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.up * 20f;
        }
        if (Input.GetKey("w")) {
            rb.AddForce(transform.up * speed * Time.deltaTime, ForceMode.Force);
            if(!particles.isPlaying) particles.Play();

        }
        else
        {
            particles.Stop();
        }
        float turn = Input.GetAxis("Horizontal");
        //rb.AddTorque(transform.forward * turnSpeed * -turn * Time.deltaTime, ForceMode.Force);
        transform.Rotate(transform.forward, turnSpeed * -turn * Time.deltaTime);
        elapsedTime += Time.deltaTime;
        timeUI.text = ((int)elapsedTime).ToString();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            stars++;
            Destroy(collision.gameObject);
            starsUI.text = "Stars: " + stars.ToString();

        }
        
    }

   public IEnumerator BoostSpeed()
    {
        speed = 9000f;
        print("speed inc");
        yield return new WaitForSeconds(5f);
        speed = 1000f;
    }
    
}
