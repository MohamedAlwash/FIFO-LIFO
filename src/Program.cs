var queue = new StackQueue<int>(true);
queue.Add(85);
queue.Add(90);
queue.Add(73);
queue.Add(20);


// queue.show();
// queue.Remove();
queue.Remove();
Console.WriteLine(queue.Search(false));

static void Main(string[] args)
{

}

public class StackQueue<T>
{
    private List<T> Array = new List<T>();

    // Datastructure false means Queue(LIFO) and true means Stack(FIFO)
    private Boolean _Datastructure;

    public StackQueue(Boolean Datastructure)
    {
        _Datastructure = Datastructure;
    }

    public T Search(Boolean showFirstNumber = false)
    {
        // if (showFirstNumber)
        // {
        //     // only possible to do that in Queue
        //     return Array[Array.Count - 1];
        // }
        return Array[0];
    }

    public void Add(T random)
    {
        if (!_Datastructure)
        {
            Array.Add(random);
        }
        else
        {
            Array.Insert(0, random);
        }
    }

    public void Remove()
    {
        // if (!_Datastructure)
        // {
        //     Array.RemoveAt(0);
        // }else {
        
        // }
        Array.RemoveAt(0);
    }
}
