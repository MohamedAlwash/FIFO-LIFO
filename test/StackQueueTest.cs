using System;
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
        queue.Add(28);
        queue.Add(5);
        // show first number from Queue
        Assert.Equal(3, queue.Search(true));
    }

    [Fact]
    // [ExpectedException]
    public void SearchQueueLastNumberTest()
    {
        var queue = new StackQueue<int>(false);

        queue.Add(3);
        queue.Add(22);
        queue.Add(28);
        queue.Add(17);
        // show last number from Queue
        Assert.Equal(17, queue.Search(false));
    }

    [Fact]
    public void SearchExceptionQueueTest()
    {
        var queue = new StackQueue<int>(false);

        var ex = Assert.Throws<Exception>(() => queue.Search());

        Assert.Equal("You need to add first", ex.Message);
    }

    [Fact]
    public void RemoveExceptionQueueTest()
    {
        var queue = new StackQueue<int>(false);

        var ex = Assert.Throws<Exception>(() => queue.Remove());

        Assert.Equal("You need to add first", ex.Message);
    }

    [Fact]
    public void RemoveQueueFirstNumberTest()
    {
        var queue = new StackQueue<int>(false);

        queue.Add(50);
        queue.Add(22);
        queue.Add(28);
        queue.Add(90);

        queue.Remove();
        // show first number from Queue after remove
        Assert.Equal(22, queue.Search(true));
    }

    [Fact]
    public void RemoveQueueFirstNumberTest2()
    {
        var queue = new StackQueue<int>(false);

        queue.Add(50);
        queue.Add(22);
        queue.Add(28);
        queue.Add(90);

        queue.Remove();
        queue.Remove();
        // show first number from Queue after remove
        Assert.Equal(28, queue.Search(true));
    }

    [Fact]
    public void RemoveQueueLastNumberTest()
    {
        var queue = new StackQueue<int>(false);

        queue.Add(13);
        queue.Add(100);
        queue.Add(28);
        queue.Add(59);

        queue.Remove();
        // show last number from Queue after remove
        Assert.Equal(59, queue.Search(false));
    }

    [Fact]
    public void SearchStackTest()
    {
        var stack = new StackQueue<int>(true);

        stack.Add(465);
        stack.Add(112);
        stack.Add(28);
        stack.Add(845);

        Assert.Equal(845, stack.Search(false));
    }

    [Fact]
    public void SearchTrueStackTest()
    {
        var stack = new StackQueue<int>(true);

        stack.Add(39);
        stack.Add(20);
        stack.Add(28);
        stack.Add(45);

        //Search set on true should give the same result as false
        Assert.Equal(45, stack.Search(true));
    }

    [Fact]
    public void RemoveSearchStackTest()
    {
        var stack = new StackQueue<int>(true);

        stack.Add(465);
        stack.Add(112);
        stack.Add(233);
        stack.Add(845);

        stack.Remove();
        Assert.Equal(233, stack.Search(false));
    }

    [Fact]
    public void SearchExeptionStackTest()
    {
        var stack = new StackQueue<int>(true);

        var ex = Assert.Throws<Exception>(() => stack.Search());

        Assert.Equal("You need to add first", ex.Message);
    }

    [Fact]
    public void SearchQueueFirstStringTest()
    {
        var queue = new StackQueue<string>(false);

        queue.Add("mohamed");
        queue.Add("kees");
        queue.Add("jan");
        queue.Add("hendrik");
        // show first string from Queue
        Assert.Equal("mohamed", queue.Search(true));
    }

    [Fact]
    public void SearchStackFirstStringTest()
    {
        var queue = new StackQueue<string>(false);

        queue.Add("mohamed");
        queue.Add("kees");
        queue.Add("jan");
        queue.Add("hendrik");

        Assert.Equal("hendrik", queue.Search(false));
    }
}