using System;
using DataLayer;

namespace BusinessLayer
{
    //Layer Supertype
	public interface IEntity
	{
        
        public void Insert();
        public void SynchroniseDataWithDatabase();
        public void SynchroniseDataWithDatabaseByPK(int pk);
        public void Delete();

    }
}

