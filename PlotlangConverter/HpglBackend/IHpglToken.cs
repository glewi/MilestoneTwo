namespace PlotlangConverter.HpglBackend
{
    interface IHpglToken
    {
        string GetCommand();
    }

    public class HpglRectangle : IHpglToken
    {
        public HpglRectangle(params object[] vs)
        {

        }

        public string GetCommand()
        {
            string cmd = "";
            return cmd;
        }
    }

    public class HpglCircle : IHpglToken
    {
        public string GetCommand()
        {
            string cmd = "";
            return cmd;
        }
    }
}
