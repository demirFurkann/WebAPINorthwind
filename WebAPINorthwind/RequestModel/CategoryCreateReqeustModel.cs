using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPINorthwind.RequestModel
{

	// Kullanıcı bir Kategori eklemek için nasıl bir veri göndermeli bunu tasarlıyoruız
	public class CategoryCreateReqeustModel
	{
		public string CategoryName { get; set; }

		public string Description { get; set; }
	}
}