using UnityEngine;

public class TankEntity : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    int _rotationSpeed = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // var position = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position;
        // position.x += 1;
        // position.z += 1;
        // agent.SetDestination(position);
        //transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 
            if(Physics.Raycast(ray, out hit))
            {
            agent.SetDestination(hit.point);
         } 
      }
    }
}
