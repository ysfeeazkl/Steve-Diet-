using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using System.Collections;

namespace Assets.Scripts
{
    public class Playerinteraction: MonoBehaviour
    {
        public int oyuncuAgırlıgı = Assets.Scripts.PlayerScripts.PlayerFeatures.Kilo;
        public TextMeshProUGUI KiloSayacıtxt,alınankilotxt;
        public GameObject bitisPaneli, AlınanVerilenkgPaneli;


        public void Start()
        {
            Time.timeScale = 1;

           
        }

        private void Update()
        {
            //Debug.Log(transform.position);

            KiloSayacıtxt.text = "Kilo: " + oyuncuAgırlıgı;
            //KiloSayacı.text = ((int)Time.time).ToString(); //int türünde oyunda geçen süreyi gösteriyo 

            if (oyuncuAgırlıgı >= 100)
            {
                Debug.Log("Oyun Bitti");              
                Time.timeScale = 0;
                bitisPaneli.SetActive(true);              
            }
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            float xPosizyon = UnityEngine.Random.Range(-2.40f, 2.50f); //rastgele kordinat oluşturuyorum
            float yPosizyon = UnityEngine.Random.Range(7, 15);

            Rigidbody2D rigidbody = collider.GetComponent<Rigidbody2D>();

            Debug.Log(collider.name + " çarptı");

            if (collider.gameObject.tag == "ZararlıYiyecek")
            {
                StopAllCoroutines();
                oyuncuAgırlıgı += 10;
                alınankilotxt.text = "+10";
                StartCoroutine(KgPanel());
                collider.transform.position = new Vector2(xPosizyon, yPosizyon); //ekranın üstüne rastgele bir konuma ışınlıyorum
                rigidbody.velocity = new Vector2(0, 0); //hızını sıfırlıyorum ışınlandığında
            }
            else if(collider.gameObject.tag == "SaglıklıYiyecek")
            {
                StopAllCoroutines();
                if (oyuncuAgırlıgı > 50)
                {
                    oyuncuAgırlıgı -= 10;
                    
                    alınankilotxt.text = "-10";
                    StartCoroutine(KgPanel());
                }
               
                collider.transform.position = new Vector2(xPosizyon, yPosizyon); //ekranın üstüne rastgele bir konuma ışınlıyorum
                rigidbody.velocity = new Vector2(0, 0); //hızını sıfırlıyorum ışınlandığında
            }

        }

        IEnumerator KgPanel()  //Coroutine böyle oluşturuluyor
        {
            AlınanVerilenkgPaneli.SetActive(true);       
            yield return new WaitForSeconds(0.2f);        
            AlınanVerilenkgPaneli.SetActive(false);          
        }



    }
}
