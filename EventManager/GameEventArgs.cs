using System;

class GameEventArgs : EventArgs
{
    public string EventName { get; set; }
    public object Data { get; set; }

    public GameEventArgs(string eventName, object data)
    {
        EventName = eventName;
        Data = data; 
    }
}