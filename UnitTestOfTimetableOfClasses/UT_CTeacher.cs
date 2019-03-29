﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_CTeacher
	{
		[TestMethod]
		public void Task_128_1()
		{
			Controllers.CTeacher.Select().Clear();
			bool ex = true;
			bool act;
			MTeacher M_Teacher = new MTeacher("Садовская", "Ольга", "Борисовна", 
				"Кандидат наук","Профессор", 40);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_128_2()
		{
			Task_128_1();
			bool ex = true;
			bool act;
			MTeacher M_Teacher = new MTeacher("Киприна", "Людмила", "Юрьевна",
				"Доктор наук", "Доцент", 20);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1+1, C2);
		}

		[TestMethod]
		public void Task_128_3()
		{
			Task_128_1();
			bool ex = true;
			bool act;
			MTeacher M_Teacher = new MTeacher("Садовская", "Людмила", "Юрьевна",
				"Доктор наук", "Доцент", 20);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);

		}
		[TestMethod]
		public void Task_128_4()
		{
			Task_128_1();
			bool ex = true;
			bool act;
			MTeacher M_Teacher = new MTeacher("Киприна", "Ольга", "Юрьевна",
				"Доктор наук", "Доцент", 20);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_128_5()
		{
			Task_128_1();
			bool ex = true;
			bool act;
			MTeacher M_Teacher = new MTeacher("Киприна", "Людмила", "Борисовна",
				"Доктор наук", "Доцент", 20);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_128_6()
		{
			Task_128_1();
			bool ex = true;
			bool act;
			MTeacher M_Teacher = new MTeacher("Киприна", "Людмила", "Юрьевна",
				"Кандидат наук", "Доцент", 20);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_128_7()
		{
			Task_128_1();
			bool ex = true;
			bool act;
			MTeacher M_Teacher = new MTeacher("Киприна", "Людмила", "Юрьевна",
				"Доктор наук", "Профессор", 20);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_128_8()
		{
			Task_128_1();
			bool ex = true;
			bool act;
			MTeacher M_Teacher = new MTeacher("Киприна", "Людмила", "Юрьевна",
				"Доктор наук", "Доцент", 40);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_128_9()
		{
			Task_128_1();
			bool ex = false;
			bool act;
			MTeacher M_Teacher = new MTeacher("Садовская", "Ольга", "Борисовна",
				"Кандидат наук", "Профессор", 40);
			int C1 = Controllers.CTeacher.Select().Rows.Count;
			act = Controllers.CTeacher.Insert(M_Teacher);
			int C2 = Controllers.CTeacher.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}
	}
}
