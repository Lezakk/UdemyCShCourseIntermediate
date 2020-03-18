using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UdemyClassesIntermediate;

namespace UdemyClassesIntermediate_Tests
{
    [TestFixture]
    class PostTests
    {
        private Post _post;
        [SetUp]
        public void SetUp()
        {
            _post = new Post();
        }
        [Test]
        public void UpVote_WhenUpVoteCalledRisePointsByOne_ReturnsPointsFromPost()
        {
            _post.UpVote();
            var result = _post.VotePoints();
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void DownVote_WhenDownVoteCalledRisePointsByOne_ReturnsPointsFromPost()
        {
            _post.DownVote();
            _post.DownVote();
            var result = _post.VotePoints();
            Assert.That(result, Is.EqualTo(-2));
        }

    }
}
