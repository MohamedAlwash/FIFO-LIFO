using System.Collections.Generic;
using Xunit;

namespace test;

public class StackQueueTest
{
    [Fact]
    public void SearchQueueFirstNumberTest()
    {
        var queue = new StackQueue<int>(false);

        queue.Add(3);
        queue.Add(10);
        queue.Add(5);
        // show first number from Queue
        Assert.Equal(3, queue.Search(true));
    }

    [Fact]
    public void SearchQueueLastNumberTest()
    {
        var queue = new StackQueue<int>(false);

        queue.Add(3);
        queue.Add(10);
        queue.Add(5);
        // show last number from Queue
        Assert.Equal(5, queue.Search(false));
    }

    [Fact]
    public void RemoveQueueFirstNumberTest()
    {
        var queue = new StackQueue<int>(false);

        queue.Add(3);
        queue.Add(10);
        queue.Add(5);

        queue.Remove();
        // show first number from Queue
        Assert.Equal(10, queue.Search(true));
    }

    [Fact]
    public void RemoveQueueLastNumberTest()
    {
        var queue = new StackQueue<int>(false);

        queue.Add(3);
        queue.Add(10);
        queue.Add(5);

        queue.Remove();
        // show last number from Queue
        Assert.Equal(5, queue.Search(false));
    }

    [Fact]
    public void SearchStackTest()
    {
        var stack = new StackQueue<int>(true);

        stack.Add(3);
        stack.Add(10);
        stack.Add(5);

        Assert.Equal(5, stack.Search(true));
    }

    [Fact]
    public void RemoveStackTest()
    {
        var stack = new StackQueue<int>(true);

        stack.Add(3);
        stack.Add(10);
        stack.Add(5);

        stack.Remove();
        Assert.Equal(10, stack.Search(true));
    }
}