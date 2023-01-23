using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vehicle : MonoBehaviour
{
    public GameObject PlayersCar;
    public GameObject PlayersYacht;
    public GameObject PlayersAircraft;
    public GameObject AreasCar;
    public GameObject AreasYacht;
    public GameObject AreasAircraft;
    public GameObject quitCarButton;
    public GameObject quitYachtButton;
    public GameObject quitAircraftButton; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            PlayersCar.SetActive(true);
            AreasCar.SetActive(false);
            quitCarButton.SetActive(true);

        }

        if (other.CompareTag("Yacht"))
        {
            PlayersYacht.SetActive(true);
            AreasYacht.SetActive(false);
            quitYachtButton.SetActive(true);
        }

        if (other.CompareTag("AirCraft"))
        {
            PlayersAircraft.SetActive(true);
            AreasAircraft.SetActive(false);
            quitAircraftButton.SetActive(true);
        }
    }

    public void QuitCar()
    {
        PlayersCar.SetActive(false);
        AreasCar.SetActive(true);
        this.transform.position = new Vector3(this.transform.position.x - 3, this.transform.position.y, this.transform.position.z);
        quitCarButton.SetActive(false);

    }

    public void QuitYacht()
    {
        PlayersYacht.SetActive(false);
        AreasYacht.SetActive(true);
        this.transform.position = new Vector3(100, this.transform.position.y,-1);
        quitYachtButton.SetActive(false);
    }

    public void QuitAircraft()
    {
        PlayersAircraft.SetActive(false);
        AreasAircraft.SetActive(true);
        this.transform.position = new Vector3(100, this.transform.position.y, -1);
        quitAircraftButton.SetActive(false);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
