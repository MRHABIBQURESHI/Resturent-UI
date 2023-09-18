namespace Resturent_App
{
    internal class sqlCommand
    {
        public SqlConnection Connection { get; internal set; }
        public object Commandtext { get; internal set; }

        internal int ExecuteNonquery()
        {
            throw new NotImplementedException();
        }
    }
}