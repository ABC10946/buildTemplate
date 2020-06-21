using UnityEngine;
public abstract class Command : MonoBehaviour
{
    public virtual void Execute(){

    }
    public virtual void Execute(Vector3 pos){

    }

    public virtual void setNode(GameObject node) {

    }

    public virtual void Undo() {

    }
}
