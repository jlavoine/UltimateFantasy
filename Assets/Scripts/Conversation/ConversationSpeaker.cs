using System;

namespace RPG.Conversations {
    public interface IConversationSpeaker {
        Guid GetId();
        string GetName();
    }

    public class ConversationSpeaker {
        public Guid Id;
        public string Name;

        public Guid GetId() { return Id; }
        public string GetName() { return Name; }
    }
}