using System;

// README.md를 읽고 코드를 작성하세요.

ScoreSystem system = new ScoreSystem();
AchievementSystem achievement = new AchievementSystem();
SoundSystem sound = new SoundSystem();

EventManager.OnGameEvent += sound.OnSoundChanged;
EventManager.OnGameEvent += system.OnScoreChanged;
EventManager.OnGameEvent += achievement.OnAchievementChanged;

EventManager.TriggerEvent("ScoreChanged", 100);
EventManager.TriggerEvent("Achievement", "첫 번째 적 처치");
EventManager.TriggerEvent("GameOver");


