using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.GameScripts
{
    public class İngameİnteractions: MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                StartCoroutine(OyunYavaslatma());
            }
           
            
        }

        IEnumerator OyunYavaslatma()
        {
            Time.timeScale = 0.2f;
            yield return new WaitForSeconds(0.2f);
            Time.timeScale = 1;
        }
    }
}
