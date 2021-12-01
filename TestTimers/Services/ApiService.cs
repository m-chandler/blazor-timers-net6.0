using System.Net.WebSockets;

namespace TestTimers.Services
{
    public class ApiService
    {
        public ApiService()
        {
            var websocket = new ClientWebSocket();
            Task.Run(async () =>
            {
                await websocket.ConnectAsync(
                    new Uri("wss://websocket-echo.glitch.me"),
                    CancellationToken.None);
                Console.WriteLine("Connected.");
            });

        }
    }
}
