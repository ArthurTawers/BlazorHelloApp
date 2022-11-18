namespace HelloBlazorServerApp.Pages
{
    public class MessangerViewModel
    {
        public List<(string,DateTime)> Messanges = new List<(string,DateTime)>();

        public void AddMessange(string message,DateTime dt)
        {
            Messanges.Add((message,dt));
        }
    }
}
