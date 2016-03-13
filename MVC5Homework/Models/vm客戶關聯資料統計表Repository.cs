using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Homework.Models
{   
	public  class vm客戶關聯資料統計表Repository : EFRepository<vm客戶關聯資料統計表>, Ivm客戶關聯資料統計表Repository
	{

	}

	public  interface Ivm客戶關聯資料統計表Repository : IRepository<vm客戶關聯資料統計表>
	{

	}
}