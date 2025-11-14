using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enque two items with different priorities and dequeue them
    // Expected Result: First dequeued item is the one with the higher priority
    // Defect(s) Found: Skipped index in Dequeue method's for loop
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low priority", 1);
        priorityQueue.Enqueue("High priority", 5);
        var firstOut = priorityQueue.Dequeue();
        Assert.AreEqual("High priority", firstOut);
    }

    [TestMethod]
    // Scenario: Enque two items with the same priority and dequeue them
    // Expected Result: Items are dequeued in the order they were enqueued
    // Defect(s) Found: Used >= instead of > in Dequeue method's priority comparison
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First in", 3);
        priorityQueue.Enqueue("Second in", 3);
        var firstOut = priorityQueue.Dequeue();
        Assert.AreEqual("First in", firstOut);
    }
}