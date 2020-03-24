using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UdemyClassesIntermediate;

namespace UdemyClassesIntermediate_Tests
{
    [TestFixture]
    class StackTests
    {
        private Stack _stack;
        [SetUp]
        public void SetUp()
        {
            _stack = new Stack();
        }

        [Test]
        public void Push_WhenNullPassed_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Push(null));
        }

        [TestCase(2)]
        [TestCase("Test")]
        [TestCase('a')]
        public void Push_WhenObjectIsPassed_ObjectIsOnTopOfStack(Object a)
        {
            _stack.Push(a);
            Assert.That(_stack.stackList[_stack.stackList.Count - 1], Is.EqualTo(a));
        }
        [Test]
        public void Pop_WhenStackIsEmptyAndPopIsCalled_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Pop());
        }
        [TestCase("Test",3)]
        public void Pop_WhenPopIsCalled_ReturnsFirstObjectFromStackAndRemovesIt(Object firstObject, Object secondObject)
        {
            _stack.Push(firstObject);
            _stack.Push(secondObject);
            var stackQuantity = _stack.stackList.Count;
            Assert.That(secondObject, Is.EqualTo(_stack.Pop()));
            Assert.That(_stack.stackList.Count, Is.EqualTo(stackQuantity - 1));

        }
        [Test]
        public void Clear_WhenClearIsCalled_EmptyStackList()
        {
            _stack.Push(765);
            _stack.Clear();
            Assert.That(_stack.stackList.Count,Is.EqualTo(0));
        }

    }
}
