using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Store : MonoBehaviour
{
  


        public string targetTag = "Task_1"; 
        private int count = 0;
        public GameObject waiting;
        public GameObject end;
   



    private void Start()
        {
            waiting.SetActive(false);
            end.SetActive(false);
            
    }

        
        // quando um objeto esta em kinematic quer dizer que esta a ser agarrado
        // if (isGrabbed && GetComponent<Rigidbody>().isKinematic)
          

           //  hasWaited = true;
           //  toggle.SetActive(true);


        
        private void OnTriggerEnter(Collider other)
        {
            // se pousou em cima do balcao e se e a roupa certa
            if (GetComponent<Rigidbody>().isKinematic && other.CompareTag(targetTag))
            {
                count++;
            Debug.Log("entrou no collider hihihihi");

            // substituir para o numero de tags suposto, 5 neste caso 
            if (count == 1)
                {
                    end.SetActive(true);
                Debug.Log("chegou ao limite huhugu");
            }
                
            }
        }

    }


