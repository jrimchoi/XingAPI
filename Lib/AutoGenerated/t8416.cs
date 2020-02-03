﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8416InBlock : XingBlock
	{
		/// <summary>
		/// t8416InBlock
		/// </summary>
		static readonly string _blockName = "t8416InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t8416InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8416InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본입력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 주기구분(2:일3:주4:월)
		/// </summary>
		[XAQueryFieldAttribute("주기구분(2:일3:주4:월)")]
		public char gubun;
		/// <summary>
		/// 요청건수(최대-압축:2000비압축:500)
		/// </summary>
		[XAQueryFieldAttribute("요청건수(최대-압축:2000비압축:500)")]
		public long qrycnt;
		/// <summary>
		/// 시작일자
		/// </summary>
		[XAQueryFieldAttribute("시작일자")]
		public string sdate;
		/// <summary>
		/// 종료일자
		/// </summary>
		[XAQueryFieldAttribute("종료일자")]
		public string edate;
		/// <summary>
		/// 연속일자
		/// </summary>
		[XAQueryFieldAttribute("연속일자")]
		public string cts_date;
		/// <summary>
		/// 압축여부(Y:압축N:비압축)
		/// </summary>
		[XAQueryFieldAttribute("압축여부(Y:압축N:비압축)")]
		public char comp_yn;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 주기구분(2:일3:주4:월)
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 요청건수(최대-압축:2000비압축:500)
			/// </summary>
			public const string qrycnt = "qrycnt";
			/// <summary>
			/// 시작일자
			/// </summary>
			public const string sdate = "sdate";
			/// <summary>
			/// 종료일자
			/// </summary>
			public const string edate = "edate";
			/// <summary>
			/// 연속일자
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// 압축여부(Y:압축N:비압축)
			/// </summary>
			public const string comp_yn = "comp_yn";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun,
			F.qrycnt,
			F.sdate,
			F.edate,
			F.cts_date,
			F.comp_yn,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "주기구분(2:일3:주4:월)", (decimal)1);
			dict["qrycnt"] = new XAQueryFieldInfo("long", qrycnt, qrycnt.ToString("d4"), "요청건수(최대-압축:2000비압축:500)", (decimal)4);
			dict["sdate"] = new XAQueryFieldInfo("char", sdate, sdate, "시작일자", (decimal)8);
			dict["edate"] = new XAQueryFieldInfo("char", edate, edate, "종료일자", (decimal)8);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "연속일자", (decimal)8);
			dict["comp_yn"] = new XAQueryFieldInfo("char", comp_yn, comp_yn.ToString(), "압축여부(Y:압축N:비압축)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "qrycnt":
					this.qrycnt = fieldInfo.FieldValue.ParseLong("qrycnt");
				break;

				case "sdate":
					this.sdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "edate":
					this.edate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "comp_yn":
					this.comp_yn = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode.Length > 8) return false; // char 8
			// gubun char 1
			if (qrycnt.ToString().Length > 4) return false; // long 4
			if (sdate.Length > 8) return false; // char 8
			if (edate.Length > 8) return false; // char 8
			if (cts_date.Length > 8) return false; // char 8
			// comp_yn char 1

			return true;
		}
	}

	public partial class XQt8416OutBlock : XingBlock
	{
		/// <summary>
		/// t8416OutBlock
		/// </summary>
		static readonly string _blockName = "t8416OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t8416OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8416OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 전일시가
		/// </summary>
		[XAQueryFieldAttribute("전일시가")]
		public float jisiga;
		/// <summary>
		/// 전일고가
		/// </summary>
		[XAQueryFieldAttribute("전일고가")]
		public float jihigh;
		/// <summary>
		/// 전일저가
		/// </summary>
		[XAQueryFieldAttribute("전일저가")]
		public float jilow;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public float jiclose;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("전일거래량")]
		public long jivolume;
		/// <summary>
		/// 당일시가
		/// </summary>
		[XAQueryFieldAttribute("당일시가")]
		public float disiga;
		/// <summary>
		/// 당일고가
		/// </summary>
		[XAQueryFieldAttribute("당일고가")]
		public float dihigh;
		/// <summary>
		/// 당일저가
		/// </summary>
		[XAQueryFieldAttribute("당일저가")]
		public float dilow;
		/// <summary>
		/// 당일종가
		/// </summary>
		[XAQueryFieldAttribute("당일종가")]
		public float diclose;
		/// <summary>
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("상한가")]
		public float highend;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("하한가")]
		public float lowend;
		/// <summary>
		/// 연속일자
		/// </summary>
		[XAQueryFieldAttribute("연속일자")]
		public string cts_date;
		/// <summary>
		/// 장시작시간(HHMMSS)
		/// </summary>
		[XAQueryFieldAttribute("장시작시간(HHMMSS)")]
		public string s_time;
		/// <summary>
		/// 장종료시간(HHMMSS)
		/// </summary>
		[XAQueryFieldAttribute("장종료시간(HHMMSS)")]
		public string e_time;
		/// <summary>
		/// 동시호가처리시간(MM:분)
		/// </summary>
		[XAQueryFieldAttribute("동시호가처리시간(MM:분)")]
		public string dshmin;
		/// <summary>
		/// 레코드카운트
		/// </summary>
		[XAQueryFieldAttribute("레코드카운트")]
		public long rec_count;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 전일시가
			/// </summary>
			public const string jisiga = "jisiga";
			/// <summary>
			/// 전일고가
			/// </summary>
			public const string jihigh = "jihigh";
			/// <summary>
			/// 전일저가
			/// </summary>
			public const string jilow = "jilow";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jiclose = "jiclose";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jivolume = "jivolume";
			/// <summary>
			/// 당일시가
			/// </summary>
			public const string disiga = "disiga";
			/// <summary>
			/// 당일고가
			/// </summary>
			public const string dihigh = "dihigh";
			/// <summary>
			/// 당일저가
			/// </summary>
			public const string dilow = "dilow";
			/// <summary>
			/// 당일종가
			/// </summary>
			public const string diclose = "diclose";
			/// <summary>
			/// 상한가
			/// </summary>
			public const string highend = "highend";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string lowend = "lowend";
			/// <summary>
			/// 연속일자
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// 장시작시간(HHMMSS)
			/// </summary>
			public const string s_time = "s_time";
			/// <summary>
			/// 장종료시간(HHMMSS)
			/// </summary>
			public const string e_time = "e_time";
			/// <summary>
			/// 동시호가처리시간(MM:분)
			/// </summary>
			public const string dshmin = "dshmin";
			/// <summary>
			/// 레코드카운트
			/// </summary>
			public const string rec_count = "rec_count";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.jisiga,
			F.jihigh,
			F.jilow,
			F.jiclose,
			F.jivolume,
			F.disiga,
			F.dihigh,
			F.dilow,
			F.diclose,
			F.highend,
			F.lowend,
			F.cts_date,
			F.s_time,
			F.e_time,
			F.dshmin,
			F.rec_count,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);
			dict["jisiga"] = new XAQueryFieldInfo("float", jisiga, jisiga.ToString("000000.00"), "전일시가", (decimal)6.2);
			dict["jihigh"] = new XAQueryFieldInfo("float", jihigh, jihigh.ToString("000000.00"), "전일고가", (decimal)6.2);
			dict["jilow"] = new XAQueryFieldInfo("float", jilow, jilow.ToString("000000.00"), "전일저가", (decimal)6.2);
			dict["jiclose"] = new XAQueryFieldInfo("float", jiclose, jiclose.ToString("000000.00"), "전일종가", (decimal)6.2);
			dict["jivolume"] = new XAQueryFieldInfo("long", jivolume, jivolume.ToString("d12"), "전일거래량", (decimal)12);
			dict["disiga"] = new XAQueryFieldInfo("float", disiga, disiga.ToString("000000.00"), "당일시가", (decimal)6.2);
			dict["dihigh"] = new XAQueryFieldInfo("float", dihigh, dihigh.ToString("000000.00"), "당일고가", (decimal)6.2);
			dict["dilow"] = new XAQueryFieldInfo("float", dilow, dilow.ToString("000000.00"), "당일저가", (decimal)6.2);
			dict["diclose"] = new XAQueryFieldInfo("float", diclose, diclose.ToString("000000.00"), "당일종가", (decimal)6.2);
			dict["highend"] = new XAQueryFieldInfo("float", highend, highend.ToString("000000.00"), "상한가", (decimal)6.2);
			dict["lowend"] = new XAQueryFieldInfo("float", lowend, lowend.ToString("000000.00"), "하한가", (decimal)6.2);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "연속일자", (decimal)8);
			dict["s_time"] = new XAQueryFieldInfo("char", s_time, s_time, "장시작시간(HHMMSS)", (decimal)6);
			dict["e_time"] = new XAQueryFieldInfo("char", e_time, e_time, "장종료시간(HHMMSS)", (decimal)6);
			dict["dshmin"] = new XAQueryFieldInfo("char", dshmin, dshmin, "동시호가처리시간(MM:분)", (decimal)2);
			dict["rec_count"] = new XAQueryFieldInfo("long", rec_count, rec_count.ToString("d7"), "레코드카운트", (decimal)7);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisiga":
					this.jisiga = fieldInfo.FieldValue.ParseFloat("jisiga");
				break;

				case "jihigh":
					this.jihigh = fieldInfo.FieldValue.ParseFloat("jihigh");
				break;

				case "jilow":
					this.jilow = fieldInfo.FieldValue.ParseFloat("jilow");
				break;

				case "jiclose":
					this.jiclose = fieldInfo.FieldValue.ParseFloat("jiclose");
				break;

				case "jivolume":
					this.jivolume = fieldInfo.FieldValue.ParseLong("jivolume");
				break;

				case "disiga":
					this.disiga = fieldInfo.FieldValue.ParseFloat("disiga");
				break;

				case "dihigh":
					this.dihigh = fieldInfo.FieldValue.ParseFloat("dihigh");
				break;

				case "dilow":
					this.dilow = fieldInfo.FieldValue.ParseFloat("dilow");
				break;

				case "diclose":
					this.diclose = fieldInfo.FieldValue.ParseFloat("diclose");
				break;

				case "highend":
					this.highend = fieldInfo.FieldValue.ParseFloat("highend");
				break;

				case "lowend":
					this.lowend = fieldInfo.FieldValue.ParseFloat("lowend");
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "s_time":
					this.s_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "e_time":
					this.e_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dshmin":
					this.dshmin = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rec_count":
					this.rec_count = fieldInfo.FieldValue.ParseLong("rec_count");
				break;


			}
		}

		public static XQt8416OutBlock FromQuery(XQt8416 query)
		{
			XQt8416OutBlock block = new XQt8416OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				block.IsValidData = false;
				block.InvalidReason = query.ReceiveMessage;
				return block;
			}
			try
			{
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 8
				block.jisiga = query.GetFieldData(block.GetBlockName(), "jisiga", 0).ParseFloat("jisiga"); // float 6.2
				block.jihigh = query.GetFieldData(block.GetBlockName(), "jihigh", 0).ParseFloat("jihigh"); // float 6.2
				block.jilow = query.GetFieldData(block.GetBlockName(), "jilow", 0).ParseFloat("jilow"); // float 6.2
				block.jiclose = query.GetFieldData(block.GetBlockName(), "jiclose", 0).ParseFloat("jiclose"); // float 6.2
				block.jivolume = query.GetFieldData(block.GetBlockName(), "jivolume", 0).ParseLong("jivolume"); // long 12
				block.disiga = query.GetFieldData(block.GetBlockName(), "disiga", 0).ParseFloat("disiga"); // float 6.2
				block.dihigh = query.GetFieldData(block.GetBlockName(), "dihigh", 0).ParseFloat("dihigh"); // float 6.2
				block.dilow = query.GetFieldData(block.GetBlockName(), "dilow", 0).ParseFloat("dilow"); // float 6.2
				block.diclose = query.GetFieldData(block.GetBlockName(), "diclose", 0).ParseFloat("diclose"); // float 6.2
				block.highend = query.GetFieldData(block.GetBlockName(), "highend", 0).ParseFloat("highend"); // float 6.2
				block.lowend = query.GetFieldData(block.GetBlockName(), "lowend", 0).ParseFloat("lowend"); // float 6.2
				block.cts_date = query.GetFieldData(block.GetBlockName(), "cts_date", 0).TrimEnd('?'); // char 8
				block.s_time = query.GetFieldData(block.GetBlockName(), "s_time", 0).TrimEnd('?'); // char 6
				block.e_time = query.GetFieldData(block.GetBlockName(), "e_time", 0).TrimEnd('?'); // char 6
				block.dshmin = query.GetFieldData(block.GetBlockName(), "dshmin", 0).TrimEnd('?'); // char 2
				block.rec_count = query.GetFieldData(block.GetBlockName(), "rec_count", 0).ParseLong("rec_count"); // long 7

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (shcode.Length > 8) return false; // char 8
			// jisiga float 6.2
			// jihigh float 6.2
			// jilow float 6.2
			// jiclose float 6.2
			if (jivolume.ToString().Length > 12) return false; // long 12
			// disiga float 6.2
			// dihigh float 6.2
			// dilow float 6.2
			// diclose float 6.2
			// highend float 6.2
			// lowend float 6.2
			if (cts_date.Length > 8) return false; // char 8
			if (s_time.Length > 6) return false; // char 6
			if (e_time.Length > 6) return false; // char 6
			if (dshmin.Length > 2) return false; // char 2
			if (rec_count.ToString().Length > 7) return false; // long 7

			return true;
		}
	}

	public partial class XQt8416OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8416OutBlock1
		/// </summary>
		static readonly string _blockName = "t8416OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t8416OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8416OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력1
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public float low;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("종가")]
		public float close;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long jdiff_vol;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("거래대금")]
		public long value;
		/// <summary>
		/// 미결제약정
		/// </summary>
		[XAQueryFieldAttribute("미결제약정")]
		public long openyak;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string jdiff_vol = "jdiff_vol";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 미결제약정
			/// </summary>
			public const string openyak = "openyak";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.open,
			F.high,
			F.low,
			F.close,
			F.jdiff_vol,
			F.value,
			F.openyak,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["close"] = new XAQueryFieldInfo("float", close, close.ToString("000000.00"), "종가", (decimal)6.2);
			dict["jdiff_vol"] = new XAQueryFieldInfo("long", jdiff_vol, jdiff_vol.ToString("d12"), "누적거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);
			dict["openyak"] = new XAQueryFieldInfo("long", openyak, openyak.ToString("d12"), "미결제약정", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseFloat("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseFloat("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseFloat("low");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseFloat("close");
				break;

				case "jdiff_vol":
					this.jdiff_vol = fieldInfo.FieldValue.ParseLong("jdiff_vol");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "openyak":
					this.openyak = fieldInfo.FieldValue.ParseLong("openyak");
				break;


			}
		}

		public static XQt8416OutBlock1[] ListFromQuery(XQt8416 query)
		{
			int count = query.GetBlockCount(XQt8416OutBlock1.BlockName);
			List<XQt8416OutBlock1> list = new List<XQt8416OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8416OutBlock1 block = new XQt8416OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 6.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 6.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 6.2
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseFloat("close"); // float 6.2
					block.jdiff_vol = query.GetFieldData(block.GetBlockName(), "jdiff_vol", i).ParseLong("jdiff_vol"); // long 12
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.openyak = query.GetFieldData(block.GetBlockName(), "openyak", i).ParseLong("openyak"); // long 12

				} catch (InvalidDataFormatException e) {
					block.IsValidData = false;
					block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
				}
				list.Add(block);
			}
			return list.ToArray();

		}

		public bool VerifyData()
		{
			if (date.Length > 8) return false; // char 8
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// close float 6.2
			if (jdiff_vol.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (openyak.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt8416 : XingQuery
	{
		/// <summary>
		/// t8416
		/// </summary>
		static readonly string _typeName = "t8416";
		/// <summary>
		/// 선물/옵션챠트(일주월)(t8416)
		/// </summary>
		static readonly string _typeDesc = "선물/옵션챠트(일주월)(t8416)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

		/// <summary>
		/// t8416
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물/옵션챠트(일주월)(t8416)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// A
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// true
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// true
		/// </summary>
		public bool Block => _block;
		/// <summary>
		/// false
		/// </summary>
		public bool Encrypt => _encrypt;
		/// <summary>
		/// false
		/// </summary>
		public bool Signature => _signature;

		public XQt8416() : base("t8416") { }


		public bool SetFields(XQt8416InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "qrycnt", 0, block.qrycnt.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "sdate", 0, block.sdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "edate", 0, block.edate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_date", 0, block.cts_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "comp_yn", 0, block.comp_yn.ToString()); // char 1

			return true;
		}

		public XQt8416OutBlock GetBlock()
		{
			XQt8416OutBlock instance = XQt8416OutBlock.FromQuery(this);
			return instance;

		}

		public XQt8416OutBlock1[] GetBlock1s()
		{
			XQt8416OutBlock1[] instance = XQt8416OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
