namespace Polymorphism
{
    //in this class we are talking about abstractions, in the INotificationChannel, whoever implements that, we dont care
    //becouse our code is not going to be affected, we can create new implementations of that interface and this class remains unchanged
    //so our software is open to extensions (we create new implementations of INotificationChannel) and is closed to modifications
    //so this class is no longer to be changed
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        //in the loop channel, at runtime when we call the send method depending on the runtime type of that notification
        //channel a different method is called and that is called polymorphism
        public void Encode(Video video)
        {
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        //we dont want to expose to the outside, dont want to tell the implementations details 
        //we need to tell video encoder about the actual notification channels at runtime
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}