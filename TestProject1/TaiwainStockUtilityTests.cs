using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiwainStock.Utility;

namespace TestProject1
{
	internal class TaiwainStockUtilityTests
	{
		[TestCase("2022/10/29")]
		[TestCase("2022/10/30")]
		public void TradingTimeTest_星期六日傳回false(string dt)
		{
			var obj = new TaiwainStockUtility();

			bool result = obj.IsTradingTime(Convert.ToDateTime(dt));

			Assert.IsFalse( result);
		}

		[TestCase("2022/10/27 8:59:59")]
		[TestCase("2022/10/27 13:30:1")]
		public void TradingTimeTest_不是營業時間傳回false(string dt)
		{
			var obj = new TaiwainStockUtility();

			bool result = obj.IsTradingTime(Convert.ToDateTime(dt));

			Assert.IsFalse(result);
		}

		[TestCase("2022/10/27 9:00:00")]
		[TestCase("2022/10/27 13:30:00")]
		public void TradingTimeTest_在營業的日期與時間內傳回true(string dt)
		{
			var obj = new TaiwainStockUtility();

			bool result = obj.IsTradingTime(Convert.ToDateTime(dt));

			Assert.IsTrue(result);
		}
	}
}
