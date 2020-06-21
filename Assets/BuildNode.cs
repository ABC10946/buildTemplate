using UnityEngine;

public class BuildNode : Command
{
    private int uniqueId = 0;
    private GameObject Node;
    public override void setNode(GameObject node) {
        this.Node = node;
    }
    public override void Execute(Vector3 pos)
    {
        GameObject node = Instantiate(Node, pos, Quaternion.identity) as GameObject;
        node.name = "node" + uniqueId.ToString();
        uniqueId++;
    }

    public override void Undo() {
        if(uniqueId > 0) {
            uniqueId--;
        }
        string nodeName = "node" + uniqueId.ToString();
        Debug.Log(uniqueId);
        Destroy(GameObject.Find(nodeName));

    }
}