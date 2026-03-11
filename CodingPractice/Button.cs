
class Button
{
    public event EventHandler2 Click;

    public void OnClick()
    {
        if (Click != null)
        {
            Click();
        }
    }
}