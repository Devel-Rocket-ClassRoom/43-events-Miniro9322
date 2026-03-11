using System;

// README.md를 읽고 아래에 코드를 작성하세요.

ChatRoom room = new ChatRoom();
ChatLogger logger = new ChatLogger();
NotificationService notification = new NotificationService();

room.MessageReceived += logger.OnMessageSended;
room.MessageReceived += notification.OnMessageSended;

room.SendMessage("철수", "안녕하세요");
room.SendMessage("영희", "긴급 회의가 있습니다");
room.SendMessage("민수", "점심 뭐 먹을까요?");