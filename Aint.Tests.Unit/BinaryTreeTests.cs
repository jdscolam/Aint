namespace Aint.Tests.Unit
{
    public class BinaryTreeTests
    {
    }
}

//http://collabedit.com/958yt

//Please join a binary tree level wise

//Node: 
//Node left
//Node right
//int data
//Node next -> null

//1 
//2       3
//4  null  6 7

//1 -> null
//2   ->                3 -> null
//4 ->               6 ->        7-> null


////8 -> 9 ->        12 -> 13 -> 14 -> 15 - > null

//main(...)
//{
////Init tree here.

//joinLevel(root);

//}

////O(n) where n is the number of nodes on the tree.
//public void joinLevel(Node root)
//{
//if (root == null)
//return;

//var levelQueue = new Queue<Node>();

//levelQueue.Enqueue(root);
//levelQueue.Enqueue(null);

//Node currentNode, nextNode;
//while (level.Queue.Count > 0)
//{
////Handle Current.
//currentNode = levelQueue.Dequeue();

//if (currentNode == null)
//{
//    nextNode = null;    //Reset the next node, so it isn't hanging around incorrectly.
//    levelQueue.Enqueue(null);
//    continue;
//}
//else if (nextNode != null)
//{
//    nextNode.next = currentNode;
//}

//queueLeftAndRight(currentNode, levelQueue);

////Handle Next.
//nextNode = levelQueue.Dequeue();

//if (nextNode == null)
//{
//    currentNode = null;    //Reset the current node.
//    levelQueue.Enqueue(null);
//    continue;
//}

//queueLeftAndRight(nextNode, levelQueue);

//currentNode.next = nextNode;
//}
//}

//public void queueLeftAndRight(Node current, Queue<Node> levelQueue)
//{
//if (current.left != null)
//levelQueue.Enqueue(current.left);

//if (current.right != null)
//levelQueue.Enqueue(current.right);
//}


//Please join a binary tree level wise

//Node: 
//    Node left
//    Node right
//    int data
//    Node next -> null

//      1 
//  2       3
//4  null  6 7

//                    1 -> null
//         2   ->                3 -> null
//  4 ->               6 ->        7-> null


////8 -> 9 ->        12 -> 13 -> 14 -> 15 - > null

//main(...)
//{
//    //Init tree here.

//    joinLevel(root);

//}

////O(n) where n is the number of nodes on the tree.
//public void joinLevel(Node root)
//{
//    if (root == null)
//        return;

//    var levelQueue = new Queue<Node>();

//    levelQueue.Enqueue(root);
//    levelQueue.Enqueue(null);

//    Node currentNode;
//    while (level.Queue.Count > 0)
//    {
//        //Handle Current.
//        currentNode = levelQueue.Dequeue();

//        if (currentNode == null)
//        {
//            levelQueue.Enqueue(null);
//            continue;
//        }

//        queueLeftAndRight(currentNode, levelQueue);

//        currentNode.next = levelQueue.Peek();
//    }
//}

//public void queueLeftAndRight(Node current, Queue<Node> levelQueue)
//{
//    if (current.left != null)
//        levelQueue.Enqueue(current.left);

//    if (current.right != null)
//        levelQueue.Enqueue(current.right);
//}