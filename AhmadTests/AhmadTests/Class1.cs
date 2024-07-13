namespace Descorator
{
    //Descorator Pattern 
    public interface PanelNofi
    {
        string sendMessage(string message);
    }

    public class SendNotifBySocket : PanelNofi
    {
        public string sendMessage(string message)
        {
            return message; 
        }
    }


    public class CustomeMessage : PanelNofi
    {
        private readonly PanelNofi _panelNofi;

        public CustomeMessage(PanelNofi panelNofi)
        {
            _panelNofi = panelNofi;
        }

        public string sendMessage(string message)
        {
            var res = _panelNofi.sendMessage(message) + "CustomeMEssage";
            return res;
        }
    }
}
