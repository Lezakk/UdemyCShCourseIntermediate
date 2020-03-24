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
            Assert.That(_stack[_stack.Stack.Count - 1], Is.EqualTo(a));
        }
        [Test]
        public void Pull_WhenStackIsEmptyAndPullIsCalled_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Pull());
        }
        [Test]
        public void Clear_WhenClearIsCalled_EmptyStackList()
        {
            _stack.Clear();
            Assert.That(_stack.Stack.Count,Is.EqualTo(0));
        }

    }
}
