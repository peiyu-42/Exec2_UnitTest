using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwainStock.Utility
{
	/// <summary>
	/// 台灣股市
	/// </summary>
	public class TaiwainStockUtility
	{
		/// <summary>
		/// 是否在營業的時間
		/// </summary>
		/// <param name="dt">時間</param>
		/// <returns></returns>
		public bool IsTradingTime(DateTime dt)
		{
			// 判斷是星期幾
			int weekDay = (int)dt.DayOfWeek;

			// 營業時間
			DateTime startTime = new DateTime(dt.Year, dt.Month, dt.Day, 9, 0, 0);
			DateTime endTime = new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0);

			// 如果在營業時間內回true，反則是false
			if ((weekDay >= 1 && weekDay <= 5) && (dt.CompareTo(startTime) >= 0 && dt.CompareTo(endTime) <= 0))
			{ return true; }
			return false;
		}
	}
}
