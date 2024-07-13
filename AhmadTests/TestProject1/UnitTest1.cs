using AhmadTests;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var testeNotif = new SendNotifBySocket();
            testeNotif.sendMessage("hELLO My name is ");

            var customeMEsgage = new CustomeMessage(testeNotif);
            var res = customeMEsgage.sendMessage("sss");
        }
    }
}