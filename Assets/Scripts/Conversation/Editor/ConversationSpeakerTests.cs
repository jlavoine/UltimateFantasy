using NUnit.Framework;
using System;

namespace RPG.Conversations {

    [TestFixture]
    public class ConversationSpeakerTests {
     
        [Test]
        public void GetId_MatchesIdProperty() {
            Guid testId = Guid.NewGuid();
            ConversationSpeaker systemUnderTest = new ConversationSpeaker();
            systemUnderTest.Id = testId;

            Assert.AreEqual( testId, systemUnderTest.GetId() );
        }

        [Test]
        public void GetName_MatchesNameProperty() {
            string testName = "Joe";
            ConversationSpeaker systemUnderTest = new ConversationSpeaker();
            systemUnderTest.Name = testName;

            Assert.AreEqual( testName, systemUnderTest.GetName() );
        }
    }
}
