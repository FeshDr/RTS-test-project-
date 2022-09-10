using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateUnit : MonoBehaviour
{
    public Button WarriorButton;
    public PlayerUnit PWarriorPrefab;
    public Transform WarriorSpace;

    private PlayerUnit newPU;
    // Start is called before the first frame update
    private void OnEnable()
    {
        WarriorButton.onClick.AddListener(() => CreatePlayerWarrior());
    }

    void OnDisable()
    {

        WarriorButton.onClick.RemoveAllListeners();
    }

    public void CreatePlayerWarrior()
    {

        newPU = Instantiate(PWarriorPrefab, new Vector3(1f, 1f, 15f), Quaternion.identity);
        newPU.transform.parent = WarriorSpace;
        Debug.Log("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
    }

    IEnumerator CreateWithTime()
    {
        yield return new WaitForSeconds(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
