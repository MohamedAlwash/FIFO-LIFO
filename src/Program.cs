var queue = new StackQueue<int>(false);
// queue.Add(85);
// queue.Add(90);
// queue.Add(73);
// queue.Add(20);


// // queue.Remove();
queue.Remove();
// queue.Add(26);
// Console.WriteLine(queue.Search(true));
// Console.WriteLine(queue.Search(false));

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

        try
        {
            if (showFirstNumber && !_Datastructure)
            {
                // only possible to do that in Queue, show first number after add
                return Array[0];
            }
            return Array[Array.Count - 1];
        }
        catch (Exception e)
        {
            throw new Exception("You need to add first");
        }
    }

    public void Add(T random)
    {
        Array.Add(random);
    }

    public void Remove()
    {
        try
        {
            if (!_Datastructure)
            {
                // remove the first number that is add to the Queue
                Array.RemoveAt(0);
            }
            else
            {
                Array.RemoveAt(Array.Count - 1);
            }
        }
        catch (Exception e)
        {
            throw new Exception("You need to add first");
        }
    }
}
