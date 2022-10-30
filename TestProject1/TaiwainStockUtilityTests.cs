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
		[TestCase("2022/10/29 9:01:00")]
		[TestCase("2022/10/30 13:29:00")]
		public void TradingTimeTest_星期六日傳回false(string dt)
		{
			var obj = new TaiwainStockUtility();

			bool result = obj.IsTradingTime(Convert.ToDateTime(dt));

			Assert.IsFalse( result);
		}

		[TestCase("2022/10/27 8:59:59")]
		[TestCase("2022/10/27 13:30:01")]
		public void TradingTimeTest_不在營業時間內傳回false(string dt)
		{
			var obj = new TaiwainStockUtility();

			bool result = obj.IsTradingTime(Convert.ToDateTime(dt));

			Assert.IsFalse(result);
		}

		[TestCase("2022/10/28 9:00:01")]
		[TestCase("2022/10/27 9:00:01")]
		[TestCase("2022/10/26 9:00:01")]
		[TestCase("2022/10/25 9:00:01")]
		[TestCase("2022/10/24 9:00:01")]
		[TestCase("2022/10/28 13:30:00")]
		public void TradingTimeTest_在週一到週五的營業時間內傳回true(string dt)
		{
			var obj = new TaiwainStockUtility();

			bool result = obj.IsTradingTime(Convert.ToDateTime(dt));

			Assert.IsTrue(result);
		}
	}
}
