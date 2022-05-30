using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equipoComportamiento : MonoBehaviour
{
   
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Mesakinematic;
    public GameObject MesaGravedad;
    bool mesakine=false;
    bool mesagrave=false;
    bool Prefab1Inst=false;
    bool Prefab2Inst=false;
    bool Prefab3Inst=false;



    public void InstanciarEquipo()
    {
        if ((Prefab1Inst == false) && (Prefab2Inst == false) && (Prefab3Inst == false))
        {
            if ((mesakine==false) && (mesagrave==false))
                {
                    Vector3 posicion = new Vector3(Mesakinematic.transform.position.x, Mesakinematic.transform.position.y + 0.1f, Mesakinematic.transform.position.z);
                    Instantiate(Prefab1,posicion,Quaternion.identity);
                    mesakine = true;
                }
            if ((mesakine==true) && (mesagrave==false))
                {
                    Vector3 posicion = new Vector3(MesaGravedad.transform.position.x, MesaGravedad.transform.position.y + 0.1f, MesaGravedad.transform.position.z);
                    Instantiate(Prefab1,posicion,Quaternion.identity);
                    mesagrave = false;
                    mesakine = false;
                }
            Prefab1Inst = true;
        }
        

        if ((Prefab1Inst == true) && (Prefab2Inst == false) && (Prefab3Inst == false))
        {
              if ((mesakine==false) && (mesagrave==false))
                {
                    Vector3 posicion = new Vector3(Mesakinematic.transform.position.x, Mesakinematic.transform.position.y + 0.1f, Mesakinematic.transform.position.z);
                    Instantiate(Prefab2,posicion,Quaternion.identity);
                    mesakine = true;
                }
            if ((mesakine==true) && (mesagrave==false))
                {
                    Vector3 posicion = new Vector3(MesaGravedad.transform.position.x, MesaGravedad.transform.position.y + 0.1f, MesaGravedad.transform.position.z);
                    Instantiate(Prefab2,posicion,Quaternion.identity);
                    mesagrave = false;
                    mesakine = false;
                }
            Prefab2Inst = true;
        }

        if ((Prefab1Inst == true) && (Prefab2Inst == true) && (Prefab3Inst == false))
        {

            if ((mesakine==false) && (mesagrave==false))
                {
                    Vector3 posicion = new Vector3(Mesakinematic.transform.position.x, Mesakinematic.transform.position.y + 0.1f, Mesakinematic.transform.position.z);
                    Instantiate(Prefab3,posicion,Quaternion.identity);
                    mesakine = true;
                }
            if ((mesakine==true) && (mesagrave==false))
                {
                    Vector3 posicion = new Vector3(MesaGravedad.transform.position.x, MesaGravedad.transform.position.y + 0.1f, MesaGravedad.transform.position.z);
                    Instantiate(Prefab3,posicion,Quaternion.identity);
                    mesagrave = false;
                    mesakine = false;
                }

            Prefab1Inst = false;
            Prefab1Inst = false;
            Prefab1Inst = false;
        } 

    }


}
