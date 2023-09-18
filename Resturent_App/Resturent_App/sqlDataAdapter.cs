using System.Data;

namespace Resturent_App
{
    internal class sqlDataAdapter
    {
        private string query;
        private string constr;

        public sqlDataAdapter(string query, string constr)
        {
            this.query = query;
            this.constr = constr;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}